using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildPipeEditDockerProject.Models
{
    public class MoviesRepository:IRepository<Movie>
    {
        List<Movie> movies;
       /* private static readonly object forlock = new object();
        private static MoviesRepository repository = null;*/
        public MoviesRepository()
        {
            movies = new List<Movie>();
            movies.Add(new Movie
            {
                Id = 101,
                Name = "X-Men",
                Duration = 123.2f
            });
        }
       /*public static MoviesRepository GetInstance
        {
            get
            {
                lock(forlock)
                {
                    if(repository==null)
                    {
                        repository = new MoviesRepository();
                    }
                    return repository;
                }
            }
        }*/

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
