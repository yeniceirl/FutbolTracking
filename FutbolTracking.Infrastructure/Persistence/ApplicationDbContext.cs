using FutbolTracking.Domain.Entities;
using FutbolTracking.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

using FutbolTracking.Application.Contracts;

namespace FutbolTracking.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<League> Leagues => Set<League>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<League>(builder =>
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name).IsRequired();
            builder.OwnsOne(l => l.Country, b =>
            {
                b.Property(p => p.Id).HasColumnName("CountryId");
                b.Property(p => p.Key).HasColumnName("CountryKey");
                b.Property(p => p.Value).HasColumnName("CountryValue");
            });
            builder.OwnsOne(l => l.Type, b =>
            {
                b.Property(p => p.Id).HasColumnName("TypeId");
                b.Property(p => p.Key).HasColumnName("TypeKey");
                b.Property(p => p.Value).HasColumnName("TypeValue");
            });
            builder.OwnsOne(l => l.Rankin, b =>
            {
                b.Property(p => p.Id).HasColumnName("RankinId");
                b.Property(p => p.Key).HasColumnName("RankinKey");
                b.Property(p => p.Value).HasColumnName("RankinValue");
            });
        });
    }
}

