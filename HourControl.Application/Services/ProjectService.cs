using AutoMapper;
using HourControl.Application.Dtos;
using HourControl.Application.Interfaces;
using HourControl.Application.ViewModels;
using HourControl.Domain.Abstractions;
using HourControl.Domain.Entitys;
using HourControl.Domain.Interfaces;

namespace HourControl.Application.Services;

public class ProjectService : Service<Project, IProjectRepository>, IProjectService
{
    private readonly IMapper _mapper;
    
    public ProjectService(IProjectRepository repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }

    public async Task<ProjectViewModel> AddAsync(ProjectDto projectDto)
    {
        var project = _mapper.Map<Project>(projectDto);
        
        await _repository.AddAsync(project);

        return _mapper.Map<ProjectViewModel>(project);
    }

    public async Task<ProjectViewModel> Update(ProjectDto projectDto)
    {
        if (projectDto.ProjectId is not null)
        {
            var project = await _repository.GetById(projectDto.ProjectId.Value);

            if (project is not null)
            {
                project.Name = projectDto.Name;
                project.Color = projectDto.Color;

                await _repository.Update(project);

                return _mapper.Map<ProjectViewModel>(project);
            }
        }

        return _mapper.Map<ProjectViewModel>(false);;
    }
}