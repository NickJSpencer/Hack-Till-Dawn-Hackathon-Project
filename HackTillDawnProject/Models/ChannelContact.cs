using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class ChannelContactIntermediate : DataRowProperty
    {
        //PK
        public Channel Channel { get; set; }
        public Guid IdChannelId { get; set; }

        public Contact Contact { get; set; }
        public Guid IdContactId { get; set; }
        //
    }
}
