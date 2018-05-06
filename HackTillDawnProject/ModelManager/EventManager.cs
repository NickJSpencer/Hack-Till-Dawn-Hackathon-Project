using HackTillDawnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackTillDawnProject.ModelManager
{
    public class EventManager
    {
        public Event CreateNewEvent(string EventName)
        {
            return new Event()
            {
                Name = EventName
            };
        }
    }
}
