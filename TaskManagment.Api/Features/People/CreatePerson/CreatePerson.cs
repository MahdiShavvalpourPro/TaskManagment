using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Api.Features.People.CreatePerson;

[ApiController]
[Route("api/people")]
public class CreatePerson : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly Validator _validator;
    public CreatePerson(IMediator mediator, Validator validator)
    {
        _mediator = mediator;
        _validator = validator;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(Command command)
    {
        var validationResult = _validator.Validate(command);
        if (validationResult is null)
        {
            return BadRequest(validationResult!.ToDictionary());
        }
        return await _mediator.Send(command);
    }
}
