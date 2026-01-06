using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Services
{
    public interface IMedicoService
    {
        public Task<bool> Registrar(Medico request);
        public Task<bool> Atualizar(Medico request);
        public Task<List<Medico>> ListarMedicosAtivos();
        public Task<Medico> ListaMedicoPorId(Guid id);
        public Task<bool> DeletarMedicoPorId(Guid id);
    }
}
