using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoquesController(IEstoqueService estoqueService) : ControllerBase
    {
        private readonly IEstoqueService _estoqueService = estoqueService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estoque>>> Get()
        {
            return Ok(await _estoqueService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estoque>> Get(int id)
        {
            var estoque = await _estoqueService.GetByIdAsync(id);
            if (estoque == null)
            {
                return NotFound();
            }
            return Ok(estoque);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Estoque estoque)
        {
            await _estoqueService.AddAsync(estoque);
            return CreatedAtAction(nameof(Get), new { id = estoque.Id }, estoque);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Estoque estoque)
        {
            if (id != estoque.Id)
            {
                return BadRequest();
            }
            await _estoqueService.UpdateAsync(estoque);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _estoqueService.DeleteAsync(id);
            return NoContent();
        }
    }
}
