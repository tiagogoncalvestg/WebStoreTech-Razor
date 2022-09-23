using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly ProductContext _context;

        public DeleteModel(ProductContext context)
        {
            _context = context;
        }

        public Client Cliente { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clients.FirstOrDefaultAsync(c => c.Id.Equals(id));
            if (cliente == null)
                return NotFound();
            else
                Cliente = cliente;

            return Page();
        }

    }
}
