using ArjSys.Models;

namespace ArjSys.Data.Repositories.Interfaces;

public interface IEstoqueRepository
{
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task<Estoque> GetByIdAsync(int id);
    Task AddAsync(Estoque entity);
    Task UpdateAsync(Estoque entity);
    Task DeleteAsync(int id);
}
