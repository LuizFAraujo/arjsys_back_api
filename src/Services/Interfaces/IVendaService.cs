using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IVendaService
{
    Task<IEnumerable<Venda>> GetAllAsync();
    Task<Venda> GetByIdAsync(int id);
    Task AddAsync(Venda entity);
    Task UpdateAsync(Venda entity);
    Task DeleteAsync(int id);
}
