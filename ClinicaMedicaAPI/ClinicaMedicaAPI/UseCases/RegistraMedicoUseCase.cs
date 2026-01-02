using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases
{
    public class RegistraMedicoUseCase : IRegistraMedicoUseCase
    {
        private IMedicoService _medicoService;

        public RegistraMedicoUseCase(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public async Task<bool> Executar(RequestRegistraMedico request)
        {
            return await _medicoService.Registrar(request);
        }
    }
}
