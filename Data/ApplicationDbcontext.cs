using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TicketBookingApplication.Models;


namespace TicketBookingApplication.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }





        //YOU ONLY USE THIS WHEN YOU ARE USING A CONSOLE APPLICATION!
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=JIMI;Database=TicketBookingApplication;Trusted_Connection=True;TrustServerCertificate=True;");
        //}





        public DbSet<Cart> Carts { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CinemaLocation> CinemaLocation { get; set; }
        public DbSet<AvailableMovies> AvailableMovies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<SearchForMoviesByLocation> SearchforMovies { get; set; }

        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreMovies> GenreMovies { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Configure City entity
            builder.Entity<City>()
                .HasKey(c => c.CityId);

            builder.Entity<City>()
                .HasOne(c => c.State)
                .WithOne(s => s.City)
                .HasForeignKey<City>(c => c.StateId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction

            // Configure State entity
            builder.Entity<State>()
                .HasKey(s => s.StateId);

            builder.Entity<State>()
                .HasOne(s => s.City)
                .WithOne(c => c.State)
                .HasForeignKey<State>(s => s.StateId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction


            {
                // Configure Country entity
                builder.Entity<Country>()
                    .HasKey(c => c.CountryId);

                builder.Entity<Country>()
                    .HasOne(c => c.Location)
                    .WithOne(l => l.Country)
                    .HasForeignKey<Country>(c => c.LocationId)
                    .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction

                // Configure Location entity
                builder.Entity<Location>()
                    .HasKey(l => l.LocationId);

                builder.Entity<Location>()
                    .HasOne(l => l.Country)
                    .WithOne(c => c.Location)
                    .HasForeignKey<Location>(l => l.LocationId)
                    .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.NoAction
            }



            // configure Genre entity
            {
                builder.Entity<Genre>().HasKey(b => b.GenreId);

                // Seeding data for genres
                builder.Entity<Genre>().HasData(new Genre { GenreId = 1, Name = "Horror", });
            }



            {
                //configure Movies and Genre Many to Many Relationship
                builder.Entity<GenreMovies>()
              .HasKey(gm => new { gm.MovieId, gm.GenreId });

                builder.Entity<GenreMovies>()
                    .HasOne(gm => gm.Movies)
                    .WithMany(m => m.GenreMovies)
                    .HasForeignKey(gm => gm.MovieId);

                builder.Entity<GenreMovies>()
                    .HasOne(gm => gm.Genres)
                    .WithMany(g => g.GenreMovies)
                    .HasForeignKey(gm => gm.GenreId);

                // add data to movies
                builder.Entity<Movies>().HasData(new Movies { MovieId = 1, Title = "SharkTale", ContentRating = "Pg", Description = "A short Movie", });

                builder.Entity<Movies>().HasKey(b => new { b.MovieId, });
            }

            // add data to genremovies

            builder.Entity<GenreMovies>().HasData(new GenreMovies { MovieId = 4, GenreId = 4 });






        }





       
    }
}

