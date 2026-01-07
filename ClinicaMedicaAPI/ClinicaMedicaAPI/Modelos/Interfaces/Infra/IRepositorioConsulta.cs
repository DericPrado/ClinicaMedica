using ClinicaMedicaAPI.Modelos.Entidades;

namespace ClinicaMedicaAPI.Modelos.Interfaces.Infra
{
    public interface IRepositorioConsulta
    {
        public Task<bool> Registrar(Consulta consulta);
        public Task<bool> Atualizar(Consulta consulta);
        public Task<bool> Deletar(Guid id);
        public Task<List<Consulta>> RecuperarConsultasAtivas();
        public Task<Consulta> RecuperarConsultaPorId(Guid id);
        public Task<List<Consulta>> RecuperarConsultasPorIdMedico(Guid id);
        public Task<List<Consulta>> RecuperarConsultasPorIdPaciente(Guid id);
        public Task<Guid> GerarId();
    }
}
