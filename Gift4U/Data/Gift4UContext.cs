using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gift4U.Models;

namespace Gift4U.Data
{
    public class Gift4UContext : DbContext
    {
        public Gift4UContext (DbContextOptions<Gift4UContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<StoreSale>().HasKey(pr => new { pr.SaleId, pr.StoreID });
            modelBuilder.Entity<StoreSale>().HasOne(pt => pt.Store).WithMany(p => p.StoreSales).HasForeignKey(pt => pt.SaleId);
            modelBuilder.Entity<StoreSale>().HasOne(pt => pt.Sale).WithMany(t => t.StoreSales).HasForeignKey(pt => pt.StoreID); 
        }

        
        public DbSet<Gift4U.Models.Category> Category { get; set; }

        public DbSet<Gift4U.Models.User> User { get; set; }

        public DbSet<Gift4U.Models.Stores> Stores { get; set; }

        public DbSet<Gift4U.Models.Order> Order { get; set; }

        public DbSet<Gift4U.Models.StoreSale> StoreSale { get; set; }

        public DbSet<Gift4U.Models.Contact> Contact { get; set; }


        public DbSet<Gift4U.Models.Sale> Sale { get; set; }
    }
}
