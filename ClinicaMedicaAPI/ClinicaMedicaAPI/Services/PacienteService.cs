using ClinicaMedicaAPI.Modelos.DTOs.Paciente;
using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;

namespace ClinicaMedicaAPI.Services
{
    public class PacienteService : IPacienteService
    {
        private IRepositorioPaciente _repostorioPaciente;

        public PacienteService(IRepositorioPaciente repostorioPaciente)
        {
            _repostorioPaciente = repostorioPaciente;
        }

        public async Task<bool> Atualizar(Paciente paciente)
        {
            try
            {
                return await _repostorioPaciente.Atualizar(paciente);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeletarPacientePorId(Guid id)
        {
            try
            {
                return await _repostorioPaciente.DeletarPacientePorId(id);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Paciente> ListaPacientePorId(Guid id)
        {
            try
            {
                return await _repostorioPaciente.ListaPacientePorId(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Paciente>> ListarPacientesAtivos()
        {
            try
            {
                return await _repostorioPaciente.ListarPacientesAtivos();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Registrar(Paciente paciente)
        {
            try
            {
                return await _repostorioPaciente.Registrar(paciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
