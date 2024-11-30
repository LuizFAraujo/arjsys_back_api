using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VendasController(IVendaService vendaService) : ControllerBase
{
    private readonly IVendaService _vendaService = vendaService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Venda>>> Get()
    {
        return Ok(await _vendaService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Venda>> Get(int id)
    {
        var venda = await _vendaService.GetByIdAsync(id);
        if (venda == null)
        {
            return NotFound();
        }
        return Ok(venda);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateVendaDto createVendaDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var venda = new Venda
        {
            DataVenda = createVendaDto.DataVenda,
            ItensVenda = createVendaDto.ItensVenda.Select(iv => new ItemVenda
            {
                ProdutoId = iv.ProdutoId,
                Quantidade = iv.Quantidade,
                Valor = iv.Valor,
                Produto = new Produto { Id = iv.ProdutoId },
                Venda = new Venda()
            }).ToList()
        };

        await _vendaService.AddAsync(venda);
        return CreatedAtAction(nameof(Get), new { id = venda.Id }, venda);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateVendaDto updateVendaDto)
    {
        if (id != updateVendaDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var venda = new Venda
        {
            Id = updateVendaDto.Id,
            DataVenda = updateVendaDto.DataVenda,
            ItensVenda = updateVendaDto.ItensVenda.Select(iv => new ItemVenda
            {
                Id = iv.Id,
                ProdutoId = iv.ProdutoId,
                Quantidade = iv.Quantidade,
                Valor = iv.Valor,
                Produto = new Produto { Id = iv.ProdutoId },
                Venda = new Venda()
            }).ToList()
        };

        await _vendaService.UpdateAsync(venda);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _vendaService.DeleteAsync(id);
        return NoContent();
    }
}
