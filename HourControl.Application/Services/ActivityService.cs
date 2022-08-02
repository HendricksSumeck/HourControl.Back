using AutoMapper;
using HourControl.Application.Dtos;
using HourControl.Application.Interfaces;
using HourControl.Application.ViewModels;
using HourControl.Domain.Abstractions;
using HourControl.Domain.Entitys;
using HourControl.Domain.Interfaces;

namespace HourControl.Application.Services;

public class ActivityService: Service<Activity, IActivityRepository>, IActivityService
{
    private readonly IMapper _mapper;
    
    public ActivityService(IActivityRepository repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }
    
    public async Task<ActivityViewModel> AddAsync(ActivityDto activityDto)
    {
        var activity = _mapper.Map<Activity>(activityDto);
        
        await _repository.AddAsync(activity);

        return _mapper.Map<ActivityViewModel>(activity);
    }

    public async Task<ActivityViewModel> Update(ActivityDto activityDto)
    {
        if (activityDto.ActivityId is not null)
        {
            var activity = await _repository.GetById(activityDto.ActivityId.Value);

            if (activity is not null)
            {
                activity.Name = activityDto.Name;
                activity.TimeStart = activityDto.TimeStart;
                activity.TimeEnd = activityDto.TimeEnd;
                activity.TimeTotal = activityDto.TimeTotal;
                activity.Date = activityDto.Date;
                activity.ProjectId = activityDto.ProjectId;

                await _repository.Update(activity);

                return _mapper.Map<ActivityViewModel>(activity);
            }
        }

        return _mapper.Map<ActivityViewModel>(false);;
    }

    public async Task<ActivityViewModel?> GetByIdActivity(Guid id)
    {
        var activity = await _repository.GetById(id);
        
        return _mapper.Map<ActivityViewModel>(activity);
    }
}