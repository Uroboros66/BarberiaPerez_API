using BarberiaPerez_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BarberiaPerez_API.Services
{
    public interface ICitaService
    {
        Task<AgendarCitaModel> AgendarCita(AgendarCitaModel cita);
        Task<List<ReporteClienteModel>> ObtenerReportesClientes();
    }
}
