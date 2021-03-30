using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movievijay.Modoles
{
    public class MoviesRepository : IRepository<Movie>
    {
        public List<Movie> movies;

        // private static readonly object forLock = new object();

        // private static MoviesRepository repository = null;

        public MoviesRepository()
        {
            movies = new List<Movie>();
            movies.Add(new Movie
            {
                Id = 1,
                Name = "Bat-Men",
                Durations = 12.3f
            });
        }



        public void AddItem(Movie movie)
        {
            this.movies.Add(movie);
        }

        public IEnumerable<Movie> GetItems()
        {
            return this.movies;
        }
        public Movie GetItemById(int id)
        {
            return this.movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
