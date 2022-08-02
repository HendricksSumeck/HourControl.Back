using HourControl.Domain.Entitys;
using HourControl.Domain.Interfaces;
using HourControl.Infra.Data.Abstractions;
using HourControl.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HourControl.Infra.Data.Repositories;

public class ActivityRepository: Repository<Activity>, IActivityRepository
{
    public ActivityRepository(Lazy<ISimpleApiDbContext> context) : base(context)
    {
    }

    public async Task<Activity?> GetById(Guid id)
    {
        return await Db.Activitys
            .Include(e => e.Project)
            .FirstOrDefaultAsync(e => e.Id == id);
    }
}