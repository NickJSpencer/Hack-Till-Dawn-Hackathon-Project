using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class APIResultType : DataRowProperty
    { 
        public APIResultType()
        {
            FootageStorages = new HashSet<FootageStorage>();
        }
        public Guid IdResultType { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string APIName { get; set; }

        public ICollection<FootageStorage> FootageStorages { get; set; }
    }
}
