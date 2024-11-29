using ArjSys.Models;

namespace ArjSys.Data.Repositories.Interfaces;

public interface IProjetoRepository
{
    Task<IEnumerable<Projeto>> GetAllAsync();
    Task<Projeto> GetByIdAsync(int id);
    Task AddAsync(Projeto entity);
    Task UpdateAsync(Projeto entity);
    Task DeleteAsync(int id);
}
