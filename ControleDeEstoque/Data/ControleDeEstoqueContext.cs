using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleDeEstoque.Models;

namespace ControleDeEstoque.Data
{
    public class ControleDeEstoqueContext : DbContext
    {
        public ControleDeEstoqueContext (DbContextOptions<ControleDeEstoqueContext> options)
            : base(options)
        {
        }

        public DbSet<ControleDeEstoque.Models.Produto> Produto { get; set; } = default!;
    }
}
