using BarberiaPerez_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberiaPerez_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            // Aquí iría la lógica de autenticación
            return Ok("Login exitoso"); // Ejemplo de respuesta
        }

        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] SignUpModel signUp)
        {
            // Aquí iría la lógica de registro de usuario
            return Ok("Registro exitoso"); // Ejemplo de respuesta
        }
    }
}
