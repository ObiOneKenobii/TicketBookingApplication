using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using TicketBookingApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class Ticket
    {

       
        public int TicketId { get; set; }
     
        public int SeatNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SelectedDate { get; set; }
        public DateTime SelectedTime { get; set; }

        public int VisitorId { get; set; }
        [ForeignKey("VisitorId")]
        public Visitor ?Visitor { get; set; } 

        //public ICollection<TicketDetail> AvailableMoviesDetails { get; set; } = new List<TicketDetail>();
        //public ICollection<Visitor> NewVisitorBooked { get; set; } = new List<Visitor>();

    }
}
