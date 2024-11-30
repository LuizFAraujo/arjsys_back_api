using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class ProjetoService(IProjetoRepository projetoRepository) : IProjetoService
{
    private readonly IProjetoRepository _projetoRepository = projetoRepository;

    public async Task<IEnumerable<Projeto>> GetAllAsync()
    {
        return await _projetoRepository.GetAllAsync();
    }

    public async Task<Projeto> GetByIdAsync(int id)
    {
        return await _projetoRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(Projeto entity)
    {
        await _projetoRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Projeto entity)
    {
        await _projetoRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _projetoRepository.DeleteAsync(id);
    }
}
