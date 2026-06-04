using System.ComponentModel.DataAnnotations;

namespace task8.Data
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}