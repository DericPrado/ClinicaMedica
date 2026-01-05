using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;

namespace ClinicaMedicaAPI.UseCases.Medico
{
    public class RecuperaMedicoUseCase : IRecuperaMedicoUseCase
    {
        private IMedicoService _services;

        public RecuperaMedicoUseCase(IMedicoService services)
        {
            _services = services;
        }

        public async Task<List<Modelos.Entidades.Medico>> ListarMedicos()
        {
            return await _services.ListarMedicosAtivos();
        }

        public async Task<Modelos.Entidades.Medico> PegarMedicoPorId(Guid id)
        {
            try
            {
                var medico = await _services.ListaMedicoPorId(id);
                if(medico.Ativo.Equals(false))
                {
                    return null;
                }

                return medico;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
