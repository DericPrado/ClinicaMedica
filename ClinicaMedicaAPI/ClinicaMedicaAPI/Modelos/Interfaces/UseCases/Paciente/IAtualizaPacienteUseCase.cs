using ClinicaMedicaAPI.Modelos.DTOs.Paciente;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente
{
    public interface IAtualizaPacienteUseCase
    {
        public Task<bool> Executar(RequestAtualizaPaciente request);
    }
}
