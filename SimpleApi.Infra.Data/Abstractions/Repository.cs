using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Abstractions;
using SimpleApi.Infra.Data.Interfaces;
using SimpleApi.Shared.Data;

namespace SimpleApi.Infra.Data.Abstractions;

public abstract class Repository<TEntity> : Repository<ISimpleApiDbContext, TEntity> where TEntity : Entity
{
    protected Repository(Lazy<ISimpleApiDbContext> context) : base(context)
    {
    }
}

public abstract class Repository<TContext, TEntity> : IRepository<TEntity>
    where TEntity : Entity
    where TContext : ISimpleApiDbContext
{
    protected readonly Lazy<TContext> DbWrite;
    protected TContext Db => DbWrite.Value;
    protected DbSet<TEntity> DbSet => Db.Set<TEntity>();
    
    protected Repository(Lazy<TContext> context)
    {
        DbWrite = context;
    }
}