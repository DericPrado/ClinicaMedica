using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;

namespace ClinicaMedicaAPI.UseCases.Consulta
{
    public class DeletaConsultaUseCase : IDeletaConsultaUseCase
    {
        private IConsultaService _consultaService;

        public DeletaConsultaUseCase(IConsultaService consultaService)
        {
            _consultaService = consultaService;
        }
        public async Task<bool> Executar(Guid id)
        {
            try
            {
                return await _consultaService.Deletar(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
