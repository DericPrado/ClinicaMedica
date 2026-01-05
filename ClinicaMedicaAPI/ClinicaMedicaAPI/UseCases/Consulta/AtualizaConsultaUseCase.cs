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
                var consulta = new Modelos.Entidades.Consulta
                {
                    IdMedico = request.IdMedico,
                    IdPaciente = request.IdPaciente,
                    Data = request.Data,
                    IdConsulta = request.IdConsulta,
                };

                return await _consultaService.Atualizar(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
