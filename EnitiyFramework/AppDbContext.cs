using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnitiyFramework.Tables;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.EnitiyFramework;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        // modelBuilder.Entity<User>().HasKey(u => u.UserId);
        // modelBuilder.Entity<User>().Property(u => u.FullName).IsRequired();
        // modelBuilder.Entity<User>().HasIndex(u => u.FullName).IsUnique();
        // modelBuilder
        //     .Entity<User>()
        //     .HasMany(r => r.Reviews)
        //     .WithOne(u => u.User)
        //     .HasForeignKey(r => r.UserId);
        // modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
        // modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        // modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
        // modelBuilder.Entity<User>().Property(u => u.Phone).IsRequired();
        // modelBuilder.Entity<User>().HasIndex(u => u.Phone).IsUnique();
    }
}
