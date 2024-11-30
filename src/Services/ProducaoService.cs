using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class ProducaoService(IProducaoRepository producaoRepository) : IProducaoService
{
    private readonly IProducaoRepository _producaoRepository = producaoRepository;

    public async Task<IEnumerable<Producao>> GetAllAsync()
    {
        return await _producaoRepository.GetAllAsync();
    }

    public async Task<Producao> GetByIdAsync(int id)
    {
        return await _producaoRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(Producao entity)
    {
        await _producaoRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Producao entity)
    {
        await _producaoRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _producaoRepository.DeleteAsync(id);
    }
}
