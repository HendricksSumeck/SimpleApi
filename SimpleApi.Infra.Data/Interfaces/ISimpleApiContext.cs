using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Infra.Data.Interfaces;

public interface ISimpleApiDbContext
{
    public DbSet<Book> Books { get; set; }
    
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
}