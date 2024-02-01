using MediatR;
using TaskManagement.Domain.Entities.Persons;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.People.CreatePerson
{
    public class CreatePost : IRequestHandler<Command, int>
    {
        private readonly TaskManagementDbContext _context;
        public CreatePost(TaskManagementDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            var person = new Person(
                request.FirstName!,
                request.LastName!,
                request.Email,
                request.PhoneNumber!);

            await _context.Tbl_Persons.AddAsync(person);
            await _context.SaveChangesAsync();

            return person.Id;
        }
    }

}
