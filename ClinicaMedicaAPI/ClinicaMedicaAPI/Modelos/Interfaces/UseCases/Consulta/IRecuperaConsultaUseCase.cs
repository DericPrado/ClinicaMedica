namespace ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta
{
    public interface IRecuperaConsultaUseCase
    {
        public Task<Modelos.Entidades.Consulta> RecuperarConsultaPorId(Guid id);
        public Task<List<Modelos.Entidades.Consulta>> RecuperarConsultasPorIdMedico(Guid id);
        public Task<List<Modelos.Entidades.Consulta>> RecuperarConsultasPorIdPaciente(Guid id);
        public Task<List<Modelos.Entidades.Consulta>> RecuperarConsultasAtivas();
    }
}
