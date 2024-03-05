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
    public class DetailsModel : PageModel
    {
        private readonly ASP_NET_Core_App.Data.AppDbContext _context;

        public DetailsModel(ASP_NET_Core_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public Models.Staff Staff { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }
            else
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
