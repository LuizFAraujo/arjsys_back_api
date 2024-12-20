﻿using ArjSys.Models.Shared;

namespace ArjSys.Models;

public class ItemVenda : BaseEntity
{
    public int VendaId { get; set; }
    public Venda? Venda { get; set; }
    public int ProdutoId { get; set; }
    public Produto? Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
}
