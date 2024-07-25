using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Transportes.Models.DTO;

namespace Transportes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculosController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
            => Ok();

        [HttpPost]
        public IActionResult Post([FromBody] Veiculos veiculo)
            => Ok();

        [HttpPatch("{id}")]
        public IActionResult Patch([FromBody] JsonPatchDocument<Veiculos> patch)
            => Ok();

        [HttpPut]
        public IActionResult Put([FromBody] Veiculos veiculo)
            => Ok();

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
            => Ok();
    }
}