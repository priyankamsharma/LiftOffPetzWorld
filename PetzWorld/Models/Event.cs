using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Event() { }

        public Event(string name, DateTime date, string description)
        {
            Name = name;
            Date = date;
            Description = description;
        }
    }
}
