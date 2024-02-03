using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Api.Features.Projects.CreateProject;

[ApiController]
[Route("api/projects")]
public class CreateProject : ControllerBase
{
    private readonly IMediator _mediator;

    public CreateProject(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(Command command)
    {
        return await _mediator.Send(command);
    }
}
