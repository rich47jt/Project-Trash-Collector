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
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public Customer customer { get; set; }
        
    }
}
