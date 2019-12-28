using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dotnet_sistema_delivery.Models;

namespace dotnet_sistema_delivery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Category> category {get; set;}
        public DbSet<Supplier> supplier {get; set;}
        public DbSet<Product> product {get; set;}
        public DbSet<Promotion> promotion {get; set;}
        public DbSet<Stock> stock {get; set;}
        public DbSet<OrderItem> order_item {get; set;}
        public DbSet<Order> order {get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
