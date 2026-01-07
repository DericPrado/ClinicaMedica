using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;

namespace ClinicaMedicaAPI.Services
{
    public class MedicoService : IMedicoService
    {
        private IRepositorioMedico _DbContext;
        
        public MedicoService(IRepositorioMedico dbcontext)
        {
            _DbContext = dbcontext;
        }

        public async Task<bool> Atualizar(Medico medico)
        {
            return await _DbContext.Atualizar(medico);
        }

        public async Task<bool> DeletarMedicoPorId(Guid id)
        {
            return await _DbContext.DeletarMedicoPorId(id);
        }

        public async Task<Medico> ListaMedicoPorId(Guid id)
        {
            return await _DbContext.ListaMedicoPorId(id);
        }

        public async Task<List<Medico>> ListarMedicosAtivos()
        {
            return await _DbContext.ListarMedicosAtivos();
        }

        public async Task<bool> Registrar(Medico medico)
        {
            return await _DbContext.Registrar(medico);
        }
    }
}
