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
    public class IndexModel : PageModel
    {
        private readonly RostrosFelices.Data.RostrosFelicesContext _context;

        public IndexModel(RostrosFelices.Data.RostrosFelicesContext context)
        {
            _context = context;
        }

        public IList<Servicio> Servicio { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Servicios != null)
            {
                Servicio = await _context.Servicios.ToListAsync();
            }
        }
    }
}
