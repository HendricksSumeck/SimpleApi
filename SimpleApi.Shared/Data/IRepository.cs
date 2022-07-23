namespace SimpleApi.Shared.Data;

public interface IRepository<TEntity> : IDisposable
    where TEntity :  class
{
    Task<bool> Commit();
    Task<TEntity?> GetById(Guid id);
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity, bool destroy = false);
}