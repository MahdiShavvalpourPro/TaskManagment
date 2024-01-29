using FluentValidation;

namespace TaskManagement.Api.Features.People.CreatePerson;

public class Validator : AbstractValidator<Command>
{
    public Validator()
    {
        RuleFor(x => x.FirstName)
            .MaximumLength(50)
            .WithMessage("");

    }
}
