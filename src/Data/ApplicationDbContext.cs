using Microsoft.EntityFrameworkCore;
using ArjSys.Models;

namespace ArjSys.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    #region Domain Models
    // DbSet para cada entidade, correspondendo às tabelas no banco de dados
    public DbSet<Estoque>? Estoques { get; set; }
    public DbSet<Producao>? Producoes { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Projeto>? Projetos { get; set; }
    public DbSet<Venda>? Vendas { get; set; }
    #endregion
}
