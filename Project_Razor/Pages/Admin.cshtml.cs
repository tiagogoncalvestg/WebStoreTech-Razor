using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

            var admin = _context.Admins.Where(x => x.Nome == Admin.Nome).Where(x => x.Senha == Admin.Senha);
            if (admin != null)
            {
                return RedirectToPage("/Clients/List");
            }

            return Page();
        }
    }
}
