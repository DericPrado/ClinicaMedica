using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;

namespace ClinicaMedicaAPI.Services
{
    public class MedicoService : IMedicoService
    {
        private IRepositorioMedico _DbContext;
        
        public MedicoService(IRepositorioMedico dbcontext)
        {
            _DbContext = dbcontext;
        }

        public async Task<bool> Atualizar(RequestAtualizaMedico request)
        {
            var medico = await _DbContext.ListaMedicoPorId(request.Id);
            return await _DbContext.Atualizar(medico);
        }

        public async Task<bool> DeletarMedicoPorId(Guid id)
        {
            return await _DbContext.DeletarMedicoPorId(id);
        }

        public async Task<Medico> ListaMedicoPorId(Guid id)
        {
            return await _DbContext.ListaMedicoPorId(id);
        }

        public async Task<List<Medico>> ListarMedicosAtivos()
        {
            return await _DbContext.ListarMedicosAtivos();
        }

        public async Task<bool> Registrar(RequestRegistraMedico request)
        {
            var medico = new Medico{ 
                Nome = request.Nome,
                Id = await _DbContext.GerarId(),
                Email = request.Email,
                Crm = request.Crm,
                CPF = request.CPF,
                Ativo = true,
            };

            return await _DbContext.Registrar(medico);
        }
    }
}
