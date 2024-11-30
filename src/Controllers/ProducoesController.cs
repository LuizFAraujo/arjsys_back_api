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
    public async Task<ActionResult> Post(Producao producao)
    {
        await _producaoService.AddAsync(producao);
        return CreatedAtAction(nameof(Get), new { id = producao.Id }, producao);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Producao producao)
    {
        if (id != producao.Id)
        {
            return BadRequest();
        }
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
