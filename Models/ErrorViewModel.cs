using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
                                            
namespace TicketBookingApplication.Models
{
   
        public class ErrorViewModel
        {
            public string RequestId { get; set; }

            public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        }
    
}
