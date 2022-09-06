using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages.Clients
{
    public class EditModel : PageModel
    {
        private ProductContext _context;

        [BindProperty]
        public Client Cliente { get; set; } = default!;

        public EditModel(ProductContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                NotFound();

            Cliente = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
            if (Cliente.Id == null)
                NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(Cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync(); 
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!ClienteAindaExiste(Cliente.Id))
                {
                    return NotFound();
                }
                else throw;
            }

            return RedirectToPage("./List");
        }

        private bool ClienteAindaExiste(int id)
        {
            return _context.Clients.Any(x => x.Id == id);
        }
    }
}
