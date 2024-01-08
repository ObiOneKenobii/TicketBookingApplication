using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing.Text;
using System.Linq;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                SeedMovies(dbContext);
                SeedGenres(dbContext);

            }

             static void SeedMovies(ApplicationDbContext dbContext)
            {
                if (!dbContext.Movies.Any())
                {
                    var movies = new[]
                    {
                    new Movies { Title = "Movie 26", MovieId = 1, ContentRating = "PG",  Description = " A New Film" },
                    new Movies { Title = "Movie 2", MovieId = 2, ContentRating = "PG",  Description = " A Short Film" },
                    // Add more movies as needed
                };

                    dbContext.Movies.AddRange(movies);
                    dbContext.SaveChanges();
                }
            }


            static void SeedGenres(ApplicationDbContext dbContext)
            {
                if (!dbContext.Genres.Any())
                {
                    var genres = new[]
                    {
                    new Genre { Name = "Horror", GenreId = 1},
                    new Genre { Name = "Thriller", GenreId = 2 },
                    // Add more genres as needed
                };

                    dbContext.Genres.AddRange(genres);
                    dbContext.SaveChanges();
                }
            }


        }
    }
}
