using MediatR;
using TaskManagement.Domain.Entities.Persons;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Api.Features.Projects.CreateProject
{
    public class Command : IRequest<int>
    {
        public string Name { get; set; }
        public Status Status { get; set; } = default;
        public PriorityLevel PriorityLevel { get; set; } = default;
        public Person Owner { get; set; }
        //public List<Board> Boards { get; set; }
    }
}
