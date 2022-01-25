using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRealASPNETApp.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    title = "The Dark Knight",
                    year = 2008,
                    director = "Christopher Nolan",
                    rating = "PG-13",
                    category = "Action",
                    edited = false,
                },
                new Movie
                {
                    MovieId = 2,
                    title = "Spiderman No Way Home",
                    year = 2021,
                    director = "Jon Watts",
                    rating = "PG-13",
                    category = "Action",
                    edited = false,
                },
                new Movie
                {
                    MovieId = 3,
                    title = "The Bourne Ultimatum",
                    year = 2007,
                    director = "Paul Greengrass",
                    rating = "PG-13",
                    category = "Action",
                    edited = false,
                }
            );
        }
    }
}
