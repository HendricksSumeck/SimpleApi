using System;
using SimpleApi.Application.Dtos;
using SimpleApi.Application.ViewModels;

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
    
    public static BookViewModel NewBookViewModel()
    {
        return new BookViewModel()
        {
            Name = "Dom Quixote",
            Author = "Miguel de Cervantes",
            PageNumbers = 126 ,
            ReleaseDate = Convert.ToDateTime("1605-10-25")
        };
    }
}