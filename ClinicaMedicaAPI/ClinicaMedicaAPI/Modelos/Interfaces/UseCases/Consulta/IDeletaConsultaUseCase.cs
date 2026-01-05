namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta
{
    public interface IDeletaConsultaUseCase
    {
        public Task<bool> Executar(Guid id);
    }
}
