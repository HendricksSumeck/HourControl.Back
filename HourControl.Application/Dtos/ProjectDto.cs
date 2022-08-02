namespace HourControl.Application.Dtos;

public class ProjectDto
{
    public Guid? ProjectId { get; private set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public ProjectDto AtribuirId(Guid? projectId)
    {
        ProjectId = projectId;
        return this;
    }
}