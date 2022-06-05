using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Events() { }

        public Events(string name, DateTime date, string description)
        {
            Name = name;
            Date = date;
            Description = description;
        }
    }
}
