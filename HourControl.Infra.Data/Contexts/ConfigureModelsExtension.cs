using HourControl.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace HourControl.Infra.Data.Contexts;

public static class ConfigureModelsExtension
{
    public static void AddConfigureModels(this ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProjectMap());
        builder.ApplyConfiguration(new ActivityMap());
    }
}