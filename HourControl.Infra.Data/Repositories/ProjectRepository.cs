using HourControl.Domain.Entitys;
using HourControl.Domain.Interfaces;
using HourControl.Infra.Data.Abstractions;
using HourControl.Infra.Data.Interfaces;

namespace HourControl.Infra.Data.Repositories;

public class ProjectRepository : Repository<Project>, IProjectRepository
{
    public ProjectRepository(Lazy<ISimpleApiDbContext> context) : base(context)
    {
    }
}