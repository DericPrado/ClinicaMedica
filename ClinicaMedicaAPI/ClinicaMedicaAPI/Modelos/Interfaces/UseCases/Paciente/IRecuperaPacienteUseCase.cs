namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente
{
    public interface IRecuperaPacienteUseCase
    {
        public Task<Entidades.Paciente> RecuperarPorId(Guid id);
        public Task<List<Entidades.Paciente>> RecuperarPacientesAtivos();
    }
}
