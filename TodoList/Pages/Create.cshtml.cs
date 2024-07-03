using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoList.DAL;

namespace TodoList.Pages
{
    public class CreateModel : PageModel
    {
        private readonly TodoDbContext _context;
        public CreateModel(TodoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TodoList.Models.TodoItem? TodoItem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (TodoItem != null)
            {
                _context.Tasks.Add(TodoItem);
            }            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }   
    }
}
