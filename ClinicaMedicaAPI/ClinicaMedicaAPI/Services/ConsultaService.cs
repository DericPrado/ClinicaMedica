using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;
using ClinicaMedicaAPI.Modelos.Interfaces.Services;

namespace ClinicaMedicaAPI.Services
{
    public class ConsultaService : IConsultaService
    {
        private  IRepositorioConsulta _DbContext;

        public ConsultaService(IRepositorioConsulta dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<bool> Atualizar(Consulta consulta)
        {
            try
            {
                return await _DbContext.Atualizar(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Deletar(Guid id)
        {
            try
            {
                return await _DbContext.Deletar(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Consulta> RecuperarConsultaPorId(Guid id)
        {
            try
            {
                return await _DbContext.RecuperarConsultaPorId(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Consulta>> RecuperarConsultasAtivas()
        {
            try
            {
                return await _DbContext.RecuperarConsultasAtivas();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Consulta>> RecuperarConsultasPorIdMedico(Guid id)
        {
            try
            {
                return await _DbContext.RecuperarConsultasPorIdMedico(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Consulta>> RecuperarConsultasPorIdPaciente(Guid id)
        {
            try
            {
                return await _DbContext.RecuperarConsultasPorIdPaciente(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Registrar(Consulta consulta)
        {
            try
            {
                return await _DbContext.Registrar(consulta);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
