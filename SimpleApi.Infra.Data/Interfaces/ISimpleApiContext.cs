using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Infra.Data.Interfaces;

public interface ISimpleApiContext
{
    public DbSet<Book> Books { get; set; }
}