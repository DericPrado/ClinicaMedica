using ClinicaMedicaAPI.Modelos.Entidades;
using ClinicaMedicaAPI.Modelos.Interfaces.Infra;

namespace ClinicaMedicaAPI.Infra
{
    public class RepositorioConsulta : IRepositorioConsulta
    {
        private static List<Consulta> _dbConsulta = new List<Consulta>();
        public async Task<bool> Atualizar(Consulta consulta)
        {
            try
            {
                var consultaAntiga = await RecuperarConsultaPorId(consulta.IdConsulta);
                consultaAntiga.Data = consulta.Data;
                consultaAntiga.IdPaciente = consulta.IdPaciente;
                consultaAntiga.IdMedico = consulta.IdMedico;

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Deletar(Guid id)
        {
            try
            {
                var consulta = await RecuperarConsultaPorId(id);
                consulta.Ativa = false;

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<Guid> GerarId()
        {
            Guid guid = Guid.NewGuid();

            return guid;
        }

        public async Task<Consulta> RecuperarConsultaPorId(Guid id)
        {
            try
            {
                var consulta = _dbConsulta.First(c => c.IdConsulta.Equals(id));

                return consulta;
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
                var consultas = _dbConsulta.Where(c => c.Ativa.Equals(true)).ToList();

                return consultas;
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
                var consultas = _dbConsulta.Where(c => c.IdMedico.Equals(id) && c.Ativa.Equals(true)).ToList();

                return consultas;
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
                var consultas = _dbConsulta.Where(c => c.IdPaciente.Equals(id) && c.Ativa.Equals(true)).ToList();

                return consultas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Registrar(Consulta consulta)
        {
            try
            {
                _dbConsulta.Add(consulta);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
