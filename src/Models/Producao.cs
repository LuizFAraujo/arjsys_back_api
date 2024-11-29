using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Producao : BaseEntity
{
    public string Produto { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public DateTime DataProducao { get; set; }
}
