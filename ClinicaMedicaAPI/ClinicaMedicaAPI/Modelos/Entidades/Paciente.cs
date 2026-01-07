namespace ClinicaMedicaAPI.Modelos.Entidades
{
    public class Paciente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Telefone {  get; set; } = string.Empty;
        public bool Ativo {  get; set; }
    }
}
