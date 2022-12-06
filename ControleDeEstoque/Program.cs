using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ControleDeEstoque.Data;
using ControleDeEstoque.Models;
namespace ControleDeEstoque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ControleDeEstoqueContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ControleDeEstoqueContext") ?? throw new InvalidOperationException("Connection string 'ControleDeEstoqueContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Produtoes}/{action=Create}/{id?}");

            app.Run();
        }
    }
}