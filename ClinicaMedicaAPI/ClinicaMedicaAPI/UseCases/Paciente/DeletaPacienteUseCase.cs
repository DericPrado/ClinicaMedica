using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;

namespace ClinicaMedicaAPI.UseCases.Paciente
{
    public class DeletaPacienteUseCase : IDeletaPacienteUseCase
    {
        private IPacienteService _pacienteService;

        public DeletaPacienteUseCase(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        public async Task<bool> Executar(Guid id)
        {
            try
            {
                return await _pacienteService.DeletarPacientePorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
