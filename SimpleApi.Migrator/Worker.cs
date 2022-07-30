using Microsoft.EntityFrameworkCore;
using SimpleApi.Infra.Data.Interfaces;

namespace SimpleApi.Migrator;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IServiceProvider _serviceProvider;

    public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await MigrateDataBase();
    }

    private async Task MigrateDataBase()
    {
        using var dbContext = _serviceProvider.GetRequiredService<ISimpleApiDbContext>();

        await dbContext.Database.MigrateAsync();

    }
}