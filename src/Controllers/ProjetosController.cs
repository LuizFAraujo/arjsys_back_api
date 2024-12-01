using ArjSys.DTOs;
using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjetosController(IProjetoService projetoService) : ControllerBase
{
    private readonly IProjetoService _projetoService = projetoService;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Projeto>>> Get()
    {
        return Ok(await _projetoService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Projeto>> Get(int id)
    {
        var projeto = await _projetoService.GetByIdAsync(id);
        if (projeto == null)
        {
            return NotFound();
        }
        return Ok(projeto);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateProjetoDto createProjetoDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var projeto = new Projeto
        {
            Nome = createProjetoDto.Nome,
            DataInicio = createProjetoDto.DataInicio,
            DataFim = createProjetoDto.DataFim
        };

        await _projetoService.AddAsync(projeto);
        return CreatedAtAction(nameof(Get), new { id = projeto.Id }, projeto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateProjetoDto updateProjetoDto)
    {
        if (id != updateProjetoDto.Id || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var projeto = new Projeto
        {
            Id = updateProjetoDto.Id,
            Nome = updateProjetoDto.Nome,
            DataInicio = updateProjetoDto.DataInicio,
            DataFim = updateProjetoDto.DataFim
        };

        await _projetoService.UpdateAsync(projeto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _projetoService.DeleteAsync(id);
        return NoContent();
    }
}
