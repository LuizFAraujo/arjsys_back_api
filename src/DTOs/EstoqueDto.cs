using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateEstoqueDto
{
    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantidade { get; set; }

    [Required]
    public DateTime DataRecebimento { get; set; }
}

public class UpdateEstoqueDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantidade { get; set; }

    [Required]
    public DateTime DataRecebimento { get; set; }
}
