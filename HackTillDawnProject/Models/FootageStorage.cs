using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class FootageStorage : DataRowProperty
    {
        public FootageStorage()
        {
            FootageStored = new HashSet<FootageStorage>();
        }
        public Guid IdFootageStorage { get; set; }
        public string DeviceName { get; set; }
        public DateTime DateRegistered { get; set; }

        public ApplicationUser RegisteredBy { get; set; }
        public string RegisteredById { get; set; }



        public ICollection<FootageStorage> FootageStored { get; set; }

    }
}
