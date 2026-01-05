namespace ClinicaMedicaAPI.Modelos.Entidades
{
    public class Consulta
    {
        public Guid IdConsulta { get; set; }
        public Guid IdMedico { get; set; }
        public Guid IdPaciente { get; set; }
        public bool Ativa { get; set; }
        public DateTime Data {  get; set; }
    }
}
