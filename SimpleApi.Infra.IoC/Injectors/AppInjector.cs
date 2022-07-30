using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Application.Interfaces;
using SimpleApi.Application.Services;
using SimpleApi.Domain.Interfaces;
using SimpleApi.Infra.Data.Repositories;

namespace SimpleApi.Infra.IoC.Injectors;

public static class AppInjector
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
    }
    
    public static void AddRepositorys(this IServiceCollection services)
    {
        services.AddTransient<IBookRepository, BookRepository>();
    }
}