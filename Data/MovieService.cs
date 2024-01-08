//using Microsoft.EntityFrameworkCore;
//using TicketBookingApplication.Models;

//namespace TicketBookingApplication.Data
//{

//    public class MovieService
//    {
//        private readonly ApplicationDbContext dbContext;

//        public MovieService(ApplicationDbContext dbContext)
//        {
//            this.dbContext = dbContext;
//        }

//        public List<Movies> GetMoviesWithGenre(List<Movies> genresWithMovies, List<Movies> genresWithMovies)
//        {
//            // Use Include to eagerly load the Genre related to each Movie
//            List<Genre> genresWithMovies = dbContext.Genres.Include(m => m.Movies).ToList();

//            return genresWithMovies;
//        }
//    }


//}
