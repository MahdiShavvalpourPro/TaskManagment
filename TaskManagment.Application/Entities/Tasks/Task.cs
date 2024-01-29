namespace TaskManagement.Domain.Entities.Tasks;
public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public PriorityLevel PriorityLevel { get; set; }
    public string Description { get; set; }
}
