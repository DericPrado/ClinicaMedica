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
                if(await ValidaAgenda(request))
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

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ValidaAgenda(RequestRegistraConsulta request)
        {
            var consultaMedico = new List<Modelos.Entidades.Consulta>();
            var consultaPaciente = new List<Modelos.Entidades.Consulta>();

            consultaMedico = await _consultaService.RecuperarConsultasPorIdMedico(request.IdMedico);
            consultaPaciente = await _consultaService.RecuperarConsultasPorIdPaciente(request.IdPaciente);

            if(consultaMedico.Count == 0 && consultaPaciente.Count == 0)
            {
                return true;
            }

            if(consultaMedico.First(c => c.Data.Equals(request.Data)).Ativa == true)
            {
                return false;
            }
            else if(consultaPaciente.First(c => c.Data.Equals(request.Data)).Ativa == true)
            {
                return false;
            }

            return true;
        }
    }
}
