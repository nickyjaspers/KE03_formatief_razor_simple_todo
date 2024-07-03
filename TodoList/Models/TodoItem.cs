using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoItem
    {        
        public int Id { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsDone { get; set; }
    }
}
