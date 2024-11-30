using ArjSys.Data.DataSeed.Estoque;
using ArjSys.Data.DataSeed.ItemVenda;
using ArjSys.Data.DataSeed.Producao;
using ArjSys.Data.DataSeed.Produto;
using ArjSys.Data.DataSeed.Projeto;
using ArjSys.Data.DataSeed.Vendas;

namespace ArjSys.Data.DataSeed;

public static class DataSeed
{
    public static void SeedAll(ApplicationDbContext context)
    {
        ProdutoSeed.Seed(context);       // Produtos são a base para muitas outras entidades.
        EstoqueSeed.Seed(context);       // Estoques dependem de Produtos.
        ProducaoSeed.Seed(context);      // Produções dependem de Produtos.
        VendaSeed.Seed(context);         // Vendas podem depender de Produtos.
        ItemVendaSeed.Seed(context);     // Itens de Venda dependem de Produtos e Vendas.
        ProjetoSeed.Seed(context);       // Projetos geralmente são independentes.
    }
}
