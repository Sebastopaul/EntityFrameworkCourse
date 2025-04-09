using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TPAllWeek.Domain.Base;
using TPAllWeek.Infrastructure.Base;

namespace TPAllWeek.Application.Base;

public class BaseService<TRepository, TEntity> : IBaseService<TEntity>
    where TRepository : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{

    protected readonly TRepository Repository;
    
    public BaseService(TRepository repository)
    {
        Repository = repository;
    }

    public void SaveChangesAsync()
    {
        Repository.SaveChangesAsync();
    }

    public async Task<TEntity?> GetById(int id)
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
    
    public async ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity)
    {
        return await Repository.CreateAsync(entity);
    }
    
    public async ValueTask<TEntity?> UpdateAsync(int id, TEntity entity)
    {
        TEntity? eventToDelete = await GetById(id);

        if (eventToDelete == null) return null;

        PropertyInfo[] properties = entity.GetType().GetProperties();

        foreach (var property in properties)
        {
            eventToDelete.GetType().GetProperty(property.Name)?.SetValue(eventToDelete, property.GetValue(entity));
        }

        return eventToDelete;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        TEntity? eventToDelete = await GetById(id);

        if (eventToDelete == null) return false;

        return Repository.DeleteAsync(eventToDelete);;
    }
}
