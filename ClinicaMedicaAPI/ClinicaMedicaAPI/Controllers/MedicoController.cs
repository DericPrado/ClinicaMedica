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

            if(resultado == null)
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
    }
}
