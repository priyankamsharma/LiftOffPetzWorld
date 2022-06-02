using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetzWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetzWorld.Data
{
    //public class ApplicationDbContext : IdentityDbContext
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }

        public DbSet<DogData> DogDataSets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
