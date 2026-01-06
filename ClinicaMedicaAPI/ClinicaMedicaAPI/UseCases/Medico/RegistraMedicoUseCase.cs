using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases.Medico
{
    public class RegistraMedicoUseCase : IRegistraMedicoUseCase
    {
        private IMedicoService _medicoService;

        public RegistraMedicoUseCase(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public async Task<bool> Executar(RequestRegistraMedico request)
        {
            try
            {
                if(string.IsNullOrEmpty(request.Especialidade) ||
                    string.IsNullOrEmpty(request.CPF) ||
                    string.IsNullOrEmpty(request.Crm) ||
                    string.IsNullOrEmpty(request.Nome) ||
                    string.IsNullOrEmpty(request.Email))
                {
                    return false;
                }
                var medico = new Modelos.Entidades.Medico
                {
                    Especialidade = request.Especialidade,
                    CPF = request.CPF,
                    Crm = request.Crm,
                    Nome = request.Nome,
                    Email = request.Email,
                    Ativo = true
                };

                return await _medicoService.Registrar(medico);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
