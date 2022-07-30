namespace SimpleApi.Shared.Application;

public interface IService<TEntity>
    where TEntity : class
{
    Task<TEntity?> GetById(Guid id);
    IQueryable<TEntity> GetAll();
    Task AddAsync(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity, bool destroy = false);
}