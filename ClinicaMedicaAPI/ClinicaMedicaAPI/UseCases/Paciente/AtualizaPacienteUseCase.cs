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
                var pacienteAtualizado = await _pacienteService.ListaPacientePorId(request.Id);
                if(!string.IsNullOrEmpty(request.Telefone) && request.Telefone != pacienteAtualizado.Telefone)
                {
                    pacienteAtualizado.Telefone = request.Telefone;
                }
                if(!string.IsNullOrEmpty(request.Nome) && request.Nome != pacienteAtualizado.Nome)
                {
                    pacienteAtualizado.Nome = request.Nome;
                }
                if(!string.IsNullOrEmpty(request.CPF) && request.CPF != pacienteAtualizado.CPF)
                {
                    pacienteAtualizado.CPF = request.CPF;
                }

                return await _pacienteService.Atualizar(pacienteAtualizado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
