using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

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
    public async Task<ActionResult> Post([FromBody] CreateItemVendaDto createItemVendaDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var itemVenda = new ItemVenda
        {
            VendaId = createItemVendaDto.VendaId,
            ProdutoId = createItemVendaDto.ProdutoId,
            Quantidade = createItemVendaDto.Quantidade,
            Valor = createItemVendaDto.Valor,
            Venda = new Venda { Id = createItemVendaDto.VendaId },
            Produto = new Produto { Id = createItemVendaDto.ProdutoId }
        };

        await _itemVendaService.AddAsync(itemVenda);
        return CreatedAtAction(nameof(Get), new { id = itemVenda.Id }, itemVenda);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateItemVendaDto updateItemVendaDto)
    {
        if (id != updateItemVendaDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var itemVenda = new ItemVenda
        {
            Id = updateItemVendaDto.Id,
            VendaId = updateItemVendaDto.VendaId,
            ProdutoId = updateItemVendaDto.ProdutoId,
            Quantidade = updateItemVendaDto.Quantidade,
            Valor = updateItemVendaDto.Valor,
            Venda = new Venda { Id = updateItemVendaDto.VendaId },
            Produto = new Produto { Id = updateItemVendaDto.ProdutoId }
        };

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
