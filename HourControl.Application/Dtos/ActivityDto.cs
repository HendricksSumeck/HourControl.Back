using HourControl.Domain.Entitys;

namespace HourControl.Application.Dtos;

public class ActivityDto
{
    public Guid? ActivityId { get; set; }
    public string Name { get; set; }
    public TimeSpan? TimeStart { get; set; }
    public TimeSpan? TimeEnd { get; set; }
    public TimeSpan? TimeTotal { get; set; }
    public DateTime? Date { get; set; }
    public Guid? ProjectId { get; set; }
    
    public ActivityDto AtribuirId(Guid? activityId)
    {
        ActivityId = activityId;
        return this;
    }
}