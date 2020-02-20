using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        [Key]
        public string PickUpDay { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsPickUp { get; set; }


    }
}
