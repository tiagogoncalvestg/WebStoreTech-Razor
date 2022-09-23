using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages.Clients
{
    public class ListModel : PageModel
    {
        private readonly ProductContext _context;

        public IList<Client> Clientes { get; set; }

        public ListModel(ProductContext context)
        {
            _context = context;
        }

        // Método carregado sempre que a página é chamada
        public async Task OnGetAsync()
        {
            Clientes = await _context.Clients.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(string? id)
        {
            if (id == null)
                return NotFound();

            var cliente = await _context.Clients.FirstOrDefaultAsync(c => c.Id == id);

            if(cliente != null)
            {
                _context.Clients.Remove(cliente);
                await _context.SaveChangesAsync();
            }

            return Page();
        }
    }
}
