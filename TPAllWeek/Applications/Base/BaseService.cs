using System.Linq.Expressions;
using TPAllWeek.Domain.Base;
using TPAllWeek.Infrastructure.Base;

namespace TPAllWeek.Applications.Base;

public class BaseService<TRepository, TEntity> : IBaseService<TEntity>
    where TRepository : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{

    protected readonly TRepository Repository;

    public BaseService(TRepository repository)
    {
        Repository = repository;
    }
    public async Task<TEntity> GetById(int id)
    {
        return await Repository.GetById(id);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Repository.GetAllAsync();
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
    {
        return await Repository.GetAllAsync(where);
    }
}
