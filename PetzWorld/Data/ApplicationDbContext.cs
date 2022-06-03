using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetzWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetzWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
