using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities.Persons;
using TaskManagement.Domain.Entities.Projects;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.Projects.CreateProject;

public class CommandHandler : IRequestHandler<Command, int>
{
    private readonly TaskManagementDbContext _context;
    public CommandHandler(TaskManagementDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(Command request, CancellationToken cancellationToken)
    {
        var entity = new Project(request.Name,
            request.Status,
            request.PriorityLevel,
            request.Owner);

        if (OwnerIsExists(entity.Owner) is null)
        {
            return 0;
        }

        await _context.Tbl_Projects.AddAsync(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }


    private async Task<bool> OwnerIsExists(Person owner)
    {
        return await _context.Tbl_Projects
            .AnyAsync(p => p.Owner == owner);
    }

}
