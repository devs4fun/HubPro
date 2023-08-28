using HubPro.Hub.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HubPro.Hub.Infrastructure
{
    public class ContextHub : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HubDB;Trusted_Connection=true;");
        }
    }
}
