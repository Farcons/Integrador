using Integrador.Domain.Itens;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Infrastructure
{
    public class IntegradorDbContext(DbContextOptions<IntegradorDbContext> options) : DbContext(options)
    {
        public DbSet<Item> LogsIntegracao => Set<Item>();
    }
}
