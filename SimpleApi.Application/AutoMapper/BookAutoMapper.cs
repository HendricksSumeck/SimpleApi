using AutoMapper;
using SimpleApi.Application.Dtos;
using SimpleApi.Application.ViewModels;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Application.AutoMapper;

public class BookAutoMapper : Profile
{
    public BookAutoMapper()
    {
        CreateMap<Book, BookViewModel>();
        CreateMap<BookDto, Book>();
    }
}