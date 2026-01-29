namespace DevLog.Domain.Entities
{
    /// <summary>
    /// Запись учёта времени.
    /// </summary>
    public class TimeEntry : BaseEntity
    {
        public Guid ActivityId { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }

        public TimeSpan? Duration =>
            EndTime.HasValue ? EndTime.Value - StartTime : null;

        private TimeEntry() { }

        public TimeEntry(Guid activityId, DateTime startTime)
        {
            if (activityId == Guid.Empty)
                throw new ArgumentException("ActivityId is required", nameof(activityId));

            ActivityId = activityId;
            StartTime = startTime;
        }

        public void Stop(DateTime endTime)
        {
            if (EndTime.HasValue)
                throw new InvalidOperationException("Time entry already stopped");

            if (endTime < StartTime)
                throw new ArgumentException("EndTime cannot be earlier than StartTime");

            EndTime = endTime;
        }
    }
}
