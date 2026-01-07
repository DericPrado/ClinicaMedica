using ClinicaMedicaAPI.Modelos.DTOs.Medico;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico
{
    public interface IAtualizaMedicoUseCase
    {
        public Task<bool> Executar(RequestAtualizaMedico request);
    }
}
