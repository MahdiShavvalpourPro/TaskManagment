using MediatR;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.People.UpdatePerson
{
    public class CommandHandler : IRequestHandler<Command>
    {
        private readonly TaskManagementDbContext _context;

        public CommandHandler(TaskManagementDbContext context)
        {
            _context = context;
        }

        public async Task Handle(
            Command request, CancellationToken cancellationToken)
        {
            var person = await _context
                 .Tbl_Persons
                 .FindAsync(new object[] { request.Id }, cancellationToken)
                 .ConfigureAwait(false)
                 ?? throw new Exception(nameof(CommandHandler));

            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.Email = request.Email;
            person.PhoneNumber = request.PhoneNumber;

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
