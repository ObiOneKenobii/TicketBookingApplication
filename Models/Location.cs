using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class Location
    {
      


        [Key]
        public int LocationId { get; set; }


        [Required]
        public string? Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [Required]
        public string? Address { get; set; }
        public int ZipCode { get; set; }





        // Every Location can have many visitors

        [ForeignKey("Visitor")]
        public int VisitorId { get; set; }
        public Visitor? Visitor { get; set; }



        // Every Location has a one to many relationship with these so 
        //it must get them as a list everytime

       
        public State? State { get; set; }



        public City? City { get; set; }

       

        public Country? Country { get; set; }

     


    }

  

}