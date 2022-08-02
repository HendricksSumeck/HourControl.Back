using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HourControl.Application.Dtos;
using HourControl.Application.Interfaces;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;

namespace HourControl.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivityController : ControllerBase
{
    private readonly IActivityService _activityService;
    
    public ActivityController(IActivityService activityService)
    {
        _activityService = activityService;
    }

    [HttpPost]
    public async Task<ActionResult<ActivityViewModel>> AddActivity([FromBody] ActivityDto activityDto)
    {
        return await _activityService.AddAsync(activityDto);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<bool> DeleteActivity(Guid id)
    {
        var activity = await _activityService.GetById(id);

        if (activity is not null) await _activityService.Delete(activity);

        return true;
    }
    
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<ActivityViewModel>> UpdateActivity([FromBody] ActivityDto activityDto, Guid id)
    {
        return await _activityService.Update(activityDto.AtribuirId(id));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Activity>> GetActivityById(Guid id)
    {
        return await _activityService.GetById(id);
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivitys()
    {
        return await _activityService.GetAll().ToListAsync();
    }
}