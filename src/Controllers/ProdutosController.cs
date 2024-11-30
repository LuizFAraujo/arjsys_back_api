using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController(IProdutoService produtoService) : ControllerBase
{
    private readonly IProdutoService _produtoService = produtoService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> Get()
    {
        return Ok(await _produtoService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> Get(int id)
    {
        var produto = await _produtoService.GetByIdAsync(id);
        if (produto == null)
        {
            return NotFound();
        }
        return Ok(produto);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateProdutoDto createProdutoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var produto = new Produto
        {
            Nome = createProdutoDto.Nome,
            Preco = createProdutoDto.Preco
        };

        await _produtoService.AddAsync(produto);
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateProdutoDto updateProdutoDto)
    {
        if (id != updateProdutoDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var produto = new Produto
        {
            Id = updateProdutoDto.Id,
            Nome = updateProdutoDto.Nome,
            Preco = updateProdutoDto.Preco
        };

        await _produtoService.UpdateAsync(produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _produtoService.DeleteAsync(id);
        return NoContent();
    }
}
