using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public Favourite() { }

        public Favourite(int animalId, string name, ApplicationUser applicationUser, string applicationId)
        {
            AnimalId = animalId;
            Name = name;
            ApplicationUser = applicationUser;
            ApplicationUserId = applicationId;
        }
    }
}
