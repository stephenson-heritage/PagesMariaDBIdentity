using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagesMariaDB.Models;

namespace PagesMariaDB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StoreContext _context;

        public IndexModel(ILogger<IndexModel> logger, StoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            var products = from product in _context.Products select product;
            Products = await products.ToListAsync();
        }
    }
}
