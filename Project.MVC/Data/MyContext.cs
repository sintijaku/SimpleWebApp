using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenFu;
using Project.MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Project.MVC.Data
{
    public class MyContext: IdentityDbContext<AppUser>
    {
        public MyContext(DbContextOptions<MyContext> options) :base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().ToTable("AppUser");
        }
    }
}
