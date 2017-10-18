using Microsoft.EntityFrameworkCore;
using PRSWebLibrary.Models;
using System;

namespace PRSWebLibrary
{
    public class PRSContext : DbContext
    {
        public PRSContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(b => b.UserName)
                .IsUnique();
        }
    }
}
