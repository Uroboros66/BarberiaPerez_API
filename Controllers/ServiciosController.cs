using BarberiaPerez_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberiaPerez_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        [HttpGet("servicios_disponibles")]
        public IActionResult GetServiciosDisponibles()
        {
            var servicios = new List<ServicioDisponibleModel>
            {
                new ServicioDisponibleModel { Servicio = "Mascarilla", Precio = 50 },
                new ServicioDisponibleModel { Servicio = "Alisado", Precio = 100 },
                new ServicioDisponibleModel { Servicio = "Barba", Precio = 100 }
            };
            return Ok(servicios);
        }

        [HttpPost("servicios_barbero")]
        public IActionResult ServiciosBarbero([FromBody] List<ServicioBarberoModel> servicios)
        {
            // Lógica para manejar servicios de barberos
            return Ok("Servicios de barberos procesados"); // Ejemplo de respuesta
        }
    }
}
