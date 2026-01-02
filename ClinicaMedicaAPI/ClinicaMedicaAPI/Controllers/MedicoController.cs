using ClinicaMedicaAPI.Modelos.DTOs.Medico;
using ClinicaMedicaAPI.Modelos.Interfaces.UseCases.Medico;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedicaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> RecuperaMedicoPorId(Guid id, [FromServices] IRecuperaMedicoUseCase useCase)
        {
            var resultado = await useCase.PegarMedicoPorId(id);

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> RecuperaMedicos([FromServices] IRecuperaMedicoUseCase useCase)
        {
            var resultado = await useCase.ListarMedicos();

            if (resultado == null)
                return NotFound();

            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarMedico([FromServices] IRegistraMedicoUseCase useCase, [FromBody] RequestRegistraMedico request)
        {
            var resultado = await useCase.Executar(request);

            if (resultado)
                return Ok();
            return BadRequest(resultado);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarMedico([FromServices] IAtualizaMedicoUseCase useCase, [FromBody] RequestAtualizaMedico request)
        {
            var resultado = await useCase.Executar(request);

            if(resultado)
                return Ok();

            return BadRequest(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletaMedicoPorId(Guid id, [FromServices] IDeletaMedicoUseCase useCase)
        {
            var resultado = await useCase.Executar(id);
            if(resultado)
                return Ok();

            return BadRequest(resultado);
        }
    }
}
