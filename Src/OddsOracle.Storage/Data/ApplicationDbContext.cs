using System.Reflection;
using Microsoft.EntityFrameworkCore;
using OddsOracle.Storage.Entities;

namespace OddsOracle.Storage.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }
    public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();
    public DbSet<Tip> Tips => Set<Tip>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    public DbSet<User> Users => Set<User>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<Role> Roles => Set<Role>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasIndex(u => u.PhoneNumber).IsUnique();
        modelBuilder.Entity<User>().HasIndex(c => c.Email).IsUnique();
        modelBuilder.Entity<User>().HasIndex(c => c.Username).IsUnique();
    }
}