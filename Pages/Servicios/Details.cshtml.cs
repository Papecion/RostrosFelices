using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Servicios
{
    public class DetailsModel : PageModel
    {
        private readonly RostrosFelices.Data.RostrosFelicesContext _context;

        public DetailsModel(RostrosFelices.Data.RostrosFelicesContext context)
        {
            _context = context;
        }

      public Servicio Servicio { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Servicios == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios.FirstOrDefaultAsync(m => m.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }
            else 
            {
                Servicio = servicio;
            }
            return Page();
        }
    }
}
