
namespace TaskManagement.Domain.Entities.Projects
{
    public class Board
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Tasks.Task> TaskList { get; set; }
    }
}