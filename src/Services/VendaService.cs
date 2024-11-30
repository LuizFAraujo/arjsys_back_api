using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class VendaService(IVendaRepository vendaRepository) : IVendaService
{
    private readonly IVendaRepository _vendaRepository = vendaRepository;

    public async Task<IEnumerable<Venda>> GetAllAsync()
    {
        return await _vendaRepository.GetAllAsync();
    }

    public async Task<Venda> GetByIdAsync(int id)
    {
        return await _vendaRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(Venda entity)
    {
        await _vendaRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Venda entity)
    {
        await _vendaRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _vendaRepository.DeleteAsync(id);
    }
}
