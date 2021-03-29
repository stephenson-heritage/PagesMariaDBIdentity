using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<WebUser> _userManager;


        public IndexModel(ILogger<IndexModel> logger, StoreContext context, UserManager<WebUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IList<Product> Products { get; set; }
        public WebUser WebUser { get; set; }


        public async Task OnGetAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                WebUser = await _userManager.GetUserAsync(User);
            }
            var products = from product in _context.Products select product;
            Products = await products.ToListAsync();
        }
    }
}
