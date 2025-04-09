using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class CategoryService : BaseService<CategoryRepository, Category>
{
    public CategoryService(CategoryRepository repository) : base(repository)
    { }
}