using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetzWorld.Models;
using System.Collections.Generic;

namespace PetzWorld.Data
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Favourite> Favorites { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favourite>()
                .HasKey(f => new { f.DogId, f.ApplicationUserId });
            modelBuilder.Entity<Favourite>()
                .HasOne(f => f.ApplicationUser)
                .WithMany(au => au.Favourites)
                .HasForeignKey(f => f.ApplicationUserId);
            modelBuilder.Entity<Favourite>()
                .HasOne(f => f.Dog)
                .WithMany(d => d.Favourites)
                .HasForeignKey(f => f.DogId);

            base.OnModelCreating(modelBuilder);
        }


        //static private Dictionary<int, Dog> MyDogs = new Dictionary<int, Dog>();
        //// GetAll
        //public static IEnumerable<Dog> GetAll()
        //{
        //    return MyDogs.Values;
        //}

        //public static Dog GetById(int id)
        //{
        //    return MyDogs[id];
        //}

        //// Edit
        //public static void ChangeInfo(int id, string newInfo)
        //{
        //    MyDogs[id].Info = newInfo;
        //}
    }
}
