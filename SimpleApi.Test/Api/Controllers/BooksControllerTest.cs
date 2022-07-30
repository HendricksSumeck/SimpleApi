using System.Threading.Tasks;
using SimpleApi.Api.Controllers;
using SimpleApi.Application.Interfaces;
using SimpleApi.Test.MockData;
using Xunit;
using Moq;

namespace SimpleApi.Test.Api.Controllers;

public class BooksControllerTest
{
    [Fact(DisplayName = "Add")]
    [Trait("Book", "Add")]
    public async Task AddBook()
    {
        /// Arrange
        var bookService = new Mock<IBookService>();
        var newBook = BookMock.NewBookDto();
        var controller = new BooksController(bookService.Object);
 
        /// Act
        var result = await controller.AddBook(newBook);
 
        /// Assert
        Assert.True(newBook.Equals(result.Value));
    }
}