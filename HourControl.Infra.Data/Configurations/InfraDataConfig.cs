using HourControl.Infra.Data.Contexts;
using HourControl.Infra.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HourControl.Infra.Data.Configurations;

public static class InfraDataConfig
{
    public static void AddInfraDataConfig(this IServiceCollection services)
    {
        services.AddDbContext<ISimpleApiDbContext, SimpleApiDbContext>(ServiceLifetime.Transient);
        services.AddTransient(factory => new Lazy<ISimpleApiDbContext>(factory.GetService<ISimpleApiDbContext>));
    }
}