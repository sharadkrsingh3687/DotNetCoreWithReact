using BloodDonation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloodDonation.DAL
{
    public class SampleDbContext: DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options): base(options)
        {                
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(x => x.Id);
        }
    }
}
