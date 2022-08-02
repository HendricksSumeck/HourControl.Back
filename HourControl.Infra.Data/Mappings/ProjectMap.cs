using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HourControl.Domain.Entitys;
using HourControl.Infra.Data.Abstractions;
using HourControl.Infra.Data.Utils;

namespace HourControl.Infra.Data.Mappings;

public class ProjectMap : BaseEntityMap<Project>
{
    protected override void ConfigureMap(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable(nameof(Project));

        builder.Property(e => e.Name)
            .HasColumnType(DataType.String);

        builder.Property(e => e.Color)
            .HasColumnType(DataType.String);
    }
}