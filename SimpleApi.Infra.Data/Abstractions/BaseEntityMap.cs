using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApi.Domain.Abstractions;
using SimpleApi.Infra.Data.Utils;

namespace SimpleApi.Infra.Data.Abstractions;

public abstract class BaseEntityMap<T> : BaseMap<T> where T : Entity
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(m => m.RegisteredIn)
            .HasColumnType(DataType.DateTime)
            .IsRequired();

        builder.Property(m => m.UpdatedIn)
            .HasColumnType(DataType.DateTime)
            .IsRequired();

        builder.Property(m => m.DeletedIn)
            .HasColumnType(DataType.DateTime);

        builder.Property(m => m.Active)
            .HasColumnType(DataType.Boolean)
            .IsRequired();
    }
}