using DbApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DbApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Cliente> Clientes => Set<Cliente>();

    }
}