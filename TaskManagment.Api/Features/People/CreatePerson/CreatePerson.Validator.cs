using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TaskManagement.Infrastructure;

namespace TaskManagement.Api.Features.People.CreatePerson;

public class Validator : AbstractValidator<Command>
{
    private readonly TaskManagementDbContext _context;

    public Validator(TaskManagementDbContext context)
    {
        _context = context;

        RuleFor(x => x.FirstName)
           .MaximumLength(50)
           .WithMessage("first name must not exceed 50 characters.");

        RuleFor(x => x.LastName)
           .MaximumLength(50)
           .WithMessage("last name must not exceed 50 characters.");

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email Is Required")
            .EmailAddress()
            .WithMessage("this email is not valid")
            .MaximumLength(100)
            .WithMessage("email must not exceed 100 characters . ")
            .MustAsync(BeUniqueEmail)
            .WithMessage("this email already exists.");

        RuleFor(p => p.PhoneNumber)
       .MinimumLength(11)
       .WithMessage("PhoneNumber must not be less than 11 characters.")
       .MaximumLength(11)
       .WithMessage("PhoneNumber must not exceed 11 characters.")
       .Matches(new Regex("^(\\+98|0)?9\\d{9}$"))
       .WithMessage("PhoneNumber not valid")
       .MustAsync(BeUniqueMobileNumber)
       .WithMessage("this phone number already exists.");
    }

    private Task<bool> BeUniqueMobileNumber(string phoneNumber,
        CancellationToken cancellationToken)
    {
        return _context.Tbl_Persons
            .AllAsync(x => x.PhoneNumber != phoneNumber, cancellationToken);
    }

    private Task<bool> BeUniqueEmail(string email,
        CancellationToken cancellationToken)
    {
        return _context.Tbl_Persons
            .AllAsync(x => x.Email != email, cancellationToken);

    }
}
