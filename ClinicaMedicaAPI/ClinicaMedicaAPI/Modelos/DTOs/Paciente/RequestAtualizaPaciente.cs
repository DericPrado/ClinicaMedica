namespace ClinicaMedicaAPI.Modelos.DTOs.Paciente
{
    public class RequestAtualizaPaciente : RequestRegistraPaciente
    {
        public Guid Id { get; set; }
    }
}
