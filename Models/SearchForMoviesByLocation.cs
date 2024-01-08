using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; // Add this for List<>
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TicketBookingApplication.Models;
namespace TicketBookingApplication.Models
{
    public class SearchForMoviesByLocation
    {
       
        public int SearchForMoviesByLocationId { get; set; }



        public int Location { get; set; }

        [ForeignKey("GenreId")]
        public Location ? Locations { get; set; }

        // Define a many-to-one relationship with Visitor
        public int VisitorId { get; set; }
        [ForeignKey("VisitorId")]
        public Visitor ? Visitor { get; set; }

    }
}
