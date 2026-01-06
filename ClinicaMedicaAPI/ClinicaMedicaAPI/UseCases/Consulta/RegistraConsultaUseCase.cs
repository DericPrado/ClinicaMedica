using ClinicaMedicaAPI.Modelos.DTOs.Agenda;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;

namespace ClinicaMedicaAPI.UseCases.Consulta
{
    public class RegistraConsultaUseCase : IRegistraConsultaUseCase
    {
        private IConsultaService _consultaService;
        private IPacienteService _pacienteService;
        private IMedicoService _medicoService;

        public RegistraConsultaUseCase(IConsultaService consultaService, IPacienteService pacienteService, IMedicoService medicoService)
        {
            _consultaService = consultaService;
            _pacienteService = pacienteService;
            _medicoService = medicoService;
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

            var pacientes = await _pacienteService.ListarPacientesAtivos();
            var medicos = await _medicoService.ListarMedicosAtivos();

            if (pacientes.Select(p => p.Ativo.Equals(true) && p.Id.Equals(request.IdPaciente)).Count() == 0
                || medicos.Select(m => m.Ativo.Equals(true) && m.Id.Equals(request.IdMedico)).Count() == 0)
            {
                return false;
            }

                consultaMedico = await _consultaService.RecuperarConsultasPorIdMedico(request.IdMedico);
            consultaPaciente = await _consultaService.RecuperarConsultasPorIdPaciente(request.IdPaciente);

            if(consultaMedico.Count == 0 && consultaPaciente.Count == 0)
            {
                return true;
            }

            if(consultaMedico.Where(c => c.Data.Equals(request.Data) && c.Ativa.Equals(true)).Count() > 0)
            {
                return false;
            }
            else if(consultaPaciente.Where(c => c.Data.Equals(request.Data) && c.Ativa.Equals(true)).Count() > 0)
            {
                return false;
            }

            return true;
        }
    }
}
