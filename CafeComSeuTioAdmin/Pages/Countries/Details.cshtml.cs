using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CafeComSeuTioAdmin.Data;
using CafeComSeuTioAdmin.Data.Models;

namespace CafeComSeuTioAdmin.Pages.Countries
{
    public class DetailsModel : PageModel
    {
        private readonly CafeComSeuTioAdmin.Data.CafeContext _context;

        public DetailsModel(CafeComSeuTioAdmin.Data.CafeContext context)
        {
            _context = context;
        }

        public Country Country { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = await _context.Countries.FirstOrDefaultAsync(m => m.CountryId == id);
            if (country == null)
            {
                return NotFound();
            }
            else
            {
                Country = country;
            }
            return Page();
        }
    }
}
