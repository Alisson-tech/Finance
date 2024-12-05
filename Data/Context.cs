
using Finance.Models;
using Microsoft.EntityFrameworkCore;

namespace Finance.Data;

public class Context : DbContext
{
    public DbSet<ExpensiveType> ExpensiveType { get; set; }
    public DbSet<Expenses> Expenses { get; set; }
    public DbSet<ExpensesValues> ExpensesValues { get; set; }

    public DbSet<RevenueType> RevenueTypes { get; set; }
    public DbSet<Revenue> Revenue { get; set; }
    public DbSet<RevenueValues> RevenueValues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=finance");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<BaseEntity>();

        modelBuilder.Entity<ExpensiveType>(entity =>
        {
            entity.HasKey(et => et.Id);
            modelBuilder.Entity<ExpensiveType>()
                .HasMany(et => et.Expenses)
                .WithOne(e => e.Type)
                .HasForeignKey(e => e.Id);
        });
        modelBuilder.Entity<Expenses>(entity =>
        {
            entity.HasKey(e => e.Id);
            modelBuilder.Entity<Expenses>()
                .HasMany(ev => ev.ExpensesValues)
                .WithOne(v => v.Expenses)
                .HasForeignKey(ev => ev.Id);
        });
        modelBuilder.Entity<ExpensesValues>(entity =>
        {
            entity.HasKey(ev => ev.Id);
        });

        modelBuilder.Entity<RevenueType>(entity =>
        {
            entity.HasKey(rt => rt.Id);
            modelBuilder.Entity<RevenueType>()
                .HasMany(rt => rt.Revenues)
                .WithOne(r => r.Type)
                .HasForeignKey(r => r.Id);
        });
        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.HasKey(r => r.Id);
            modelBuilder.Entity<Revenue>()
                .HasMany(rv => rv.RevenueValues)
                .WithOne(r => r.Revenue)
                .HasForeignKey(rv => rv.Id);
        });
        modelBuilder.Entity<RevenueValues>(entity =>
        {
            entity.HasKey(rv => rv.Id);
        });

    }

    public override int SaveChanges()
    {
        ProcessEntityChanges();

        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ProcessEntityChanges();

        return await base.SaveChangesAsync(cancellationToken);
    }

    private void ProcessEntityChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is BaseEntity &&
                        (e.State == EntityState.Added || e.State == EntityState.Deleted || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var entity = (BaseEntity)entry.Entity;

            switch (entry.State)
            {
                case EntityState.Added:
                    entity.DateCreated = DateTime.UtcNow;
                    break;

                case EntityState.Modified:
                    entity.DateModified = DateTime.UtcNow;
                    break;

                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entity.DateDeleted = DateTime.UtcNow;
                    break;
            }
        }
    }
}
