using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateProdutoDto
{
    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Preco { get; set; }
}

public class UpdateProdutoDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Preco { get; set; }
}
