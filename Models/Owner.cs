using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetMvc.Models
{
    public class Owner
    {

        [Key]
        public string OwnerId { get; set; }
        public string OwnerFName { get; set; }
        public string OwnerLname { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerWPhone { get; set; }
        public string OwnerHPhone { get; set; }
    }
}