using DevLog.Domain.Enums;

namespace DevLog.Application.DTO
{
    /// <summary>
    /// DTO активности.
    /// </summary>
    public class ActivityDto
    {
        public Guid Id { get; init; }
        public string Title { get; init; } = default!;
        public string? Description { get; init; }
        public ActivityType Type { get; init; }
        public DateOnly Date { get; init; }
    }
}
