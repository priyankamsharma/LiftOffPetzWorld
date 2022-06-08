using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetzWorld.Models;
using System.Collections.Generic;

namespace PetzWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Favourite> Favorites { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        static private Dictionary<int, Dog> MyDogs = new Dictionary<int, Dog>();
        // GetAll
        public static IEnumerable<Dog> GetAll()
        {
            return MyDogs.Values;
        }
       
        public static Dog GetById(int id)
        {
            return MyDogs[id];
        }

        // Edit
        public static void ChangeInfo(int id, string newInfo)
        {
            MyDogs[id].Info = newInfo;
        }
    }
}
