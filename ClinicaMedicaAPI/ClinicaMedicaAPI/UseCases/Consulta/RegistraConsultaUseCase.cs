using ClinicaMedicaAPI.Modelos.DTOs.Agenda;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;

namespace ClinicaMedicaAPI.UseCases.Consulta
{
    public class RegistraConsultaUseCase : IRegistraConsultaUseCase
    {
        private IConsultaService _consultaService;

        public RegistraConsultaUseCase(IConsultaService consultaService)
        {
            _consultaService = consultaService;
        }

        public async Task<bool> Executar(RequestRegistraConsulta request)
        {
            try
            {
                var consulta = new Modelos.Entidades.Consulta
                {
                    IdMedico = request.IdMedico,
                    IdPaciente = request.IdPaciente,
                    Data = request.Data,
                    Ativa = true
                };

                return await _consultaService.Registrar(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
