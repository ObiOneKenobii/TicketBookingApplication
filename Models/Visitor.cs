using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TicketBookingApplication.Models
{
    public class Visitor
    {
        
        public int VisitorId { get; set; }
        [Required]
       public string Name { get; set; }













    }
}
