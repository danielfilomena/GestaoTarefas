using GT.Application.Dtos;
using GT.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {

        public readonly ITarefaService _service;

        public TarefaController(ITarefaService service)
        {
                
            _service = service;

        }


        [HttpGet("buscarTarefa/{id}")]
        public async Task<IActionResult> BuscarTarefa([FromRoute] int id)
        {

            try
            {

                var result = await _service.BuscarTarefaPorId(id);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet("buscarTodasTarefas")]
        public async Task<IActionResult> BuscarTodasTarefas()
        {

            try
            {

                var result = await _service.BuscarTodasTarefas();
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        [HttpPost("incluirTarefa")]
        public async Task<IActionResult> IncluirTarefa([FromBody] TarefaDto tarefa)
        {

            try
            {

                var result = await _service.AdicionarTarefa(tarefa);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpPut("alterarTarefa")]
        public async Task<IActionResult> AlterarTarefa([FromBody] TarefaDto tarefa)
        {

            try
            {

                var result = await _service.AtualizarTarefa(tarefa);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("excluirTarefa/{id}")]
        public async Task<IActionResult> ExcluirTarefa([FromRoute] int id)
        {
            try
            {

                var result = await _service.ExcluirTarefa(id);
                return Ok(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
