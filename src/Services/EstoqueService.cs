using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class EstoqueService(IEstoqueRepository estoqueRepository) : IEstoqueService
{
    private readonly IEstoqueRepository _estoqueRepository = estoqueRepository;

    public async Task<IEnumerable<Estoque>> GetAllAsync()
    {
        return await _estoqueRepository.GetAllAsync();
    }

    public async Task<Estoque> GetByIdAsync(int id)
    {
        return await _estoqueRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(Estoque entity)
    {
        await _estoqueRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Estoque entity)
    {
        await _estoqueRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _estoqueRepository.DeleteAsync(id);
    }
}
