using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Infra
{
    public interface IRepositorioPaciente
    {
        public Task<bool> Registrar(Paciente medico);
        public Task<bool> Atualizar(Paciente request);
        public Task<List<Paciente>> ListarPacientesAtivos();
        public Task<Paciente> ListaPacientePorId(Guid id);
        public Task<bool> DeletarPacientePorId(Guid id);
        public Task<Guid> GerarId();
    }
}
