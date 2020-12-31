using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
        {
                new Movie(){Titulo = "The Wall", FechaLanzamiento = new DateTime(1979, 3, 2), Poster="https://images-na.ssl-images-amazon.com/images/I/51Nm4DLbu0L._AC_.jpg"},
                new Movie(){Titulo = "Matrix", FechaLanzamiento = new DateTime(1998, 8, 10), Poster="https://images-na.ssl-images-amazon.com/images/I/91BKjFYwvoL._AC_SY879_.jpg"},
                new Movie(){Titulo = "Querida encogí a los noños", FechaLanzamiento = new DateTime(1988, 12, 24), Poster= "https://m.media-amazon.com/images/I/61J2Om2s2QL._AC_SY741_.jpg"}
        };
        }
    }
}
