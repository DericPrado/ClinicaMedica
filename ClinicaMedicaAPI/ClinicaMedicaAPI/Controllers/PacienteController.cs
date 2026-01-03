using ClinicaMedicaAPI.Modelos.DTOs.Paciente;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Paciente;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedicaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> RecuperaPacientePorId(Guid id, [FromServices] IRecuperaPacienteUseCase useCase)
        {
            var resultado = await useCase.RecuperarPorId(id);
            if(resultado == null)
            {
                return NotFound();
            }

            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> ListaPacientesAtivos([FromServices] IRecuperaPacienteUseCase useCase)
        {
            var resultado = await useCase.RecuperarPacientesAtivos();
            if(resultado.Count() <= 0)
            {
                return NotFound();
            }

            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarPaciente([FromBody] RequestRegistraPaciente request, [FromServices] IRegistraPacienteUseCase useCase)
        {
            var resultado = await useCase.Executar(request);
            if (!resultado)
                return BadRequest();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaPaciente([FromBody] RequestAtualizaPaciente request, [FromServices] IAtualizaPacienteUseCase useCase)
        {
            var resultado = await useCase.Executar(request);
            if (!resultado)
                return BadRequest();

            return Ok();
        }
    }
}
