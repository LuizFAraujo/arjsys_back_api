using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.Vendas
{
    public static class VendaSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.Vendas.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "Vendas", "VendaSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var vendas = JsonSerializer.Deserialize<List<ArjSys.Models.Venda>>(jsonString);

                    if (vendas != null)
                    {
                        context.Vendas.AddRange(vendas);
                        context.SaveChanges();
                        //Console.WriteLine("************** VENDAS: OK");
                        //Debug.WriteLine("********* DEBUG VENDAS MSG");
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
