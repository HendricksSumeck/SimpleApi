using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleApi.Domain.Entitys;
using SimpleApi.Infra.Data.Abstractions;
using SimpleApi.Infra.Data.Utils;

namespace SimpleApi.Infra.Data.Mappings;

public class BookMap : BaseEntityMap<Book>
{
    protected override void ConfigureMap(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable(nameof(Book));

        builder.Property(e => e.Name)
            .HasColumnType(DataType.String);

        builder.Property(e => e.Author)
            .HasColumnType(DataType.String);

        builder.Property(e => e.PageNumbers)
            .HasColumnType(DataType.Integer);

        builder.Property(e => e.ReleaseDate)
            .HasColumnType(DataType.DateTime);
    }
}