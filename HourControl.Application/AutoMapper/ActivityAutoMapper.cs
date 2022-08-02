using AutoMapper;
using HourControl.Application.Dtos;
using HourControl.Application.ViewModels;
using HourControl.Domain.Entitys;

namespace HourControl.Application.AutoMapper;

public class ActivityAutoMapper : Profile
{
    public ActivityAutoMapper()
    {
        CreateMap<Activity, ActivityViewModel>();
        CreateMap<ActivityDto, Activity>();
    }
}