using HourControl.Domain.Abstractions;

namespace HourControl.Domain.Entitys;

public class Project : Entity
{
    public string Name { get; set; }
    public string Color { get; set; }

    public ICollection<Activity> Activitys { get; set; }
}