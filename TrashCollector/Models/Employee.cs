using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PickupDayChoice { get; set; }
        public string SuspendPickup { get; set; }
        public double Balance { get; set; }

    }
}
