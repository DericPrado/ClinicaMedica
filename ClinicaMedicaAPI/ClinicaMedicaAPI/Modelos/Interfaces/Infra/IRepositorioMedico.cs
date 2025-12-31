using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Infra
{
    public interface IRepositorioMedico
    {
        public Task<bool> Registrar(Medico medico);
        public Task<bool> Atualizar(Medico request);
        public Task<List<Medico>> ListarMedicosAtivos();
        public Task<Medico> ListaMedicoPorId(Guid id);
        public Task<bool> DeletarMedicoPorId(Guid id);
    }
}
