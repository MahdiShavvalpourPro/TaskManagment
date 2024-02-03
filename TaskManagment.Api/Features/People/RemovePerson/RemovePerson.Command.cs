using MediatR;

namespace TaskManagement.Api.Features.People.RemovePerson;
public class Command : IRequest
{
    public int Id { get; set; }
}
