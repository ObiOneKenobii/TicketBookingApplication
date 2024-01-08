using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketBookingApplication.Data;

namespace TicketBookingApplication.Models
{
    public class Genre
    {
        
        public int GenreId { get; set; }
        
        public string ?Name { get; set; }




        public List<GenreMovies> GenreMovies { get; set; }
    }
}