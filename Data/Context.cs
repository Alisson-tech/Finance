
using Finance.Models;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MarmorariaDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<BaseEntity>();

        modelBuilder.Entity<Expenses>(entity =>
        {
            entity.HasKey(e => e.Id);
            modelBuilder.Entity<Expenses>()
                .HasMany(e => e.ExpensesValues)
                .WithOne(ev => ev.Expenses)
                .HasForeignKey(ev => ev.ExpensesId);
        });
        modelBuilder.Entity<ExpensesValues>(entity =>
        {
            entity.HasKey(ev => ev.Id);
        });
        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.HasKey(r => r.Id);
            modelBuilder.Entity<Revenue>()
                .HasMany(r => r.RevenueValues)
                .WithOne(rv => rv.Revenue)
                .HasForeignKey(rv => rv.RevenueId);
        });
        modelBuilder.Entity<RevenueValues>(entity =>
        {
            entity.HasKey(rv => rv.Id);
        });
    }

    public DbSet<Expenses> Expenses { get; set; }
    public DbSet<ExpensesValues> ExpensesValues { get; set; }
    public DbSet<Revenue> Revenue { get; set; }
    public DbSet<RevenueValues> RevenueValues { get; set; }
}
