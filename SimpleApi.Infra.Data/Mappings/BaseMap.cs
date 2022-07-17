using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpleApi.Infra.Data.Mappings;

public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T: class
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        ConfigureMap(builder);
    }

    protected abstract void ConfigureMap(EntityTypeBuilder<T> builder);
}
