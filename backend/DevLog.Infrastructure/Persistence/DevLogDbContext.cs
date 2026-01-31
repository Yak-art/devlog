using DevLog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevLog.Infrastructure.Persistence
{
    /// <summary>
    /// Контекст базы данных DevLog.
    /// </summary>
    public class DevLogDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Activity> Activities => Set<Activity>();
        public DbSet<TimeEntry> TimeEntries => Set<TimeEntry>();

        public DevLogDbContext(DbContextOptions<DevLogDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DevLogDbContext).Assembly);
        }
    }
}
