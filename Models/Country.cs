using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using TicketBookingApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string ?Name { get; set; }


        // one to one relationship with State as the parent
        public State? State { get; set; }

        //one to one relationship with City as the parent

        public City? City { get; set; }

        // one to one relationship with location as child

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

    }
}