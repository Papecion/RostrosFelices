using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.ServiciosRealizados
{
    
    public class CreateModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public CreateModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dato Dato { get; set; }

        public SelectList Servicios { get; set; }
        public SelectList Clientes { get; set; }
        public SelectList Empleados { get; set; }

        public IActionResult OnGet()
        {
            Clientes = new SelectList(_context.Clientes, "Id", "Nombre");
            Empleados = new SelectList(_context.Empleados, "Id", "Nombre");
            Servicios = new SelectList(_context.Servicios, "Id", "Nombre");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Clientes = new SelectList(_context.Clientes, "Id", "Nombre");
                Empleados = new SelectList(_context.Empleados, "Id", "Nombre");
                Servicios = new SelectList(_context.Servicios, "Id", "Nombre");

                return Page();
            }

            _context.Datos.Add(Dato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
