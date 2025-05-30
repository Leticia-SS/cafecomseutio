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
    public class IndexModel : PageModel
    {
        private readonly CafeComSeuTioAdmin.Data.CafeContext _context;

        public IndexModel(CafeComSeuTioAdmin.Data.CafeContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;

        public async Task OnGetAsync()
        {
            City = await _context.City
                .Include(c => c.Country).ToListAsync();
        }
    }
}
