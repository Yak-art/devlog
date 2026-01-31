using DevLog.Application.DTO;
using DevLog.Application.Interfaces;

namespace DevLog.Application.Queries.GetDailyReport
{
    public class GetDailyReportQueryHandler
    {
        private readonly IActivityRepository _activityRepository;

        public GetDailyReportQueryHandler(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public async Task<IReadOnlyList<ActivityDto>> Handle(GetDailyReportQuery query, CancellationToken ct)
        {
            var activities =
                await _activityRepository.GetByUserAndDateAsync(
                    query.UserId,
                    query.Date,
                    ct);

            return activities.Select(activity => new ActivityDto
            {
                Id = activity.Id,
                Title = activity.Title,
                Description = activity.Description,
                Type = activity.Type,
                Date = activity.Date
            }).ToList();
        }
    }
}
