﻿using System.ComponentModel.DataAnnotations;

namespace ArjSys.DTOs;

public class CreateVendaDto
{
    [Required]
    public DateTime DataVenda { get; set; }

    [Required]
    public required List<CreateItemVendaDto> ItensVenda { get; set; }
}

public class UpdateVendaDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public DateTime DataVenda { get; set; }

    [Required]
    public required List<UpdateItemVendaDto> ItensVenda { get; set; }
}
