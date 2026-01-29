using DevLog.Domain.Enums;

namespace DevLog.Domain.Entities
{
    /// <summary>
    /// Активность пользователя.
    /// </summary>
    public class Activity : BaseEntity
    {
        public Guid UserId { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public ActivityType Type { get; private set; }
        public DateOnly Date { get; private set; }

        private Activity() { }

        public Activity(Guid userId, string title, ActivityType type, DateOnly date, string? description = null)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("UserId is required", nameof(userId));

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty", nameof(title));

            UserId = userId;
            Title = title;
            Type = type;
            Date = date;
            Description = description;
        }

        public void UpdateDescription(string? description)
        {
            Description = description;
        }
    }
}
