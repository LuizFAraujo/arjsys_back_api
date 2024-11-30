using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateProjetoDto
{
    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }
}

public class UpdateProjetoDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Nome { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }
}
