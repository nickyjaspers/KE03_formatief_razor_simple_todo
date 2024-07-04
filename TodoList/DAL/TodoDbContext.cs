using Microsoft.EntityFrameworkCore;

/*
 * In deze namespace bevinden zich de data access classes om de modellen te vullen en vervolgens te gebruiken
 * in de applicatie. (bijv in de specifieke pagemodels)
 */
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
