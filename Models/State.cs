using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using TicketBookingApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }



        //Relationship with Country as the child
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public Country? Country { get; set; }


      
       // Relationship with City as the parent
        public City? City { get; set; }
                                            
    }
}
