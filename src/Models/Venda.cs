using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Venda : BaseEntity
{
    public DateTime DataVenda { get; set; }
    public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
}

public class ItemVenda : BaseEntity
{
    public int VendaId { get; set; }
    public required Venda Venda { get; set; }
    public int ProdutoId { get; set; }
    public required Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
}
