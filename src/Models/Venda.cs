using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Venda: BaseEntity
{
    public string Produto { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime DataVenda { get; set; }
}
