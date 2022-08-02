using AutoMapper;
using HourControl.Application.Dtos;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;

namespace HourControl.Application.AutoMapper;

public class ProjectAutoMapper : Profile
{
    public ProjectAutoMapper()
    {
        CreateMap<Project, ProjectViewModel>();
        CreateMap<ProjectDto, Project>();
    }
}