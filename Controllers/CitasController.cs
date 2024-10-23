using BarberiaPerez_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberiaPerez_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        [HttpPost("agendar_cita")]
        public IActionResult AgendarCita([FromBody] AgendarCitaModel cita)
        {
            // Lógica para agendar una cita
            return Ok("Cita agendada con éxito"); // Ejemplo de respuesta
        }
    }
}
