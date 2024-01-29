using MediatR;

namespace TaskManagement.Api.Features.People.CreatePerson;
public class Command : IRequest<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }

}
