namespace ClinicaMedicaAPI.Modelos.Entidades
{
    public class Medico
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Crm { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Especialidade {  get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
    }
}
