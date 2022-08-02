using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HourControl.Domain.Entitys;
using HourControl.Infra.Data.Abstractions;
using HourControl.Infra.Data.Utils;

namespace HourControl.Infra.Data.Mappings;

public class ActivityMap : BaseEntityMap<Activity>
{
    protected override void ConfigureMap(EntityTypeBuilder<Activity> builder)
    {
        builder.ToTable(nameof(Activity));

        builder.Property(e => e.Name)
            .HasColumnType(DataType.String);
        
        builder.Property(e => e.TimeStart)
            .HasColumnType(DataType.TimeSpan);
        
        builder.Property(e => e.TimeEnd)
            .HasColumnType(DataType.TimeSpan);
        
        builder.Property(e => e.TimeTotal)
            .HasColumnType(DataType.TimeSpan);
        
        builder.Property(e => e.Date)
            .HasColumnType(DataType.DateTime);

        builder.HasOne(el => el.Project)
            .WithMany(el => el.Activitys)
            .HasForeignKey(el => el.ProjectId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}