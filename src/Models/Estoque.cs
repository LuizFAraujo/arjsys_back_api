using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Estoque : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }
}
