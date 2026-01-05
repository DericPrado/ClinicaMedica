using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases.Medico
{
    public class AtualizaMedicoUseCase : IAtualizaMedicoUseCase
    {
        private IMedicoService _medicoService;

        public AtualizaMedicoUseCase (IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public async Task<bool> Executar(RequestAtualizaMedico request)
        {
            return await _medicoService.Atualizar(request);
        }
    }
}
