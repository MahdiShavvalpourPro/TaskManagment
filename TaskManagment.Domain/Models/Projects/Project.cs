using TaskManagement.Application.Models.Persons;
using TaskManagement.Application.Models.BoardLists;

namespace TaskManagement.Application.Models.Projects;

public class Project
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Status Status { get; private set; } = Status.Planning;
    public PriorityLevel Priority { get; private set; } = PriorityLevel.Low;
    public Person Owner { get; private set; }
    public List<Board> Boards { get; private set; }


    public Project(
        string name,
        Person owner,
        Status status,
        PriorityLevel priorityLevel)
    {
        Name = name;
        Status = status;
        Priority = priorityLevel;
        Owner = owner;
        Boards = new List<Board>();
    }

}

public enum PriorityLevel
{
    Low,
    Medium,
    High
}

public enum Status
{
    Planning = 1,
    InProgress = 2,
    Paused = 3,
    Done = 4,
    Canceled = 5
}