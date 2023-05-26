using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RostrosFelices.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public string Name { get; set; }
        public string Tipo { get; set; }

        public decimal Precio { get; set; }
        ICollection<User> Users { get; set; } = default!;
    }
}
