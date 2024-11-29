using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Produto : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}
