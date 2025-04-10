using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TPAllWeek.Application.Base;
using TPAllWeek.Application.Services;

namespace TPAllWeek.Application;

// Most probably supposed to be used when we have several projects

public static class DependencyInjection
{
    public static void AddServices(this IServiceCollection services)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        assembly.GetTypes().Where(t => t.IsDefined(typeof(ServiceAttribute)) 
                                       && !t.IsAbstract
                                       && !t.IsInterface)
            .Select(a => new { assignedType = a, serviceTypes = a.GetInterfaces().ToList() })
            .ToList()
            .ForEach(typesToRegister =>
            {
                typesToRegister.serviceTypes.ForEach(typeToRegister =>
                    services.AddScoped(typeToRegister, typesToRegister.assignedType));
            });

        services.AddAutoMapper(assembly);
    }
}