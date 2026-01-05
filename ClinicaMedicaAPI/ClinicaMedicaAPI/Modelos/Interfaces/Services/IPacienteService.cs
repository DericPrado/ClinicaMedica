using ClinicaMedicaAPI.Modelos.DTOs.Paciente;
using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Services
{
    public interface IPacienteService
    {
        public Task<bool> Registrar(RequestRegistraPaciente request);
        public Task<bool> Atualizar(RequestAtualizaPaciente request);
        public Task<List<Paciente>> ListarPacientesAtivos();
        public Task<Paciente> ListaPacientePorId(Guid id);
        public Task<bool> DeletarPacientePorId(Guid id);
    }
}
