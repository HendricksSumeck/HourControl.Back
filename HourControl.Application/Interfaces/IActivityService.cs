using HourControl.Application.Dtos;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;
using HourControl.Shared.Application;

namespace HourControl.Application.Interfaces;

public interface IActivityService : IService<Activity>
{
    Task<ActivityViewModel> AddAsync(ActivityDto entity);
    Task<ActivityViewModel> Update(ActivityDto entity);
    Task<ActivityViewModel?> GetByIdActivity(Guid id);
}