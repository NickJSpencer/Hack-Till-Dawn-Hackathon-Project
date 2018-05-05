using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class StaffEventIntermediate : DataRowProperty
    {
        //PK
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public Event Event { get; set; }
        public Guid EventId { get; set; }
        //
    }
}
