using ClinicaMedicaAPI.Modelos.DTOs.Consulta;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta
{
    public interface IAtualizaConsultaUseCase
    {
        public Task<bool> Executar(RequestAtualizaConsulta request);
    }
}
