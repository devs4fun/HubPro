using HubPro.Hub.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HubPro.Hub.Infrastructure
{
    public class ContextHub : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /************* 01 - forma de realizar a configuração de 1:1 ***************/
            //Com essa configuração eu devo ter a propriedade Id.
            modelBuilder
                .Entity<Cliente>()
                .HasOne(c => c.Endereco)
                .WithOne()
                .HasForeignKey("Endereco");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HubDB;Trusted_Connection=true;");
        }
    }
}
