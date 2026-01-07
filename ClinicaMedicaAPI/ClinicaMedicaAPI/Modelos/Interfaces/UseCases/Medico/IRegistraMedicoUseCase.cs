using ClinicaMedicaAPI.Modelos.DTOs.Medico;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico
{
    public interface IRegistraMedicoUseCase
    {
        public Task<bool> Executar(RequestRegistraMedico request);
    }
}
