using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using TicketBookingApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class CinemaLocation
    {

       
        public int CinemaLocationId { get; set; }

        [Required]
        public string? Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [Required]
        public string? Address { get; set; }
        public int ZipCode { get; set; }



      




    }
}
