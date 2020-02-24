using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        [Key]
        public int PickUpId { get; set; }
        public string PickUpDay { get; set; }
        public bool IsPickUp { get; set; }
        public double Balance { get; set; }
        public bool Suspend { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public Customer customer { get; set; }

        
        
    }
}
