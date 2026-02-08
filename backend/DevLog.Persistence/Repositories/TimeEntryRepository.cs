using DevLog.Application.Interfaces;
using DevLog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevLog.Persistence.Repositories
{
    public class TimeEntryRepository : ITimeEntryRepository
    {
        private readonly DevLogDbContext _dbContext;

        public TimeEntryRepository(DevLogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TimeEntry?> GetActiveByActivityIdAsync(Guid activityId, CancellationToken ct)
        {
            return await _dbContext.TimeEntries
                .FirstOrDefaultAsync(x => x.ActivityId == activityId && x.EndTime == null, ct);
        }

        public async Task AddAsync(TimeEntry entry, CancellationToken ct)
        {
            await _dbContext.TimeEntries.AddAsync(entry, ct);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task UpdateAsync(TimeEntry entry, CancellationToken ct)
        {
            _dbContext.TimeEntries.Update(entry);
            await _dbContext.SaveChangesAsync(ct);
        }
    }
}
