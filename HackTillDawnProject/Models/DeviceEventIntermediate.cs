using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class DeviceEventIntermediate : DataRowProperty
    {
        //PK
        public Event Event { get; set; }
        public Guid IdEventId { get; set; }

        public RegisteredDevice RegisteredDevice { get; set; }
        public Guid IdRegisteredDeviceId { get; set; }
        //
        
    }
}
