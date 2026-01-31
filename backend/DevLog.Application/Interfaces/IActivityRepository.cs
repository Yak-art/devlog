using DevLog.Domain.Entities;

namespace DevLog.Application.Interfaces
{
    /// <summary>
    /// Репозиторий активностей.
    /// </summary>
    public interface IActivityRepository
    {
        Task<Activity?> GetByIdAsync(Guid id, CancellationToken ct);
        Task<IReadOnlyList<Activity>> GetByUserAndDateAsync(Guid userId, DateOnly date, CancellationToken ct);
        Task AddAsync(Activity activity, CancellationToken ct);
    }
}
