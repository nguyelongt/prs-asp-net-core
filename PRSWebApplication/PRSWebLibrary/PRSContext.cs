using Microsoft.EntityFrameworkCore;
using PRSWebLibrary.Models;

namespace PRSWebLibrary
{
    public class PRSContext : DbContext
    {
        public PRSContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(b => b.UserName)
                .IsUnique();
        }
    }
}
