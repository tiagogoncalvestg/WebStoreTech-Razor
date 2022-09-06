using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project_Razor.Models;

namespace Project_Razor.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Project_Razor.Data.ProductContext _context;

        public CreateModel(Project_Razor.Data.ProductContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Products == null || Product == null)
            {
                return Page();
            }

            _context.Products.AddAsync(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
