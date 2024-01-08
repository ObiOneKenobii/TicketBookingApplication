using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Models;


namespace TicketBookingApplication.Models 
   
{
   
    public class Movies 
    {
        
        public int MovieId { get; set; }

       
        
        public string Title { get; set; }

        
        public string Description { get; set; }

       
        public string ContentRating { get; set; }

        public DateTime ReleaseDate { get; set; }



        // Correct the foreign key property name to match GenreId in the Genre model

       
           public List <GenreMovies> GenreMovies { get; set; }
    }

}
