using ClinicaMedicaAPI.Modelos.DTOs.Paciente;

namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente
{
    public interface IRegistraPacienteUseCase
    {
        public Task<bool> Executar(RequestRegistraPaciente request);
    }
}
