using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{

    // private readonly DataContext _uow;
    //
    // public BooksController(DataContext uow)
    // {
    //     _uow = uow;
    // }

    [HttpGet("books")]
    public IResult GetBooks()
    {
        //var book = _uow.Books.ToList();
        return Results.Ok();
    }
}