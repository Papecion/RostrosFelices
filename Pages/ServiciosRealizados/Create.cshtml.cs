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

        public IEnumerable <SelectListItem> Servicios { get; set; }

        public IEnumerable<SelectListItem> Clientes { get; set; }
        public IEnumerable<SelectListItem> Empleados { get; set; }


        public IActionResult OnGet()
        {
            Clientes = _context.Clientes
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nombre
                });

            Empleados = _context.Empleados
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Nombre
                });
            Servicios = _context.Servicios
             .Select(e => new SelectListItem
             {
                 Value = e.Id.ToString(),
                 Text = e.Name
             });

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
           
                if (!ModelState.IsValid || _context.Datos == null || Dato == null)
                {
                    Clientes = _context.Clientes
                        .Select(c => new SelectListItem
                        {
                            Value = c.Id.ToString(),
                            Text = c.Nombre
                        });

                    Empleados = _context.Empleados
                        .Select(e => new SelectListItem
                        {
                            Value = e.Id.ToString(),
                            Text = e.Nombre
                        });
                    Servicios = _context.Servicios
                       .Select(e => new SelectListItem
                       {
                           Value = e.Id.ToString(),
                           Text = e.Name
                       });

                    return Page();
                }
            _context.Datos.Add(Dato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
