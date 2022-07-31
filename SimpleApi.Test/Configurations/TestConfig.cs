using System;
using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Infra.Data.Configurations;
using SimpleApi.Infra.IoC.Configurations;
using SimpleApi.Infra.IoC.Injectors;

namespace SimpleApi.Test.Configurations;

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