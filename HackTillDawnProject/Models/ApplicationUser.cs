using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HackTillDawnProject.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            RegisteredDevices = new HashSet<RegisteredDevice>();
            StaffEventIntermediates = new HashSet<StaffEventIntermediate>();
        }
        /// <summary>
        /// Allow for custom badge numbers to identity users
        /// </summary>
        public string StaffId { get; set; }

        public ICollection<RegisteredDevice> RegisteredDevices { get; set; }
        public ICollection<StaffEventIntermediate> StaffEventIntermediates { get; set; }
    }
}
