using ArjSys.Models;

namespace ArjSys.Data.Repositories.Interfaces;

public interface IVendaRepository
{
    Task<IEnumerable<Venda>> GetAllAsync();
    Task<Venda> GetByIdAsync(int id);
    Task AddAsync(Venda entity);
    Task UpdateAsync(Venda entity);
    Task DeleteAsync(int id);
}
