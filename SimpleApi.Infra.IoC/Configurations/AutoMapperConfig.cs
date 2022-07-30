using Microsoft.Extensions.DependencyInjection;

namespace SimpleApi.Infra.IoC.Configurations;

public static class AutoMapperConfig
{
    public static void AddAutoMapperConfig(this IServiceCollection services)
    {
        var coreAssembly = AppDomain.CurrentDomain.Load("SimpleApi.Application");
        
        services.AddAutoMapper(coreAssembly);
    }
}