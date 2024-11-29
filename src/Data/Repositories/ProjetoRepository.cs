using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class ProjetoRepository(ApplicationDbContext context) : IProjetoRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Projeto>> GetAllAsync()
    {
        return await _context.Projetos.ToListAsync();
    }

    public async Task<Projeto> GetByIdAsync(int id)
    {
        var entity = await _context.Projetos.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("Projeto não encontrado");
    }

    public async Task AddAsync(Projeto entity)
    {
        await _context.Projetos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Projeto entity)
    {
        _context.Projetos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Projetos.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
