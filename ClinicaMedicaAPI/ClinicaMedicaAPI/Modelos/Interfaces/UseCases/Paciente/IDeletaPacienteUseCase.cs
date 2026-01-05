namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente
{
    public interface IDeletaPacienteUseCase
    {
        public Task<bool> Executar(Guid id);
    }
}
