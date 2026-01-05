using ClinicaMedicaAPI.Modelos.DTOs.Agenda;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta
{
    public interface IRegistraConsultaUseCase
    {
        public Task<bool> Executar(RequestRegistraConsulta request);
    }
}
