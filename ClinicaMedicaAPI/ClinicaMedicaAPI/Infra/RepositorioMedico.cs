using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;

namespace ClinicaMedicaAPI.Infra
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private static List<Medico> _MedicoDb = new List<Medico>();

        public async Task<bool> Atualizar(Medico request)
        {
            try
            {
                var medico = _MedicoDb.First(m => m.Id.Equals(request.Id));
                medico.CPF = request.CPF;
                medico.Crm = request.Crm;
                medico.Email = request.Email;
                medico.Nome = request.Nome;

                return true;

            }
            catch (Exception ex) 
            { 
                return false;
            }
        }

        public async Task<bool> DeletarMedicoPorId(Guid id)
        {
            try
            {
                var medico = _MedicoDb.First(m => m.Id.Equals(id));
                medico.Ativo = false;

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<Medico> ListaMedicoPorId(Guid id)
        {
            try
            {
                var medico = _MedicoDb.First(m => m.Id.Equals(id));

                return medico;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Medico>> ListarMedicosAtivos()
        {
            try
            {
                List<Medico> medicos = _MedicoDb.Where(m => m.Ativo.Equals(true)).ToList();

                return medicos;
            }
            catch(Exception ex)
            {
                return new List<Medico>();
            }
        }

        public async Task<bool> Registrar(Medico medico)
        {
            try
            {
                _MedicoDb.Add(medico);

                return true;
            }
            catch (Exception ex) 
            { 
                throw new Exception(ex.Message);
            }
        }
    }
}
