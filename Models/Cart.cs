using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Models;

namespace TicketBookingApplication.Models
{
    public class Cart

    {


        public int CartId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
      




        // Navigation property for Visitor
        [ForeignKey("Visitor")]
        public int VisitorId { get; set; }
        public Visitor? Visitor { get; set; } 
        
      

    }
}
