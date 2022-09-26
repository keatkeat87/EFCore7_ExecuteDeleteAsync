using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EFCore7;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=192.168.1.152;Database=EFCore7;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True")
            .LogTo(Console.WriteLine);
    }

    public DbSet<Customer> Customers => Set<Customer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Customer>().Property(e => e.Name).HasMaxLength(256);
        modelBuilder.Entity<Customer>().OwnsOne(e => e.Address, addressBuilder =>
        {
            addressBuilder.Property(e => e.Line1).HasMaxLength(256);
            addressBuilder.Property(e => e.Line2).HasMaxLength(256);
        });
    }
}