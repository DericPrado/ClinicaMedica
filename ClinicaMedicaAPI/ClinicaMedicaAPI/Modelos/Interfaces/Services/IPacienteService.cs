using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Services
{
    public interface IPacienteService
    {
        public Task<bool> Registrar(Paciente paciente);
        public Task<bool> Atualizar(Paciente paciente);
        public Task<List<Paciente>> ListarPacientesAtivos();
        public Task<Paciente> ListaPacientePorId(Guid id);
        public Task<bool> DeletarPacientePorId(Guid id);
    }
}
