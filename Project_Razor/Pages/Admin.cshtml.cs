using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages
{
    public class AdminModel : PageModel
    {
        private readonly ProductContext _context;

        public AdminModel(ProductContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Admin Admin { get; set; } = default!;

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Products == null || Admin == null)
            {
                return Page();
            }

            var admin = await _context.Admins.Where(x => x.Nome == Admin.Nome && x.Senha == Admin.Senha).ToListAsync();
            if (admin.Count > 0)
            {
                return RedirectToPage("/Clients/List");
            }
            else
            {
                return RedirectToPage("./AdminError");
            }

            return Page();
        }
    }
}
