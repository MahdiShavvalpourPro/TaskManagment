using MediatR;

namespace TaskManagement.Api.Features.People.UpdatePerson;

public class Command : IRequest
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
