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
        //need to limit access to employee
        public double Balance { get; set; }
        // balance needs to be set a zero until it can be added to through the employee confirming pickup 
        public bool Suspend { get; set; }
        //default to edit page until the cusotmer has change suspend 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // start and end need to only appear with suspend is true 
        
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public Customer customer { get; set; }

        
        
    }
}
