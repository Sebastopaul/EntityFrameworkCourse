﻿using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Infrastructure.Base;

[Repository]
public interface IBaseRepository<T> where T : BaseEntity
{
    void SaveChangesAsync();
    Task<T?> GetById(int id);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where);
    ValueTask<EntityEntry<T>> CreateAsync(T entity);
    bool DeleteAsync(T entity);
}
