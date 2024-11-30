using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.Projeto
{
    public static class ProjetoSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.Projetos.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "Projeto", "ProjetoSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var projetos = JsonSerializer.Deserialize<List<ArjSys.Models.Projeto>>(jsonString);

                    if (projetos != null)
                    {
                        context.Projetos.AddRange(projetos);
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
