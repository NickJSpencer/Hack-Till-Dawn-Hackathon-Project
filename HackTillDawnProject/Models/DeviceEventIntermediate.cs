using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class DeviceEventIntermediate : DataRowProperty
    {
        public Guid IdEventId { get; set; }
        public Guid IdRegisteredDeviceId { get; set; }
        //o
    }
}
