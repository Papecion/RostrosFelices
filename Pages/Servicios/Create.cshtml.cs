using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class CreateModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public CreateModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Servicio Servicio { get; set; } = default!;
        
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Servicios == null || Servicio == null)
            {
                return Page();
            }

            _context.Servicios.Add(Servicio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
