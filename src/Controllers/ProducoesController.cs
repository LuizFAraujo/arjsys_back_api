using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProducoesController(IProducaoService producaoService) : ControllerBase
{
    private readonly IProducaoService _producaoService = producaoService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producao>>> Get()
    {
        return Ok(await _producaoService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Producao>> Get(int id)
    {
        var producao = await _producaoService.GetByIdAsync(id);
        if (producao == null)
        {
            return NotFound();
        }
        return Ok(producao);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateProducaoDto createProducaoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var producao = new Producao
        {
            ProdutoNome = createProducaoDto.ProdutoNome,
            Quantidade = createProducaoDto.Quantidade,
            DataProducao = createProducaoDto.DataProducao,
            ProdutoId = createProducaoDto.ProdutoId,
            Produto = new Produto { Id = createProducaoDto.ProdutoId }
        };

        await _producaoService.AddAsync(producao);
        return CreatedAtAction(nameof(Get), new { id = producao.Id }, producao);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateProducaoDto updateProducaoDto)
    {
        if (id != updateProducaoDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var producao = new Producao
        {
            Id = updateProducaoDto.Id,
            ProdutoNome = updateProducaoDto.ProdutoNome,
            Quantidade = updateProducaoDto.Quantidade,
            DataProducao = updateProducaoDto.DataProducao,
            ProdutoId = updateProducaoDto.ProdutoId,
            Produto = new Produto { Id = updateProducaoDto.ProdutoId }
        };

        await _producaoService.UpdateAsync(producao);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _producaoService.DeleteAsync(id);
        return NoContent();
    }
}
