namespace SimpleApi.Shared.Data;

public interface IRepository<TEntity> : IDisposable
    where TEntity :  class
{
    Task<bool> Commit();
    Task<TEntity?> GetById(Guid id);
    IQueryable<TEntity> GetAll();
    Task AddAsync(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity, bool destroy = false);
}