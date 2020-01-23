using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMvc.Models
{
    public class GroomBooking
    {

        [Key]
        public string GroomBookingId { get; set; }
        public string GroomBookingPetName { get; set; }
        public string GroomBookingOwner { get; set; }
        public string GroomBookingGroomer { get; set; }
        public string GroomBookingServices { get; set; }
        public string GroomBookingDate { get; set; }
        public string GroomBookingTime { get; set; }
        public string GroomBookingPrice { get; set; }
    }
}