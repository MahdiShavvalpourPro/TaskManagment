using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Api.Features.People.UpdatePerson;

[ApiController]
[Route("api/people")]
public class UpdatePerson : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly Validator _validator;
    public UpdatePerson(IMediator mediator, Validator validator)
    {
        _mediator = mediator;
        _validator = validator;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Command command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        var validationResult = _validator.Validate(command);
        if (validationResult is null)
        {
            return BadRequest(validationResult!.ToDictionary());
        }

        await _mediator.Send(command);

        return NoContent();
    }

}
