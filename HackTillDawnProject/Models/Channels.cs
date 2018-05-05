using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    /// <summary>
    /// Generally one channel per monitoring user
    /// </summary>
    public class Channel
    {
        public Channel()
        {
            Contacts = new HashSet<Contact>();
        }
        //PK
        public Guid IdChannel { get; set; }
        //
        public string Name { get; set; }
        public string Description { get; set; }

        public Event Event { get; set; }
        public Guid EventId { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
