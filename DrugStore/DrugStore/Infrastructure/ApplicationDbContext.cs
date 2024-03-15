using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DrugStore.Infrastructure;

public class ApplicationDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}