using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using Microsoft.EntityFrameworkCore;

namespace ArjSys.Data.Repositories;

public class ItemVendaRepository(ApplicationDbContext context) : IItemVendaRepository
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<ItemVenda>> GetAllAsync()
    {
        return await _context.ItensVenda.ToListAsync();
    }

    public async Task<ItemVenda> GetByIdAsync(int id)
    {
        var entity = await _context.ItensVenda.FindAsync(id);
        return entity ?? throw new KeyNotFoundException("ItemVenda não encontrado");
    }

    public async Task AddAsync(ItemVenda entity)
    {
        await _context.ItensVenda.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ItemVenda entity)
    {
        _context.ItensVenda.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        _context.ItensVenda.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
