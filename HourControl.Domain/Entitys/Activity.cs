using HourControl.Domain.Abstractions;

namespace HourControl.Domain.Entitys;

public class Activity : Entity
{
    public string Name { get; set; }
    public TimeSpan? TimeStart { get; set; }
    public TimeSpan? TimeEnd { get; set; }
    public TimeSpan? TimeTotal { get; set; }
    public DateTime? Date { get; set; }
    public Guid? ProjectId { get; set; }
    
    public virtual Project Project { get; set; }
}