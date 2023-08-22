using Microsoft.EntityFrameworkCore;

namespace HubPro.Hub.Infrastructure
{
    public class ContextHub : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HubDB;Trusted_Connection=true;");
        }
    }
}
