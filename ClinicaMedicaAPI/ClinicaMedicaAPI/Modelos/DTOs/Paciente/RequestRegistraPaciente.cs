namespace ClinicaMedicaAPI.Modelos.DTOs.Paciente
{
    public class RequestRegistraPaciente
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}
