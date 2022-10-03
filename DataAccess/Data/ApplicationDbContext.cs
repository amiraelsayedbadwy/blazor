using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductPrice> ProductPrices { get; set; }
        //public DbSet<OrderHeader> OrderHeaders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

