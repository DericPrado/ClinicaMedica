namespace ClinicaMedicaAPI.Modelos.DTOs.Agenda
{
    public class RequestRegistraConsulta
    {
        public Guid IdMedico { get; set; }
        public Guid IdPaciente { get; set; }
        public DateTime Data {  get; set; }
    }
}
