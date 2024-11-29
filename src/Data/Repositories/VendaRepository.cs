using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class VendaRepository(ApplicationDbContext context) : IVendaRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Venda>> GetAllAsync()
    {
        return await _context.Vendas.ToListAsync();
    }

    public async Task<Venda> GetByIdAsync(int id)
    {
        var entity = await _context.Vendas.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("Venda não encontrada");
    }

    public async Task AddAsync(Venda entity)
    {
        await _context.Vendas.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Venda entity)
    {
        _context.Vendas.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Vendas.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
