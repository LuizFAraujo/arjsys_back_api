using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Venda : BaseEntity
{
    public DateTime DataVenda { get; set; }
    public List<ItemVenda> ItensVenda { get; set; } = [];
}
