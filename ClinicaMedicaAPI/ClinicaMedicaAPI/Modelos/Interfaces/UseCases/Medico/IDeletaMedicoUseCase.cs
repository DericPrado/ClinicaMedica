namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico
{
    public interface IDeletaMedicoUseCase
    {
        public Task<bool> Executar(Guid id);
    }
}
