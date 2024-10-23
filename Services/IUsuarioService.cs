using Amazon.Runtime.Internal;
using BarberiaPerez_API.Models;
using DnsClient;
using System.Threading.Tasks;

namespace BarberiaPerez_API.Services
{
    public interface IUsuarioService
    {
        Task<SignUpModel> CrearUsuario(SignUpModel usuasignUpModelrio);
        Task<LoginModel> Login(LoginModel login);

        Task<UsuarioModel?> ObtenerUsuarioAsync(string Nombre);

    }
}
