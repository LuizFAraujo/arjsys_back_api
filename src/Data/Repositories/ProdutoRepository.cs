using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class ProdutoRepository(ApplicationDbContext context) : IProdutoRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> GetByIdAsync(int id)
    {
        var entity = await _context.Produtos.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("Produto não encontrado");
    }

    public async Task AddAsync(Produto entity)
    {
        await _context.Produtos.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Produto entity)
    {
        _context.Produtos.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.Produtos.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
