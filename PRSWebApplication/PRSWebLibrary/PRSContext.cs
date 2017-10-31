using Microsoft.EntityFrameworkCore;
using PRSWebLibrary.Models;

namespace PRSWebLibrary
{
    public class PRSContext : DbContext
    {
        public PRSContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public DbSet<PurchaseRequestLineItem> PurchaseRequestLineItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User
            modelBuilder.Entity<User>()
                .HasIndex(b => b.UserName)
                .IsUnique();
            // Vendor
            modelBuilder.Entity<Vendor>()
                .Property(b => b.IsActive)
                .HasDefaultValueSql("1");
            modelBuilder.Entity<Vendor>()
            .Property(b => b.DateCreated)
            .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Vendor>()
            .Property(b => b.DateUpdated)
            .HasDefaultValueSql("getdate()");
            // Product
            modelBuilder.Entity<Product>()
                .Property(b => b.IsActive)
                .HasDefaultValueSql("1");
            modelBuilder.Entity<Product>()
                .Property(b => b.UpdatedByUser)
                .HasDefaultValueSql("1");
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType($"decimal(10,2)");
            modelBuilder.Entity<Product>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Product>()
                .Property(b => b.DateUpdated)
                .HasDefaultValueSql("getdate()");
            // Purchase Request
            modelBuilder.Entity<PurchaseRequest>()
                .Property(p => p.Total)
                .HasColumnType($"decimal(10,2)");
            modelBuilder.Entity<PurchaseRequest>()
                .Property(b => b.SubmittedDate)
                .HasDefaultValueSql("getdate()");
        }
     
    }
}
