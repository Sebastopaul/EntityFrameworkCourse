using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TPAllWeek.Domain.Base;
using TPAllWeek.Infrastructure.Database;
using TPAllWeek.Infrastructure.Exception;

namespace TPAllWeek.Infrastructure.Base;

public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> 
    where TEntity : BaseEntity
    where TContext : CoreDbContext
{
    protected readonly TContext DbContext;
    
    public BaseRepository(TContext context)
    {
        DbContext = context;
    }

    public void SaveChangesAsync()
    {
        try
        {
            DbContext.SaveChangesAsync();
        }
        catch (System.Exception e)
        {
            throw new SaveChangesException($"An error occured while saving changes: {e.Message}", e);
        }
    }
    
    public async Task<TEntity?> GetById(int id)
    {
        try
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }
        catch (System.Exception e)
        {
            throw new EntityNotFoundException($"Cannot find entity of type {nameof(TEntity)} with provided id {id}: {e.Message}", e);
        }
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        try
        {
            return await DbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }
        catch (System.Exception e)
        {
            throw new EntityNotFoundException($"Cannot find entities of type {nameof(TEntity)}: {e.Message}", e);
        }
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
    {
        try
        {
            return await DbContext.Set<TEntity>().Where(where).AsNoTracking().ToListAsync();
        }
        catch (System.Exception e)
        {
            throw new EntityNotFoundException($"Cannot find entities of type {nameof(TEntity)}: {e.Message}", e);
        }
    }
    
    public ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity)
    {
        try
        {
            return DbContext.Set<TEntity>().AddAsync(entity);
        }
        catch (System.Exception e)
        {
            throw new EntityCreationException($"Could not create entity of type {nameof(TEntity)}: {e.Message}", e);
        }
    }

    public bool DeleteAsync(TEntity entity)
    {
        try
        {
            DbContext.Set<TEntity>().Remove(entity);
            return true;
        }
        catch (System.Exception e)
        {
            throw new EntityDeletionException($"Could not create entity of type {nameof(TEntity)}: {e.Message}", e);
        }
    }
}
