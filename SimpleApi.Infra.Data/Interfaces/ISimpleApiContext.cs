using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Infra.Data.Interfaces;

public interface ISimpleApiDbContext : IDisposable
{
    DatabaseFacade Database { get; }
    public DbSet<Book> Books { get; set; }
    
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}