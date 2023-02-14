//This class is the middleman for database and program

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_mlabar26.Models
{
    public class MovieInfoContext : DbContext
    {
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
        {
            
        }

        public DbSet<movieForm> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<movieForm>().HasData(

                new movieForm
                {
                    movieID = 1,
                    category = "Action/Adventure",
                    title = "The Dark Knight",
                    year = "2008",
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = false,
                    notes = "Great acting, great story!"
                },

                new movieForm
                {
                    movieID = 2,
                    category = "Comedy",
                    title = "Hot Rod",
                    year = "2007",
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = false,
                },

                new movieForm
                {
                    movieID = 3,
                    category = "Action/Adventure",
                    title = "Interstellar",
                    year = "2014",
                    director = "Akiva Schaffer",
                    rating = "PG-13",
                    edited = false,
                    notes = "Love the soundtrack!"
                }
            );
        }
    }
}
