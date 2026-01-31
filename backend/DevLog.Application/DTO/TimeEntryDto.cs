namespace DevLog.Application.DTO
{
    /// <summary>
    /// DTO учёта времени.
    /// </summary>
    public class TimeEntryDto
    {
        public Guid Id { get; init; }
        public DateTime StartTime { get; init; }
        public DateTime? EndTime { get; init; }
        public TimeSpan? Duration { get; init; }
    }
}
