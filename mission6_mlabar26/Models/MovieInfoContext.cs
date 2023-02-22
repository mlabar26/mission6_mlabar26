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

        public DbSet<movieForm> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                    new Category { CategoryID = 2, CategoryName = "Comedy" },
                    new Category { CategoryID = 3, CategoryName = "Drama" },
                    new Category { CategoryID = 4, CategoryName = "Family" },
                    new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                    new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                    new Category { CategoryID = 7, CategoryName = "Television" },
                    new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<movieForm>().HasData(

                new movieForm
                {
                    movieID = 1,
                    CategoryID = 1,
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
                    CategoryID = 2,
                    title = "Hot Rod",
                    year = "2007",
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    edited = false,
                },

                new movieForm
                {
                    movieID = 3,
                    CategoryID = 1,
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
