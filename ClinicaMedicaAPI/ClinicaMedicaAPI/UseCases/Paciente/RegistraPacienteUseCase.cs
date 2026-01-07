using ClinicaMedicaAPI.Modelos.DTOs.Paciente;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;

namespace ClinicaMedicaAPI.UseCases.Paciente
{
    public class RegistraPacienteUseCase : IRegistraPacienteUseCase
    {
        private IPacienteService _pacienteService;

        public RegistraPacienteUseCase(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        public async Task<bool> Executar(RequestRegistraPaciente request)
        {
            try
            {
                if(string.IsNullOrEmpty(request.Telefone) ||
                    string.IsNullOrEmpty(request.Nome) ||
                    string.IsNullOrEmpty(request.CPF))
                {
                    return false;
                }

                var paciente = new Modelos.Entidades.Paciente
                {
                    Nome = request.Telefone,
                    Telefone = request.Nome,
                    CPF = request.CPF,
                    Ativo = true,
                };

                return await _pacienteService.Registrar(paciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
