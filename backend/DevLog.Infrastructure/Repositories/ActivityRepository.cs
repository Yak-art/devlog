using DevLog.Application.Interfaces;
using DevLog.Domain.Entities;
using DevLog.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevLog.Infrastructure.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly DevLogDbContext _dbContext;

        public ActivityRepository(DevLogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Activity?> GetByIdAsync(Guid id, CancellationToken ct)
        {
            return await _dbContext.Activities
                .FirstOrDefaultAsync(x => x.Id == id, ct);
        }

        public async Task<IReadOnlyList<Activity>> GetByUserAndDateAsync(Guid userId, DateOnly date, CancellationToken ct)
        {
            return await _dbContext.Activities
                .Where(x => x.UserId == userId && x.Date == date)
                .ToListAsync(ct);
        }

        public async Task AddAsync(Activity activity, CancellationToken ct)
        {
            await _dbContext.Activities.AddAsync(activity, ct);
            await _dbContext.SaveChangesAsync(ct);
        }
    }
}
