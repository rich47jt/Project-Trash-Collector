using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Name")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ZipCode { get; set; }

        //public bool confirmation{get; set;}
        //-may need to have employee confirm pickups 
        

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

       
    }
}
