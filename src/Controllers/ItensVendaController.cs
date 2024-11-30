using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItensVendaController(IItemVendaService itemVendaService) : ControllerBase
    {
        private readonly IItemVendaService _itemVendaService = itemVendaService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemVenda>>> Get()
        {
            return Ok(await _itemVendaService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemVenda>> Get(int id)
        {
            var itemVenda = await _itemVendaService.GetByIdAsync(id);
            if (itemVenda == null)
            {
                return NotFound();
            }
            return Ok(itemVenda);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ItemVenda itemVenda)
        {
            await _itemVendaService.AddAsync(itemVenda);
            return CreatedAtAction(nameof(Get), new { id = itemVenda.Id }, itemVenda);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, ItemVenda itemVenda)
        {
            if (id != itemVenda.Id)
            {
                return BadRequest();
            }
            await _itemVendaService.UpdateAsync(itemVenda);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _itemVendaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
