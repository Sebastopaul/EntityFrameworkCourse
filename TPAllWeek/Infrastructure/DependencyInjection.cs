using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Infrastructure;

public static class DependencyInjection
{
    public static void AddRepositories(this IServiceCollection services)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        assembly.GetTypes().Where(t => t.IsDefined(typeof(RepositoryAttribute)) 
                                       && !t.IsAbstract
                                       && !t.IsInterface)
            .Select(a => new { assignedType = a, serviceTypes = a.GetInterfaces().ToList() })
            .ToList()
            .ForEach(typesToRegister =>
            {
                typesToRegister.serviceTypes.ForEach(typeToRegister =>
                    services.AddScoped(typeToRegister, typesToRegister.assignedType));
            });
    }
}