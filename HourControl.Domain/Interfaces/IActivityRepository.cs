using HourControl.Domain.Entitys;
using HourControl.Shared.Data;

namespace HourControl.Domain.Interfaces;

public interface IActivityRepository : IRepository<Activity>
{
    Task<Activity?> GetById(Guid id);
}