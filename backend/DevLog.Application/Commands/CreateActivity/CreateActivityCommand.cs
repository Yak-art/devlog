using DevLog.Domain.Enums;

namespace DevLog.Application.Commands.CreateActivity
{
    public class CreateActivityCommand
    {
        public Guid UserId { get; init; }
        public string Title { get; init; } = default!;
        public string? Description { get; init; }
        public ActivityType Type { get; init; }
        public DateOnly Date { get; init; }
    }
}
