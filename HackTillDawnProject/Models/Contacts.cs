using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class Contact : DataRowProperty
    {
        public Contact()
        {
            ChannelContactIntermediates = new HashSet<ChannelContactIntermediate>();
        }
        public Guid IdContact { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public int? ComChannel { get; set; }

        public ICollection<ChannelContactIntermediate> ChannelContactIntermediates { get; set; }
    }
}
