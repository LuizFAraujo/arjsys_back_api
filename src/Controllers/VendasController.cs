using ArjSys.Models;
using ArjSys.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArjSys.Controllers
{
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
        public async Task<ActionResult> Post(Venda venda)
        {
            await _vendaService.AddAsync(venda);
            return CreatedAtAction(nameof(Get), new { id = venda.Id }, venda);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult