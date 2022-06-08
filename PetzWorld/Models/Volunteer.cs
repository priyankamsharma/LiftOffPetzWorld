using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public Volunteer() { }

        public Volunteer(int eventId, string eventName, string description, ApplicationUser applicationUser, string applicationUserId)
        {
            EventId = eventId;
            EventName = eventName;
            Description = description;
            ApplicationUser = applicationUser;
            ApplicationUserId = applicationUserId;
        }
    }
}
