using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class Projeto : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
}

