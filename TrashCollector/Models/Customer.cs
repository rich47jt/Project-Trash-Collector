﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
        public int ZipCode { get; set; }
        public string PickUpDay { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Suspend { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    
      

    }
}
