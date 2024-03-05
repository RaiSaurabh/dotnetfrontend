using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET_Core_App.Data;
using ASP_NET_Core_App.Models;

namespace ASP_NET_Core_App.Pages.Staff
{
    public class IndexModel : PageModel
    {
        private readonly ASP_NET_Core_App.Data.AppDbContext _context;

        public IndexModel(ASP_NET_Core_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Models.Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
