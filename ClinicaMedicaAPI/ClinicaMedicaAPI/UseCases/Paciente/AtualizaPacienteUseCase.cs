using ClinicaMedicaAPI.Modelos.DTOs.Paciente;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;

namespace ClinicaMedicaAPI.UseCases.Paciente
{
    public class AtualizaPacienteUseCase : IAtualizaPacienteUseCase
    {
        private IPacienteService _pacienteService;

        public AtualizaPacienteUseCase(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        public async Task<bool> Executar(RequestAtualizaPaciente request)
        {
            try
            {
                return await _pacienteService.Atualizar(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
