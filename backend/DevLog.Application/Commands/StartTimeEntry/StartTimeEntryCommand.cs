namespace DevLog.Application.Commands.StartTimeEntry
{
    public class StartTimeEntryCommand
    {
        public Guid ActivityId { get; init; }
        public DateTime StartTime { get; init; }
    }
}
