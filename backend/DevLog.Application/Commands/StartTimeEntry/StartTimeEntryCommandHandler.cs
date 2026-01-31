using DevLog.Application.Interfaces;
using DevLog.Domain.Entities;

namespace DevLog.Application.Commands.StartTimeEntry
{
    public class StartTimeEntryCommandHandler
    {
        private readonly ITimeEntryRepository _repository;

        public StartTimeEntryCommandHandler(ITimeEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(StartTimeEntryCommand command, CancellationToken ct)
        {
            var activeEntry = 
                await _repository.GetActiveByActivityIdAsync(command.ActivityId, ct);

            if (activeEntry != null)
                throw new InvalidOperationException("Activity already has active time entry");

            var entry = new TimeEntry(command.ActivityId, command.StartTime);

            await _repository.AddAsync(entry, ct);

            return entry.Id;
        }
    }
}
