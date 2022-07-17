using SimpleApi.Domain.Abstractions;

namespace SimpleApi.Domain.Entitys;

public class Book : Entity
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNumbers { get; set; }
    public DateTime? ReleaseDate { get; set; }
}