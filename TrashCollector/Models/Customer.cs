using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Scheduled Pickup Day")]
        public string PickupDayChoice { get; set; }
        [Display(Name = "*Suspend Pickup Start Date")]
        public string SuspendPickupStart { get; set; }
        [Display(Name = "*Suspend Pickup End Date")]
        public string SuspendPickupEnd { get; set; }
        [Display(Name = "One Time Scheduled Pickup")]
        public string OneTimePickup { get; set; }
        [Display(Name = "Balance Due")]
        public double Balance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }
}
