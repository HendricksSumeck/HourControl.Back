using HourControl.Domain.Entitys;
using HourControl.Domain.Interfaces;
using HourControl.Infra.Data.Abstractions;
using HourControl.Infra.Data.Interfaces;

namespace HourControl.Infra.Data.Repositories;

public class ActivityRepository: Repository<Activity>, IActivityRepository
{
    public ActivityRepository(Lazy<ISimpleApiDbContext> context) : base(context)
    {
    }
    
}