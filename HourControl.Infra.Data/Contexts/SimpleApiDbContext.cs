using Microsoft.EntityFrameworkCore;
using HourControl.Domain.Entitys;
using HourControl.Infra.Data.Interfaces;

namespace HourControl.Infra.Data.Contexts;

public sealed class SimpleApiDbContext : DbContext, ISimpleApiDbContext
{
    public DbSet<Project> Projects { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5442;Database=HourControl;Username=postgres;Password=postgres");
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.AddConfigureModels();
    }
}