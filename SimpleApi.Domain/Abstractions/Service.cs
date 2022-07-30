using SimpleApi.Shared.Data;
using SimpleApi.Shared.Domain;

namespace SimpleApi.Domain.Abstractions;

public abstract class Service<TEntity, TRepository> : IService<TEntity>
    where TEntity : Entity
    where TRepository : IRepository<TEntity>
{
    protected TRepository _repository;

    protected Service(TRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<TEntity?> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public IQueryable<TEntity> GetAll()
    {
        return _repository.GetAll();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _repository.AddAsync(entity);
    }

    public async Task Update(TEntity entity)
    {
        await _repository.Update(entity);
    }

    public async Task Delete(TEntity entity, bool destroy = false)
    {
        await _repository.Delete(entity, destroy);
    }
}