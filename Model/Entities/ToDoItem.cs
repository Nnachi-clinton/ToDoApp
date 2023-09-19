
namespace Model.Entities
{
    public class ToDoItem
    {

        public string? Task { get; set; }
        public int Id { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
