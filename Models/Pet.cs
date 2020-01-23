using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//this upper three lines are useful for creating the primary key and foriegn key

namespace PetMvc.Models
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Notes { get; set; }

        //Representing the Many in (One species to Many Pets)

        public int SpeciesID { get; set; }
        [ForeignKey("SpeciesID")]
        public virtual Species Species { get; set; }
        //if there is no page of species this wont work

    }
}