using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Services
{
    public interface IMedicoService
    {
        public Task<bool> Registrar(RequestRegistraMedico request);
        public Task<bool> Atualizar(RequestAtualizaMedico request);
        public Task<List<Medico>> ListarMedicosAtivos();
        public Task<Medico> ListaMedicoPorId(Guid id);
        public Task<bool> DeletarMedicoPorId(Guid id);
    }
}
