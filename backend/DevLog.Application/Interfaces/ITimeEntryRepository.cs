using DevLog.Domain.Entities;

namespace DevLog.Application.Interfaces
{
    /// <summary>
    /// Репозиторий учёта времени.
    /// </summary>
    public interface ITimeEntryRepository
    {
        Task<TimeEntry?> GetActiveByActivityIdAsync(Guid activityId, CancellationToken ct);
        Task AddAsync(TimeEntry entry, CancellationToken ct);
        Task UpdateAsync(TimeEntry entry, CancellationToken ct);
    }
}
