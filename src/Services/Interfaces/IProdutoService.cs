using ArjSys.Models;

namespace ArjSys.Services.Interfaces;

public interface IProdutoService
{
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<Produto> GetByIdAsync(int id);
    Task AddAsync(Produto entity);
    Task UpdateAsync(Produto entity);
    Task DeleteAsync(int id);
}
