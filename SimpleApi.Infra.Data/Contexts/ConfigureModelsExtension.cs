using Microsoft.EntityFrameworkCore;
using SimpleApi.Infra.Data.Mappings;

namespace SimpleApi.Infra.Data.Contexts;

public static class ConfigureModelsExtension
{
    public static void AddConfigureModels(this ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BookMap());
    }
}