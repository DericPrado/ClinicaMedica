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
                return await _pacienteService.Registrar(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
