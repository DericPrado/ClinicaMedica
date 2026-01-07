using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico
{
    public interface IRecuperaMedicoUseCase
    {
        public Task<ClinicaMedicaAPI.Modelos.Entidades.Medico> PegarMedicoPorId(Guid id);
        public Task<List<ClinicaMedicaAPI.Modelos.Entidades.Medico>> ListarMedicos();
    }
}
