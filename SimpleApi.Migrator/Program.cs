using SimpleApi.Infra.Data.Configurations;
using SimpleApi.Migrator;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>(); 
        services.AddInfraDataConfig();
    })
    .Build();



await host.RunAsync();