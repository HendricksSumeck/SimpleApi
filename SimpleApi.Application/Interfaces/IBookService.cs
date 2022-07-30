using SimpleApi.Application.Dtos;
using SimpleApi.Application.ViewModels;
using SimpleApi.Domain.Entitys;
using SimpleApi.Shared.Application;

namespace SimpleApi.Application.Interfaces;

public interface IBookService : IService<Book>
{
    Task<BookViewModel> AddAsync(BookDto bookDto);
    Task<BookViewModel> Update(BookDto entity);
}