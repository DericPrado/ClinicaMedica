using ClinicaMedicaAPI.Modelos.DTOs.Consulta;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;

namespace ClinicaMedicaAPI.UseCases.Consulta
{
    public class AtualizaConsultaUseCase : IAtualizaConsultaUseCase
    {
        private IConsultaService _consultaService;

        public AtualizaConsultaUseCase(IConsultaService consultaService)
        {
            _consultaService = consultaService;
        }

        public async Task<bool> Executar(RequestAtualizaConsulta request)
        {
            try
            {
                var consultaAtualizada = await _consultaService.RecuperarConsultaPorId(request.IdConsulta);

                if(!string.IsNullOrEmpty(request.IdPaciente.ToString()) && request.IdPaciente != consultaAtualizada.IdPaciente)
                {
                    consultaAtualizada.IdPaciente = request.IdPaciente;
                }
                if(!string.IsNullOrEmpty(request.IdMedico.ToString()) && request.IdMedico != consultaAtualizada.IdMedico)
                {
                    consultaAtualizada.IdMedico = request.IdMedico;
                }
                if(!string.IsNullOrEmpty(request.Data.ToString()) && request.Data != consultaAtualizada.Data)
                {
                    consultaAtualizada.Data = request.Data;
                }

                return await _consultaService.Atualizar(consultaAtualizada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
