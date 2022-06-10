using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Favourite> Favourites { get; set; }
    }
}
