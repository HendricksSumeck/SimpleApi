using SimpleApi.Application.Dtos;
using SimpleApi.Domain.Entitys;
using SimpleApi.Shared.Domain;

namespace SimpleApi.Application.Interfaces;

public interface IBookService : IService<Book>
{
    Task<Book> AddAsync(BookDto bookDto);
    Task<Book> Update(BookDto entity);
}