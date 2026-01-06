using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases.Medico
{
    public class AtualizaMedicoUseCase : IAtualizaMedicoUseCase
    {
        private IMedicoService _medicoService;

        public AtualizaMedicoUseCase (IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public async Task<bool> Executar(RequestAtualizaMedico request)
        {
            try
            {
                var medicoAtualizado = await _medicoService.ListaMedicoPorId(request.Id);
                if(!string.IsNullOrEmpty(request.CPF))
                {
                    medicoAtualizado.CPF = request.CPF;
                }
                if(!string.IsNullOrEmpty(request.Crm))
                {
                    medicoAtualizado.Crm = request.Crm;
                }
                if(!string.IsNullOrEmpty(request.Email))
                {
                    medicoAtualizado.Email = request.Email;
                }
                if(!string.IsNullOrEmpty(request.Nome))
                {
                    medicoAtualizado.Nome = request.Nome;
                }
                if(!string.IsNullOrEmpty(request.Especialidade))
                {
                    medicoAtualizado.Especialidade = request.Especialidade;
                }

                return await _medicoService.Atualizar(medicoAtualizado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
