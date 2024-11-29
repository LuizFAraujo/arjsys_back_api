using Microsoft.EntityFrameworkCore;
using ArjSys.Models;

namespace ArjSys.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{

    #region Domain Models

    // DbSet para cada entidade, correspondendo às tabelas no banco de dados
    public required DbSet<Estoque> Estoques { get; set; }
    public required DbSet<Producao> Producoes { get; set; }
    public required DbSet<Produto> Produtos { get; set; }
    public required DbSet<Projeto> Projetos { get; set; }
    public required DbSet<Venda> Vendas { get; set; }
    public required DbSet<ItemVenda> ItensVenda { get; set; }

    #endregion
}
