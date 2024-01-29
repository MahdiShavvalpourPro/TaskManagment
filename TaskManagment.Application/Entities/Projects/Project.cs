using TaskManagement.Domain.Entities.Persons;

namespace TaskManagement.Domain.Entities.Projects;
public class Project : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public PriorityLevel PriorityLevel { get; set; }
    public Person Owner { get; set; }
    public List<Board> Boards { get; set; }

    public Project(
        string name,
        Status status,
        PriorityLevel priority,
        Person person
        )
    {
        Name = name;
        Status = status;
        PriorityLevel = priority;
        Owner = person;
        Boards = new List<Board>();
    }
}
