using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class EstoqueRepository(ApplicationDbContext context) : IEstoqueRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Estoque>> GetAllAsync()
    {
        return await _context.Estoques.ToListAsync();
    }

    public async Task<Estoque> GetByIdAsync(int id)
    {
        var entity = await _context.Estoques.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("Estoque não encontrado");
    }

    public async Task AddAsync(Estoque entity)
    {
        await _context.Estoques.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Estoque entity)
    {
        _context.Estoques.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Estoques.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
