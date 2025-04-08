using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Base;
using TPAllWeek.Infrastructure.Database;

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

    public async Task<TEntity> GetById(int id)
    {
        try
        {
            return await DbContext.Set<TEntity>().FindAsync(id)
                ?? throw new NullReferenceException($"Entity of type {typeof(TEntity)} not found with id {id}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Impossible de récupérer l'entité: {ex.Message}");
        }
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        try
        {
            return await DbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception($"Impossible de récupérer les entités: {ex.Message}");
        }
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
    {
        try
        {
            return await DbContext.Set<TEntity>().Where(where).AsNoTracking().ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception($"Impossible de récupérer les entités: {ex.Message}");
        }
    }
}
