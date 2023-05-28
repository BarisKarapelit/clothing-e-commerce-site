using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Data.Context;

public class WebAppDbContext : DbContext
{
    public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options) { }

    //db
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserLog> UserLog { get; set; }
    public DbSet<Account> Account { get; set; }
    public DbSet<Customer> Customer { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new UserLogConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
