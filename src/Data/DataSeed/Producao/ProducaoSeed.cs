using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.Producao
{
    public static class ProducaoSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.Producoes.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "Producao", "ProducaoSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var producoes = JsonSerializer.Deserialize<List<ArjSys.Models.Producao>>(jsonString);

                    if (producoes != null)
                    {
                        context.Producoes.AddRange(producoes);
                        context.SaveChanges();
                        //Console.WriteLine("************** PRODUÇÃO: OK");
                    }
                }
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
