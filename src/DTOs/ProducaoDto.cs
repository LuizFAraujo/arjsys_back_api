using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateProducaoDto
{
    [Required]
    public int ProdutoId { get; set; }

    [Required]
    public DateTime DataProducao { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantidade { get; set; }
}

public class UpdateProducaoDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int ProdutoId { get; set; }

    [Required]
    public DateTime DataProducao { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantidade { get; set; }
}
