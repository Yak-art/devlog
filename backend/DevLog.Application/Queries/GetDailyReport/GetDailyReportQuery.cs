namespace DevLog.Application.Queries.GetDailyReport
{
    public class GetDailyReportQuery
    {
        public Guid UserId { get; init; }
        public DateOnly Date { get; init; }
    }
}
