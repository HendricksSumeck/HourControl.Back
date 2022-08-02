using System;
using HourControl.Infra.Data.Configurations;
using HourControl.Infra.IoC.Configurations;
using HourControl.Infra.IoC.Injectors;
using Microsoft.Extensions.DependencyInjection;

namespace HourControl.Test.Configurations;

public class TestConfig
{
    public TestConfig()
    {
        var serviceCollection = new ServiceCollection();
        
        //Add Auto Mapper Config
        serviceCollection.AddAutoMapperConfig();
        
        // Add Infra Data Config
        serviceCollection.AddInfraDataConfig();
        
        // Add IoC Services
        serviceCollection.AddServices();
        serviceCollection.AddRepositorys();

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        ServiceProvider = serviceCollection.BuildServiceProvider();
    }

    public ServiceProvider ServiceProvider { get; set; }
}