namespace SimpleApi.Application.Dtos;

public class BookDto
{
    public Guid? BookId { get; private set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNumbers { get; set; }
    public DateTime? ReleaseDate { get; set; }

    public BookDto AtribuirId(Guid? bookId)
    {
        BookId = bookId;
        return this;
    }
}