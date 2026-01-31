namespace DevLog.Application.Commands.StopTimeEntry
{
    public class StopTimeEntryCommand
    {
        public Guid ActivityId { get; init; }
        public DateTime EndTime { get; init; }
    }
}
