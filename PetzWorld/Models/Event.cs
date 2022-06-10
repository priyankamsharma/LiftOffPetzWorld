using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public Event() { }

        //public Event(string name, date eventDate, string eventTime, string description)
        public Event(string name, DateTime eventDate, string description)
        {
            Name = name;
            EventDate = eventDate;
            Description = description;
        }
    }
}
