using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;

namespace ClinicaMedicaAPI.Infra
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private static List<Paciente> _PacienteDb = new List<Paciente>();

        public async Task<bool> Atualizar(Paciente request)
        {
            try
            {
                var paciente = await ListaPacientePorId(request.Id);
                paciente.Nome = request.Nome;
                paciente.Telefone = request.Telefone;
                paciente.CPF = request.CPF;

                return true;
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
                var paciente = await ListaPacientePorId(id);
                paciente.Ativo = false;

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Guid> GerarId()
        {
            Guid guid = Guid.NewGuid();

            return guid;
        }

        public async Task<Paciente> ListaPacientePorId(Guid id)
        {
            try
            {
                var paciente = _PacienteDb.First(p => p.Id.Equals(id));

                return paciente;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Paciente>> ListarPacientesAtivos()
        {
            return _PacienteDb.Where(p => p.Ativo.Equals(true)).ToList();
        }

        public async Task<bool> Registrar(Paciente medico)
        {
            try
            {
                _PacienteDb.Add(medico);

                return true; 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
