using ArjSys.Models;

namespace ArjSys.Data.Repositories.Interfaces;

public interface IProducaoRepository
{
    Task<IEnumerable<Producao>> GetAllAsync();
    Task<Producao> GetByIdAsync(int id);
    Task AddAsync(Producao entity);
    Task UpdateAsync(Producao entity);
    Task DeleteAsync(int id);
}
