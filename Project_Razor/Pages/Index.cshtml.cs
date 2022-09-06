using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project_Razor.Data;
using Project_Razor.Models;

namespace Project_Razor.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        private readonly ProductContext _context;

        public IList<Product> Produtos { get; set; }

        public IndexModel(ProductContext context)
        {
            _context = context;
            //_logger = logger;
        }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Products.ToListAsync();
        }
    }
}