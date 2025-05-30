using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CafeComSeuTioAdmin.Data;
using CafeComSeuTioAdmin.Data.Models;

namespace CafeComSeuTioAdmin.Pages.Countries
{
    public class CreateModel : PageModel
    {
        private readonly CafeComSeuTioAdmin.Data.CafeContext _context;

        public CreateModel(CafeComSeuTioAdmin.Data.CafeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Countries.Add(Country);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
