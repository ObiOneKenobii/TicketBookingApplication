namespace TicketBookingApplication.Models
{
    public class GenreMovies
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }    

        public Movies Movies { get; set; }
        public Genre Genres { get; set; }   
    }
}
