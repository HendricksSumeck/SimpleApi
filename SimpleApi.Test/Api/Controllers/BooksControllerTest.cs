using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SimpleApi.Api.Controllers;
using SimpleApi.Application.Interfaces;
using SimpleApi.Application.Services;
using SimpleApi.Domain.Entitys;
using SimpleApi.Test.Configurations;
using SimpleApi.Test.MockData;
using Xunit;

namespace SimpleApi.Test.Api.Controllers;

public class BooksControllerTest : IClassFixture<TestConfig>
{
    private readonly IBookService _bookService;
    
    public BooksControllerTest(TestConfig config)
    {
        _bookService = config.ServiceProvider.GetService<IBookService>();
    }
    
    [Fact(DisplayName = "Add")]
    [Trait("Book", "Add")]
    public async Task AddBook()
    {
        // Arrange
        var bookDto = BookMock.NewBookDto();
        var bookView = BookMock.NewBookViewModel();
        var controller = new BooksController(_bookService);

        var result = await controller.AddBook(bookDto);
        
        Assert.Equal(bookView.Name, result.Value.Name);
        Assert.Equal(bookView.Author, result.Value.Author);
        Assert.Equal(bookView.PageNumbers, result.Value.PageNumbers);
        Assert.Equal(bookView.ReleaseDate, result.Value.ReleaseDate);
    }
}