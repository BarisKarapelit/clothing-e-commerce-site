using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Domain;

namespace WebApplication.Data.Context;

public class WebAppDbContext : DbContext
{
    public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options) { }

    //db
    public DbSet<Product> Product { get; set; }
    public DbSet<Basket> Basket { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Price> Price { get; set; }
    public DbSet<Category> Category { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new BasketConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new PriceConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
