using SimpleApi.Domain.Entitys;
using SimpleApi.Domain.Interfaces;
using SimpleApi.Infra.Data.Abstractions;
using SimpleApi.Infra.Data.Interfaces;

namespace SimpleApi.Infra.Data.Repositories;

public class BookRepository : Repository<Book>, IBookRepository
{
    public BookRepository(Lazy<ISimpleApiDbContext> context) : base(context)
    {
    }
}