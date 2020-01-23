using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMvc.Models
{
    public class GroomerServices
    {

        [Key]
        public string GroomServiceId { get; set; }
        public string GroomServiceName { get; set; }
        public string GroomServiceCost { get; set; }
        public string GroomServiceDuration { get; set; }
    }
}