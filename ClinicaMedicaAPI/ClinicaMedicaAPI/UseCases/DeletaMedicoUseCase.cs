using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases
{
    public class DeletaMedicoUseCase : IDeletaMedicoUseCase
    {
        private IMedicoService _medicoService;

        public DeletaMedicoUseCase(IMedicoService medicicoService)
        {
            _medicoService = medicicoService;
        }

        public async Task<bool> Executar(Guid id)
        {
            return await _medicoService.DeletarMedicoPorId(id);
        }
    }
}
