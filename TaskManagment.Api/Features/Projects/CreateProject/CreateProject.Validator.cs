using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities.Persons;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.Projects.CreateProject;

public class Validator : AbstractValidator<Command>
{
    private readonly TaskManagementDbContext _context;
    public Validator(TaskManagementDbContext context)
    {
        _context = context;

        RuleFor(prj => prj.Name)
            .NotEmpty()
            .WithMessage("Name Is Required")
            .MaximumLength(100)
            .WithMessage("name must not exceed 100 characters . ");
    }

    //private async Task<bool> OwnerIsExists(Person owner)
    //{
    //    return await _context.Tbl_Projects
    //        .AnyAsync(p => p.Owner == owner);
    //}

}
