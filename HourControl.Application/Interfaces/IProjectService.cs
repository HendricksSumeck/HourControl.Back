using HourControl.Application.Dtos;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;
using HourControl.Shared.Application;

namespace HourControl.Application.Interfaces;

public interface IProjectService : IService<Project>
{
    Task<ProjectViewModel> AddAsync(ProjectDto entity);
    Task<ProjectViewModel> Update(ProjectDto entity);
}