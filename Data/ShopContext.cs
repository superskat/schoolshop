﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Mappings;
using Shop.Models;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Person> Person { get; set; }

        public DbSet<GiftCard> GiftCards { get; set; }
        public DbSet<ProcentSale> ProcentSale { get; set; }
        public DbSet<SumSale> SumSale { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderItemMap());
            modelBuilder.ApplyConfiguration(new PersondMap());

            modelBuilder.ApplyConfiguration(new GiftCardMap());
            modelBuilder.ApplyConfiguration(new ProcentSaleMap());
            modelBuilder.ApplyConfiguration(new SumSaleMap());
        }
    }
}
