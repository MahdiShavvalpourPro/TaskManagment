using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.People.RemovePerson;

public class CommandHandler : IRequestHandler<Command>
{
    private readonly TaskManagementDbContext _context;

    public CommandHandler(TaskManagementDbContext context)
    {
        _context = context;
    }

    public async Task Handle(Command request, CancellationToken cancellationToken)
    {
        var entity = await _context.Tbl_Persons
            .FindAsync(request.Id, cancellationToken) ?? throw new Exception();

        _context.Tbl_Persons.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);

    }
}
