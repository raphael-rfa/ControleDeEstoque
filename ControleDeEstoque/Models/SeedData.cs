using ControleDeEstoque.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ControleDeEstoqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ControleDeEstoqueContext>>()))
            {
                if(context.Produto.Any())
                {
                    return;
                }
                context.Produto.AddRange(
                new Produto { Nome = "garrafa", QntProduzida = 10, QntVendida = 4 },
                new Produto { Nome = "panela", QntProduzida = 10, QntVendida = 9 },
                new Produto { Nome = "colher", QntProduzida = 10, QntVendida = 8 },
                new Produto { Nome = "garfo", QntProduzida = 10, QntVendida = 7 },
                new Produto { Nome = "faca", QntProduzida = 10, QntVendida = 6 },
                new Produto { Nome = "tabua", QntProduzida = 10, QntVendida = 5 },
                new Produto { Nome = "xicara", QntProduzida = 10, QntVendida = 6 }
                
                );
                context.SaveChanges();
            }
        }
    }
}