using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateItemVendaDto
{
    [Required]
    public int VendaId { get; set; }

    [Required]
    public int ProdutoId { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantidade { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Valor { get; set; }
}

public class UpdateItemVendaDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int VendaId { get; set; }

    [Required]
    public int ProdutoId { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantidade { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Valor { get; set; }
}
