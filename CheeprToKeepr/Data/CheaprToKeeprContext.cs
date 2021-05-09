using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheeprToKeepr.Models;

namespace CheeprToKeepr.Data
{
    public class CheeprToKeeprContext : DbContext
    {
        public CheeprToKeeprContext()
        {
        }
        public CheeprToKeeprContext(DbContextOptions<CheeprToKeeprContext> opts)
            : base(opts)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");
            modelBuilder.Entity<Service>()
                .ToTable("Service");
            modelBuilder.Entity<ServicesCategory>()
                .ToTable("ServicesCategory");
            modelBuilder.Entity<Expense>()
                .ToTable("Expense");
            modelBuilder.Entity<ExpenseCategory>()
                .ToTable("ExpenseCategory");
            modelBuilder.Entity<Vehicle>()
                .ToTable("Vehicle");
            modelBuilder.Entity<Vendor>()
                .ToTable("Vendors");
            modelBuilder.Entity<VendorCategory>()
                .ToTable("VendorsCategory");

        }
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesCategory> ServicesCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorCategory> VendorsCategories { get; set; }
    }

}
