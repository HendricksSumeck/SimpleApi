namespace SimpleApi.Shared.Data;

//TODO - Implmentar : IDisposable
public interface IRepository<TEntity> 
    where TEntity :  class
{
    Task<bool> Commit();
    Task<TEntity?> GetById(Guid id);
    IQueryable<TEntity> GetAll();
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity, bool destroy = false);
}