using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

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
    public async Task<ActionResult> Post([FromBody] CreateEstoqueDto createEstoqueDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var estoque = new Estoque
        {
            Nome = createEstoqueDto.Nome,
            Quantidade = createEstoqueDto.Quantidade,
            ProdutoId = createEstoqueDto.ProdutoId,
            Produto = new Produto { Id = createEstoqueDto.ProdutoId } // Assumindo que Produto será recuperado no serviço
        };

        await _estoqueService.AddAsync(estoque);
        return CreatedAtAction(nameof(Get), new { id = estoque.Id }, estoque);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateEstoqueDto updateEstoqueDto)
    {
        if (id != updateEstoqueDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var estoque = new Estoque
        {
            Id = updateEstoqueDto.Id,
            Nome = updateEstoqueDto.Nome,
            Quantidade = updateEstoqueDto.Quantidade,
            ProdutoId = updateEstoqueDto.ProdutoId,
            Produto = new Produto { Id = updateEstoqueDto.ProdutoId } // Assumindo que Produto será recuperado no serviço
        };

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
