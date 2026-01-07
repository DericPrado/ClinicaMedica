using ClinicaMedicaAPI.Modelos.DTOs.Agenda;

namespace ClinicaMedicaAPI.Modelos.DTOs.Consulta
{
    public class RequestAtualizaConsulta : RequestRegistraConsulta
    {
        public Guid IdConsulta { get; set; }
    }
}
