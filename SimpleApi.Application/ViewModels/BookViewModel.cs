namespace SimpleApi.Application.ViewModels;

public class BookViewModel
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNumbers { get; set; }
    public DateTime? ReleaseDate { get; set; }
}