using ClinicaMedicaAPI.Modelos.DTOs.Agenda;
using ClinicaMedicaAPI.Modelos.DTOs.Consulta;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Consulta;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedicaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        [HttpGet("{idConsulta}")]
        public async Task<IActionResult> RecuperarConsultaPorId(Guid idConsulta, [FromServices] IRecuperaConsultaUseCase useCase)
        {
            var resultado = await useCase.RecuperarConsultaPorId(idConsulta);
            if(resultado.Equals(null))
            {
                return NotFound();
            }

            return Ok(resultado);
        }

        [HttpGet("{idMedico}")]
        public async Task<IActionResult> RecuperarConsultasPorIdMedico(Guid idMedico, [FromServices] IRecuperaConsultaUseCase useCase)
        {
            var resultado = await useCase.RecuperarConsultasPorIdMedico(idMedico);
            if (resultado.Equals(null))
            {
                return NotFound();
            }

            return Ok(resultado);
        }

        [HttpGet("{idPacinte}")]
        public async Task<IActionResult> RecuperarConsultasPorIdPaciente(Guid idPacinte, [FromServices] IRecuperaConsultaUseCase useCase)
        {
            var resultado = await useCase.RecuperarConsultasPorIdPaciente(idPacinte);
            if (resultado.Equals(null))
            {
                return NotFound();
            }

            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> RecuperarConsultasAtivas([FromServices] IRecuperaConsultaUseCase useCase)
        {
            var resultado = await useCase.RecuperarConsultasAtivas();

            return Ok(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] RequestAtualizaConsulta request, [FromServices] IAtualizaConsultaUseCase useCase)
        {
            var resultado = await useCase.Executar(request);
            if (!resultado)
                return BadRequest();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] RequestRegistraConsulta request, [FromServices] IRegistraConsultaUseCase useCase)
        {
            var resultado = await useCase.Executar(request);
            if (!resultado)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(Guid id, [FromServices] IDeletaConsultaUseCase useCase)
        {
            var resultado = await useCase.Executar(id);
            if(!resultado)
                return BadRequest();

            return Ok();
        }
    }
}
