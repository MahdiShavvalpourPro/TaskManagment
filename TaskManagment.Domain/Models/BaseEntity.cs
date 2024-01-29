namespace TaskManagement.Application.Models
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}