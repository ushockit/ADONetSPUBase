using Library.BLL.DTO;
using Library.BLL.DTO.Database;
using Library.BLL.Services.API;
using Library.BLL.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            GenresService genresService = new GenresService();
            ////GenreDTO genre = genresService.FindGenreById(1);
            //List<GenreDTO> genres = genresService.GetAllGenres();
            //;


            //WeatherAPIService weatherAPIService = new WeatherAPIService();
            //var weather = weatherAPIService.GetWeatherForCity("Dnepropetrovsk");

            genresService.CreateGenre(new GenreDTO { Name = "Some genre" });
            var genres = genresService.GetAllGenres();
            ;

            //genresService.CreateGenre(new GenreDTO { Name = "" });

            Console.Read();
        }
    }
}
