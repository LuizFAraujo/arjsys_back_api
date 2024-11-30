using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IItemVendaService
{
    Task<IEnumerable<ItemVenda>> GetAllAsync();
    Task<ItemVenda> GetByIdAsync(int id);
    Task AddAsync(ItemVenda entity);
    Task UpdateAsync(ItemVenda entity);
    Task DeleteAsync(int id);
}
