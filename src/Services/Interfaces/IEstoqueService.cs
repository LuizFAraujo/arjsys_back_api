using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IEstoqueService
{
    Task<IEnumerable<Estoque>> GetAllAsync();
    Task<Estoque> GetByIdAsync(int id);
    Task AddAsync(Estoque entity);
    Task UpdateAsync(Estoque entity);
    Task DeleteAsync(int id);
}
