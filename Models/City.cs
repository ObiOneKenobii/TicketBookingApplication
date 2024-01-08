using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using TicketBookingApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required]
        public string Name { get; set; }


        // one to one relationship with State as the child

        [ForeignKey("State")]
        public int StateId {  get; set; }
        public State ?State { get; set; }


        //one to one relationship with country as the child 


        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country? Country { get; set; }





        // One to One Relationship with Location

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }
    }
}