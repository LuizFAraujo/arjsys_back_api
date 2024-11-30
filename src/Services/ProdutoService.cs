using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class ProdutoService(IProdutoRepository produtoRepository) : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository = produtoRepository;

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _produtoRepository.GetAllAsync();
    }

    public async Task<Produto> GetByIdAsync(int id)
    {
        return await _produtoRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(Produto entity)
    {
        await _produtoRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Produto entity)
    {
        await _produtoRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _produtoRepository.DeleteAsync(id);
    }
}
