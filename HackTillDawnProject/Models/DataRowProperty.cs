using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.Models
{
    public class DataRowProperty
    {
        public DateTime DateCreatedUtc { get; set; }
        public DateTime DateLastModifiedUtc { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
