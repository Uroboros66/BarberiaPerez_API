using BarberiaPerez_API.Models;
using BarberiaPerez_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
///using System.Threading.Tasks;

namespace BarberiaPerez_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IConfiguration _configuration;

        public UsuarioController(IUsuarioService usuarioService, IConfiguration configuration)
        {
            _usuarioService = usuarioService;
            _configuration = configuration;
        }






        [HttpPost("login")]
        public async Task<IActionResult> SignUp([FromBody] UsuarioModel signUpModel)
        {

            var existingUser = await _usuarioService.ObtenerUsuarioAsync(signUpModel.Nombre);

            if (existingUser == null || existingUser.Contraseña != signUpModel.Contraseña)
                return Unauthorized();

            var token = GenerateJwtToken(existingUser.Nombre);
            return Ok(new { Token = token });
            //if (signUpModel == null || !ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //try
            //{
            //    // Llamar al servicio para crear el usuario
            //    var nuevoUsuario = await _usuarioService.CrearUsuario(signUpModel);
            //    return CreatedAtAction(nameof(SignUp), new { id = nuevoUsuario.Id }, nuevoUsuario);
            //}
            //catch (Exception ex)
            //{
            //    // Manejo de excepciones en caso de errores al crear el usuario
            //    return BadRequest(new { message = ex.Message });
            //}
        }


        private string GenerateJwtToken(string Nombre)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, Nombre),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost("singup")]
        public async Task<IActionResult> Register([FromBody] UsuarioModel usuarioModel)
        {
            // Verificar si el usuario ya existe
            var existingUser = await _usuarioService.ObtenerUsuarioAsync(usuarioModel.Nombre);
            if (existingUser != null)
            {
                return Conflict("El usuario ya existe.");
            }

            // Crear un nuevo SignUpModel basado en UsuarioModel
            var signUpModel = new SignUpModel
            {
                Nombre = usuarioModel.Nombre,
                Contraseña = usuarioModel.Contraseña,
                ConfirmarContraseña = usuarioModel.Contraseña // Asumimos que se confirma con la misma contraseña
            };

            // Llamar al servicio para crear el nuevo usuario
            await _usuarioService.CrearUsuario(signUpModel);
            return Ok("Usuario registrado exitosamente.");
        }




        // Otros métodos como Login pueden ir aquí
    }
}
