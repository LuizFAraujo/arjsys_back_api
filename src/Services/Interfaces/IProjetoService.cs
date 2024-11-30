using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IProjetoService
{
    Task<IEnumerable<Projeto>> GetAllAsync();
    Task<Projeto> GetByIdAsync(int id);
    Task AddAsync(Projeto entity);
    Task UpdateAsync(Projeto entity);
    Task DeleteAsync(int id);
}
