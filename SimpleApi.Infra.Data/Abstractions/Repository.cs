using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Abstractions;
using SimpleApi.Infra.Data.Extensions;
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
    
    public async Task<bool> Commit()
    {
        var success = await Db.SaveChangesAsync() > 0;

        if (!success) return false;

        return true; 
    }
    
    public virtual async Task<TEntity?> GetById(Guid id)
        => await DbSet
            .IgnoreDeleted()
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Id == id);

    public virtual async Task AddAsync(TEntity entity)
    {
        await Db
            .Set<TEntity>()
            .AddAsync(entity);
        
        await Commit();
    }

    public virtual async void Update(TEntity entity)
    {
        entity.Update();
        
        Db
            .Set<TEntity>()
            .Update(entity);
        
        await Commit();
    }

    public virtual async void Delete(TEntity entity, bool destroy = false)
    {
        if (destroy)
        {
            DbSet.Remove(entity);
            return;
        }

        entity.Delete();

        Db
            .Set<TEntity>()
            .Update(entity);

        await Commit();
    }

    public void Dispose()
        => Db?.Dispose();
}