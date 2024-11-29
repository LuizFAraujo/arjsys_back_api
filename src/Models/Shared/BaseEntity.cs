namespace ArjSys.Models.Shared;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    public DateTime? DataAlteracao { get; set; }
}
