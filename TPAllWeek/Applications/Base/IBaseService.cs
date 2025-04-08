using System.Linq.Expressions;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Applications.Base;

[Service]
public interface IBaseService<T> where T : BaseEntity
{
    Task<T> GetById(int id);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where);
}
