using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Transportes.Models.DTO;
using Transportes.Servicos;

namespace Transportes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaminhoesController : ControllerBase
    {
        private readonly CaminhoesServico servico;

        public CaminhoesController(CaminhoesServico servico)
        {
            this.servico = servico;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Caminhoes))]
        public IActionResult Get([FromRoute] int id)
            => Ok(servico.Get(id));

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(int))]
        [ProducesErrorResponseType(typeof(BadHttpRequestException))]
        public IActionResult Post([FromBody] Caminhoes veiculo)
        {
            try
            {
                servico.Post(veiculo);
            }
            catch (BadHttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(veiculo.id);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(200, Type = typeof(Caminhoes))]
        public IActionResult Patch([FromRoute] int id, [FromBody] JsonPatchDocument<Caminhoes> patch)
        {
            var veiculo = servico.Get(id);

            patch.ApplyTo(veiculo);

            return Ok(servico.Alterar(veiculo));
        }

        [HttpPut]
        [ProducesResponseType(204, Type = typeof(NoContentResult))]
        public IActionResult Put([FromBody] Caminhoes veiculo)
        {
            servico.Alterar(veiculo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204, Type = typeof(NoContentResult))]
        public IActionResult Delete([FromRoute] int id)
        {
            servico.Excluir(id);
            return NoContent();
        }
    }
}