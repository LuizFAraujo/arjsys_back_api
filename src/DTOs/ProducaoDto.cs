using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateProducaoDto
{
    [Required]
    [StringLength(100)]
    public required string ProdutoNome { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantidade { get; set; }

    [Required]
    public DateTime DataProducao { get; set; }

    [Required]
    public int ProdutoId { get; set; }
}

public class UpdateProducaoDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string ProdutoNome { get; set; }

    [Range(0, int.MaxValue)]
    public int Quantidade { get; set; }

    [Required]
    public DateTime DataProducao { get; set; }

    [Required]
    public int ProdutoId { get; set; }
}
