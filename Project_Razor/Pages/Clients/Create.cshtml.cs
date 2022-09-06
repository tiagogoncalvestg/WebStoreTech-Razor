using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private ProductContext _context;

        [BindProperty]
        public Client Cliente { get; set; } = default!;

        public CreateModel(ProductContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cliente = new Client();
            if (await TryUpdateModelAsync<Client>(cliente, "cliente", obj => obj.Nome,
                obj => obj.DataNascimento, obj => obj.CPF, obj => obj.Email))
            {
                _context.AddAsync(Cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./List");
            }
            return Page();


        }
    }
}

