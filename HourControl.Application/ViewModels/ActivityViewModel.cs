namespace HourControl.Application.ViewModels;

public class ActivityViewModel
{
    public string Name { get; set; }
    public TimeSpan? TimeStart { get; set; }
    public TimeSpan? TimeEnd { get; set; }
    public TimeSpan? TimeTotal { get; set; }
    public DateTime? Date { get; set; }

    public ProjectViewModel Project { get; set; }
}