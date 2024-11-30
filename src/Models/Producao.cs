using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Producao : BaseEntity
{
    public string ProdutoNome { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public DateTime DataProducao { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }
}
