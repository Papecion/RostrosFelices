using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Data;
using RostrosFelices.Models;

namespace RostrosFelices.Pages.ServiciosRealizados
{
    
    public class IndexModel : PageModel
    {
        private readonly RostrosFelicesContext _context;

        public Dato Dato { get; set; }
        public string ErrorMessage { get; set; }

        public IndexModel(RostrosFelicesContext context)
        {
            _context = context;
        }

        public IList<Servicio> Servicios { get; set; } = default!;
        public IList<Empleado> Empleados { get; set; } = default!;
        public IList<Cliente> Clientes { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                ErrorMessage = "Debe proporcionar un nombre de producto válido.";
                return Page();
            }
            Console.WriteLine("Nombre buscado: " + nombre);
            Dato = await _context.Datos.FirstOrDefaultAsync(p => p.Codigo == nombre);

            if (Dato == null)
            {


                ErrorMessage = "No se encontró ningún producto con el nombre proporcionado.";
            }

            return Page();
        }

    }
}
