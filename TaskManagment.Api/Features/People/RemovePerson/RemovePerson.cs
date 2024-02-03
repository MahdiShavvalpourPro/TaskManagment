using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Api.Features.People.RemovePerson;

[ApiController]
[Route("api/people")]
public class RemovePerson : ControllerBase
{
    private readonly IMediator _mediator;

    public RemovePerson(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _mediator.Send(new Command() { Id = id });
        return NoContent();
    }
}
