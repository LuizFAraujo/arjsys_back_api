using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class ProducaoRepository(ApplicationDbContext context) : IProducaoRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Producao>> GetAllAsync()
    {
        return await _context.Producoes.ToListAsync();
    }

    public async Task<Producao> GetByIdAsync(int id)
    {
        var entity = await _context.Producoes.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("Producao não encontrada");
    }

    public async Task AddAsync(Producao entity)
    {
        await _context.Producoes.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Producao entity)
    {
        _context.Producoes.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Producoes.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
