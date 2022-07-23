using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("books")]
    public IResult GetBooks()
    {
        return Results.Ok();
    }
}