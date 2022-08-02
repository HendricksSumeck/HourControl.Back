using Microsoft.Extensions.DependencyInjection;

namespace HourControl.Infra.IoC.Configurations;

public static class AutoMapperConfig
{
    public static void AddAutoMapperConfig(this IServiceCollection services)
    {
        var coreAssembly = AppDomain.CurrentDomain.Load("HourControl.Application");
        
        services.AddAutoMapper(coreAssembly);
    }
}