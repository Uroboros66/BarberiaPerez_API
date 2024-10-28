using BarberiaPerez_API.Models;

namespace ElimperioAPI.Models
{
    public class UserLoginRequest : UsuarioModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
    }
}
