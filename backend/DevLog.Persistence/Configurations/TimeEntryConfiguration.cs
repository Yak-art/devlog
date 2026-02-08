using DevLog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevLog.Persistence.Configurations
{
    public class TimeEntryConfiguration : IEntityTypeConfiguration<TimeEntry>
    {
        public void Configure(EntityTypeBuilder<TimeEntry> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StartTime)
                .IsRequired();

            builder.Property(x => x.EndTime);

            builder.Ignore(x => x.Duration);
        }
    }
}
