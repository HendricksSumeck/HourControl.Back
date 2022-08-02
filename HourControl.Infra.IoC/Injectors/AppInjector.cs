using Microsoft.Extensions.DependencyInjection;
using HourControl.Application.Interfaces;
using HourControl.Application.Services;
using HourControl.Domain.Interfaces;
using HourControl.Infra.Data.Repositories;

namespace HourControl.Infra.IoC.Injectors;

public static class AppInjector
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IProjectService, ProjectService>();
        services.AddScoped<IActivityService, ActivityService>();
    }
    
    public static void AddRepositorys(this IServiceCollection services)
    {
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<IActivityRepository, ActivityRepository>();
    }
}