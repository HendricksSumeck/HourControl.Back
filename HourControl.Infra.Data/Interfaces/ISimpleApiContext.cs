using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using HourControl.Domain.Entitys;

namespace HourControl.Infra.Data.Interfaces;

public interface ISimpleApiDbContext : IDisposable
{
    DatabaseFacade Database { get; }
    public DbSet<Project> Projects { get; set; }
    
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}