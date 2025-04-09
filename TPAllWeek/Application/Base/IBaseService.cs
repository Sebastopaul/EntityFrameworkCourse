using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Application.Base;

[Service]
public interface IBaseService<T> where T : BaseEntity
{
    void SaveChangesAsync();
    Task<T?> GetById(int id);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where);
    ValueTask<EntityEntry<T>> CreateAsync(T entity);
    ValueTask<T?> UpdateAsync(int id, T entity);
    Task<bool> DeleteAsync(int id);
}
