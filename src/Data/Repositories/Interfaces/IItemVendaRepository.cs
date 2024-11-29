using ArjSys.Models;

namespace ArjSys.Data.Repositories.Interfaces;

public interface IItemVendaRepository
{
    Task<IEnumerable<ItemVenda>> GetAllAsync();
    Task<ItemVenda> GetByIdAsync(int id);
    Task AddAsync(ItemVenda entity);
    Task UpdateAsync(ItemVenda entity);
    Task DeleteAsync(int id);
}
