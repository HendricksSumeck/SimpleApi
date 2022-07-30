using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Infra.Data.Contexts;
using SimpleApi.Infra.Data.Interfaces;

namespace SimpleApi.Infra.Data.Configurations;

public static class InfraDataConfig
{
    public static void AddInfraDataConfig(this IServiceCollection services)
    {
        services.AddDbContext<ISimpleApiDbContext, SimpleApiDbContext>(ServiceLifetime.Transient);
        services.AddTransient(factory => new Lazy<ISimpleApiDbContext>(factory.GetService<ISimpleApiDbContext>));
    }
}