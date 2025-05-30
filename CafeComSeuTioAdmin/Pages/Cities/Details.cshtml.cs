using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CafeComSeuTioAdmin.Data;
using CafeComSeuTioAdmin.Data.Models;

namespace CafeComSeuTioAdmin.Pages.Cities
{
    public class DetailsModel : PageModel
    {
        private readonly CafeComSeuTioAdmin.Data.CafeContext _context;

        public DetailsModel(CafeComSeuTioAdmin.Data.CafeContext context)
        {
            _context = context;
        }

        public City City { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City.FirstOrDefaultAsync(m => m.CityId == id);
            if (city == null)
            {
                return NotFound();
            }
            else
            {
                City = city;
            }
            return Page();
        }
    }
}
