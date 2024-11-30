using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ArjSys.Data.DataSeed.ItemVenda
{
    public static class ItemVendaSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            try
            {
                if (!context.ItensVenda.Any())
                {
                    var path = Path.Combine(AppContext.BaseDirectory, "Data", "DataSeed", "ItemVenda", "ItemVendaSeed.json");
                    var jsonString = File.ReadAllText(path);
                    var itensVenda = JsonSerializer.Deserialize<List<ArjSys.Models.ItemVenda>>(jsonString);

                    if (itensVenda != null)
                    {
                        context.ItensVenda.AddRange(itensVenda);
                        context.SaveChanges();
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
