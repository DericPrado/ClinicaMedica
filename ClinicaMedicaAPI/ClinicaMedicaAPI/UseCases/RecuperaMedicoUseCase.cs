using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases
{
    public class RecuperaMedicoUseCase : IRecuperaMedicoUseCase
    {
        private IMedicoService _services;

        public RecuperaMedicoUseCase(IMedicoService services)
        {
            _services = services;
        }

        public async Task<List<Medico>> ListarMedicos()
        {
            return await _services.ListarMedicosAtivos();
        }

        public async Task<Medico> PegarMedicoPorId(Guid id)
        {
            return await _services.ListaMedicoPorId(id);
        }
    }
}
