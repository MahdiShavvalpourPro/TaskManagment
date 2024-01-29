namespace TaskManagement.Application.Models.BoardLists
{
    public class Board
    {
        public int Id { get; set; }
        public string title { get; set; }
        public List<Task> Tasks { get; set; }
    }
}