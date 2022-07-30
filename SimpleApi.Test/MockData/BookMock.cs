using System;
using SimpleApi.Application.Dtos;

namespace SimpleApi.Test.MockData;

public class BookMock
{
    public static BookDto NewBookDto()
    {
        return new BookDto()
        {
            Name = "Dom Quixote",
            Author = "Miguel de Cervantes",
            PageNumbers = 126 ,
            ReleaseDate = Convert.ToDateTime("1605-10-25")
        };
    }
}