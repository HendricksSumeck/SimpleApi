using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Infra.Data.Contexts;

namespace SimpleApi.Infra.Data.Configurations;

public static class InfraDataConfiguration
{
    public static void AddInfraDataConfiguration(this IServiceCollection services)
    {
        services.AddDbContext<SimpleApiDbContext>();
    }
}