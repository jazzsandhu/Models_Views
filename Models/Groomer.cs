using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMvc.Models
{
    public class Groomer
    {

        [Key]
        public string GroomerId { get; set; }
        [Column("GroomerFName", Order = 1)]
        //try to change the order of coloumn in database
        public string GroomerFName { get; set; }
        public string GroomerLName { get; set; }
        public string GroomerDOB { get; set; }
        public string GroomerPhone { get; set; }
        public string GroomerHRate { get; set; }
        //described in cents per hour (i.e. $25/hr = 2500cents/hr
        //easy for computer to recognize in cents rather then dollar
    }
}