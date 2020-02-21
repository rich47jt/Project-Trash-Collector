using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Account
    {
        [Key]
        public int AccountId {get; set;}
        public double Balance { get; set; }



    }
}
