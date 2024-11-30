using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.Produto
{
    public static class ProdutoSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.Produtos.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "Produto", "ProdutoSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var produtos = JsonSerializer.Deserialize<List<ArjSys.Models.Produto>>(jsonString);

                    if (produtos != null)
                    {
                        context.Produtos.AddRange(produtos);
                        context.SaveChanges();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // Log the exception details
                Console.WriteLine($"Erro ao salvar dados: {ex.Message}");
                Console.WriteLine($"Detalhes da exceção: {ex.InnerException?.Message}");
            }
            catch (FileNotFoundException ex)
            {
                // Log file not found exception
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Log general exceptions
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
