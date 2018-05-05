using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class RegisteredDevice : DataRowProperty
    {
        public RegisteredDevice()
        {
            DeviceEventIntermediates = new HashSet<DeviceEventIntermediate>();
            FootageStored = new HashSet<FootageStorage>();
        }
        public Guid IdRegisteredDevice { get; set; }
        public string DeviceName { get; set; }
        public DateTime DateRegistered { get; set; }

        public ApplicationUser RegisteredBy { get; set; }
        public string RegisteredById { get; set; }

        public ICollection<DeviceEventIntermediate> DeviceEventIntermediates { get; set; }
        public ICollection<FootageStorage> FootageStored { get; set; }
    }
}
