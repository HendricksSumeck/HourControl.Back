using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HourControl.Application.Dtos;
using HourControl.Application.Interfaces;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;

namespace HourControl.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;
    
    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost]
    public async Task<ActionResult<ProjectViewModel>> AddProject([FromBody] ProjectDto projectDto)
    {
        return await _projectService.AddAsync(projectDto);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<bool> DeleteProject(Guid id)
    {
        var project = await _projectService.GetById(id);

        if (project is not null) await _projectService.Delete(project);

        return true;
    }
    
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<ProjectViewModel>> UpdateProject([FromBody] ProjectDto projectDto, Guid id)
    {
        return await _projectService.Update(projectDto.AtribuirId(id));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Project>> GetProjectById(Guid id)
    {
        return await _projectService.GetById(id);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Project>>> GetProjects()
    {
        return await _projectService.GetAll().ToListAsync();
    }
}