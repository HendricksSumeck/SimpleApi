using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Infra.Data.Interfaces;

public interface ISimpleApiDbContext : IDisposable
{
    public DbSet<Book> Books { get; set; }
    
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}