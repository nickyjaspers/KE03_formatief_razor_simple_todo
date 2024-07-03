using Microsoft.EntityFrameworkCore;

namespace TodoList.DAL
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<TodoList.Models.TodoItem> Tasks => Set<Models.TodoItem>();
    }
}
