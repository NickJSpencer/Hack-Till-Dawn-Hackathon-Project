using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class Event : DataRowProperty
    {
        public Event()
        {
            RegisteredDevices = new HashSet<RegisteredDevice>();
            Channels = new HashSet<Channel>();
            StaffEventIntermediates = new HashSet<StaffEventIntermediate>();
        }
        public Guid IdEvent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? EventStart { get; set; }
        public DateTime? EventEnd { get; set; }

        public ICollection<RegisteredDevice> RegisteredDevices { get; set; }
        public ICollection<StaffEventIntermediate> StaffEventIntermediates { get; set; }
        public ICollection<Channel> Channels { get; set; }
    }
}
