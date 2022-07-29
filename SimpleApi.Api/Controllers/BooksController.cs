using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;
using SimpleApi.Domain.Interfaces;

namespace SimpleApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookRepository _uow;
    
    public BooksController(IBookRepository uow)
    {
        _uow = uow;
    }

    [HttpPost]
    public async Task<Book> AddBook([FromBody] BookDto bookDto)
    {
        var book = new Book()
        {
            Name= bookDto.Name,
            Author = bookDto.Author,
            PageNumbers = bookDto.PageNumbers,
            ReleaseDate = bookDto.ReleaseDate,
        };
        
        await _uow.AddAsync(book);

        return book;
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<bool> DeleteBook(Guid id)
    {
        var book = await _uow.GetById(id);
        
        _uow.Delete(book);

        return true;
    }
    
    [HttpPut("{id:guid}")]
    public async Task<Book> UpdateBook([FromBody] BookDto bookDto, Guid id)
    {
        var book = await _uow.GetById(id);

        book.Name = bookDto.Name;
        book.Author = bookDto.Author;
        book.PageNumbers = bookDto.PageNumbers;
        book.ReleaseDate = bookDto.ReleaseDate;
        
        _uow.Update(book);
        
        return book;
    }
    
    [HttpGet("{id:guid}")]
    public async Task<Book?> GetBookById(Guid id)
    {
        return await _uow.GetById(id);
    }
    
    [HttpGet]
    public async Task<List<Book>> GetBooks()
    {
        return await _uow.GetAll().ToListAsync();
    }
}