using BarberiaPerez_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace BarberiaPerez_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportesController : ControllerBase
    {
        [HttpPost("reportes_clientes")]
        public IActionResult ReportesClientes([FromBody] List<ReporteClienteModel> reportes)
        {
            // Lógica para manejar reportes de clientes
            return Ok("Reportes de clientes procesados"); // Ejemplo de respuesta
        }

        [HttpPost("reportes_barberos")]
        public IActionResult ReportesBarberos([FromBody] List<ReporteBarberoModel> reportes)
        {
            // Lógica para manejar reportes de barberos
            return Ok("Reportes de barberos procesados"); // Ejemplo de respuesta
        }
    }
}
