﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.Empleados
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public IndexModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleados { get;set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            
                Empleados = await _context.Empleados.ToListAsync();
          return Page();
        }
    }
}
