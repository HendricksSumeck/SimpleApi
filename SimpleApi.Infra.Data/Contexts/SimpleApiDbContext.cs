using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;
using SimpleApi.Infra.Data.Interfaces;

namespace SimpleApi.Infra.Data.Contexts;

public class SimpleApiDbContext : DbContext, ISimpleApiDbContext
{
    public DbSet<Book> Books { get; set; }
    
    
    public async Task<bool> Commit(CancellationToken cancellationToken = default)
    {
        var success = await SaveChangesAsync(cancellationToken) > 0;

        if (!success) return false;

        return true; 
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5442;Database=SimpleApi;Username=postgres;Password=postgres");
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.AddConfigureModels();
    }
}