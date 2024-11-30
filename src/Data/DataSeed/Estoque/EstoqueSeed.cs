using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.Estoque
{
    public static class EstoqueSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.Estoques.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "Estoque", "EstoqueSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var estoques = JsonSerializer.Deserialize<List<ArjSys.Models.Estoque>>(jsonString);

                    if (estoques != null)
                    {
                        context.Estoques.AddRange(estoques);
                        context.SaveChanges();
                        Console.WriteLine("Estoques inseridos com sucesso.");
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Erro de JSON: {ex.Message}");
                Console.WriteLine($"Caminho do Erro: {ex.Path}");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Erro ao salvar dados: {ex.Message}");
                Console.WriteLine($"Detalhes da exceção: {ex.InnerException?.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
