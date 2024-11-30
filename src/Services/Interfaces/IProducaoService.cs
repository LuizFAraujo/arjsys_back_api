using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IProducaoService
{
    Task<IEnumerable<Producao>> GetAllAsync();
    Task<Producao> GetByIdAsync(int id);
    Task AddAsync(Producao entity);
    Task UpdateAsync(Producao entity);
    Task DeleteAsync(int id);
}
