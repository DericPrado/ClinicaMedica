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

        public async Task<bool> Atualizar(RequestAtualizaPaciente request)
        {
            try
            {
                var paciente = await _repostorioPaciente.ListaPacientePorId(request.Id);
                paciente.CPF = request.CPF;
                paciente.Nome = request.Nome;
                paciente.Telefone = request.Telefone;
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

        public async Task<bool> Registrar(RequestRegistraPaciente request)
        {
            try
            {
                var paciente = new Paciente
                {
                    Nome = request.Nome,
                    CPF = request.CPF,
                    Telefone = request.Telefone,
                    Ativo = true,
                    Id = await _repostorioPaciente.GerarId()

                };
                return await _repostorioPaciente.Registrar(paciente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
