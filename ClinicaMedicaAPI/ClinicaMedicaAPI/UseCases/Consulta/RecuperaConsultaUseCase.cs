using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;

namespace ClinicaMedicaAPI.UseCases.Consulta
{
    public class RecuperaConsultaUseCase : IRecuperaConsultaUseCase
    {
        private IConsultaService _consultaservice;

        public RecuperaConsultaUseCase(IConsultaService consultaservice)
        {
            _consultaservice = consultaservice;
        }

        public async Task<Modelos.Entidades.Consulta> RecuperarConsultaPorId(Guid id)
        {
            try
            {
                return await _consultaservice.RecuperarConsultaPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Modelos.Entidades.Consulta>> RecuperarConsultasPorIdMedico(Guid id)
        {
            try
            {
                return await _consultaservice.RecuperarConsultasPorIdMedico(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Modelos.Entidades.Consulta>> RecuperarConsultasPorIdPaciente(Guid id)
        {
            try
            {
                return await _consultaservice.RecuperarConsultasPorIdPaciente(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
