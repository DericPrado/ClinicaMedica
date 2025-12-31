namespace ClinicaMedicaAPI.Modelos.DTOs.Medico
{
    public class RequestRegistraMedico
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Crm { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
