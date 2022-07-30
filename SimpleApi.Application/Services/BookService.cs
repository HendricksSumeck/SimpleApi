﻿using AutoMapper;
using SimpleApi.Application.Dtos;
using SimpleApi.Application.Interfaces;
using SimpleApi.Application.ViewModels;
using SimpleApi.Domain.Abstractions;
using SimpleApi.Domain.Entitys;
using SimpleApi.Domain.Interfaces;

namespace SimpleApi.Application.Services;

public class BookService : Service<Book, IBookRepository>, IBookService
{
    private readonly IMapper _mapper;
    public BookService(IBookRepository repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }

    public async Task<BookViewModel> AddAsync(BookDto bookDto)
    {
        var book = new Book()
        {
            Name= bookDto.Name,
            Author = bookDto.Author,
            PageNumbers = bookDto.PageNumbers,
            ReleaseDate = bookDto.ReleaseDate,
        };
        
        await _repository.AddAsync(book);

        return _mapper.Map<BookViewModel>(book);
    }

    public async Task<BookViewModel> Update(BookDto bookDto)
    {
        var book = await _repository.GetById(bookDto.BookId.Value);

        book.Name = bookDto.Name;
        book.Author = bookDto.Author;
        book.PageNumbers = bookDto.PageNumbers;
        book.ReleaseDate = bookDto.ReleaseDate;
        
        _repository.Update(book);

        return _mapper.Map<BookViewModel>(book);
    }
}