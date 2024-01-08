using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Models
{
    public class AvailableMovies
    {


        public int AvailableMoviesId { get; set; }

        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ContentRating { get; set; }
        public DateTime MovieDates { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }





        // Navigation property for Visitor
        public int VisitorId { get; set; }
        [ForeignKey("GenreId")]
        public Visitor? Visitors { get; set; } 


    }
}
