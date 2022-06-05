using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public string Name { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public Favourite() { }

        public Favourite(int dogId, string name, ApplicationUser applicationUser, string applicationId)
        {
            DogId = dogId;
            Name = name;
            ApplicationUser = applicationUser;
            ApplicationUserId = applicationId;
        }
    }
}
