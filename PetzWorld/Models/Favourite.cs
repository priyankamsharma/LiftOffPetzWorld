using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Favourite
    {
        public int DogId { get; set; }
        public Dog Dog { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public Favourite() { }

    }
}
