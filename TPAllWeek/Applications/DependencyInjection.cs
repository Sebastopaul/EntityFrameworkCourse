using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TPAllWeek.Applications.Base;
using TPAllWeek.Applications.Services;

namespace TPAllWeek.Applications;

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
    }
}