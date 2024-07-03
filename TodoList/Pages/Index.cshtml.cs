using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.DAL;
using TodoList.Models;

namespace TodoList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TodoDbContext _context;

        public IList<TodoItem>? Tasks { get; set; }

        public IndexModel(TodoDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Tasks = _context.Tasks.ToList();
        }

        public async Task<IActionResult> OnPostDoneAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task != null)
            {
                task.IsDone = !task.IsDone;                
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
