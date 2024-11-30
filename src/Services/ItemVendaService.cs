using ArjSys.Data.Repositories.Interfaces;
using ArjSys.Models;
using ArjSys.Services.Interfaces;

namespace ArjSys.Services;

public class ItemVendaService(IItemVendaRepository itemVendaRepository) : IItemVendaService
{
    private readonly IItemVendaRepository _itemVendaRepository = itemVendaRepository;

    public async Task<IEnumerable<ItemVenda>> GetAllAsync()
    {
        return await _itemVendaRepository.GetAllAsync();
    }

    public async Task<ItemVenda> GetByIdAsync(int id)
    {
        return await _itemVendaRepository.GetByIdAsync(id);
    }

    public async Task AddAsync(ItemVenda entity)
    {
        await _itemVendaRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(ItemVenda entity)
    {
        await _itemVendaRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _itemVendaRepository.DeleteAsync(id);
    }
}
