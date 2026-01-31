using DevLog.Application.Interfaces;
using DevLog.Domain.Entities;

namespace DevLog.Application.Commands.CreateActivity
{
    public class CreateActivityCommandHandler
    {
        private readonly IActivityRepository _repository;

        public CreateActivityCommandHandler(IActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateActivityCommand command, CancellationToken ct)
        {
            var activity = new Activity(
                command.UserId,
                command.Title,
                command.Type,
                command.Date,
                command.Description);

            await _repository.AddAsync(activity, ct);

            return activity.Id;
        }
    }
}
