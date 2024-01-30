using FluentValidation;
using System.Text.RegularExpressions;

namespace TaskManagement.Api.Features.People.CreatePerson;

public class Validator : AbstractValidator<Command>
{
    public Validator()
    {
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
            .WithMessage("")
            .MaximumLength(100)
            .WithMessage("email must not exceed 100 characters . ");

        RuleFor(p => p.PhoneNumber)
       .MinimumLength(11)
       .WithMessage("PhoneNumber must not be less than 11 characters.")
       .MaximumLength(11)
       .WithMessage("PhoneNumber must not exceed 11 characters.")
       .Matches(new Regex("^(\\+98|0)?9\\d{9}$"))
       .WithMessage("PhoneNumber not valid");

    }
}
