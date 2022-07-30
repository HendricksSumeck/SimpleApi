using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleApi.Application.Dtos;
using SimpleApi.Application.Interfaces;
using SimpleApi.Application.ViewModels;
using SimpleApi.Domain.Entitys;

namespace SimpleApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;
    
    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost]
    public async Task<ActionResult<BookViewModel>> AddBook([FromBody] BookDto bookDto)
    {
        return await _bookService.AddAsync(bookDto);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<bool> DeleteBook(Guid id)
    {
        var book = await _bookService.GetById(id);

        if (book is not null) await _bookService.Delete(book);

        return true;
    }
    
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<BookViewModel>> UpdateBook([FromBody] BookDto bookDto, Guid id)
    {
        return await _bookService.Update(bookDto.AtribuirId(id));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Book>> GetBookById(Guid id)
    {
        return await _bookService.GetById(id);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Book>>> GetBooks()
    {
        return await _bookService.GetAll().ToListAsync();
    }
}