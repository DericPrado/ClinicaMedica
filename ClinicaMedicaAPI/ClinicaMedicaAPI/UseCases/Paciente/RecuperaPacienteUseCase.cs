using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;

namespace ClinicaMedicaAPI.UseCases.Paciente
{
    public class RecuperaPacienteUseCase : IRecuperaPacienteUseCase
    {
        private IPacienteService _pacienteService;

        public RecuperaPacienteUseCase(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        public async Task<List<Modelos.Entidades.Paciente>> RecuperarPacientesAtivos()
        {
            try
            {
                return await _pacienteService.ListarPacientesAtivos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Modelos.Entidades.Paciente> RecuperarPorId(Guid id)
        {
            try
            {
                return await _pacienteService.ListaPacientePorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
