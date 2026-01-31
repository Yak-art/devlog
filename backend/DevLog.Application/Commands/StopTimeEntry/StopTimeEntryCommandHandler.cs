using DevLog.Application.Interfaces;

namespace DevLog.Application.Commands.StopTimeEntry
{
    public class StopTimeEntryCommandHandler
    {
        private readonly ITimeEntryRepository _repository;

        public StopTimeEntryCommandHandler(ITimeEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(StopTimeEntryCommand command, CancellationToken ct)
        {
            var entry =
                await _repository.GetActiveByActivityIdAsync(command.ActivityId, ct)
                ?? throw new InvalidOperationException("Active time entry not found");

            entry.Stop(command.EndTime);

            await _repository.UpdateAsync(entry, ct);
        }
    }
}
