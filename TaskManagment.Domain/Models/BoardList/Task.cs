using TaskManagement.Application.Models.Persons;
using TaskManagement.Application.Models.Projects;

namespace TaskManagement.Application.Models.BoardLists
{
    public class Task
    {
        public int Id { get; set; }
        public string title { get; set; }
        public Status Status { get; set; }
        public PriorityLevel Priority { get; set; }
        public Person Creator { get; set; }
    }
}