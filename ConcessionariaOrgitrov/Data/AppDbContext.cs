using ConcessionariaOrgitrov.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcessionariaOrgitrov.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
