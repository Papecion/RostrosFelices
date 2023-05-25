namespace RostrosFelices.Models
{
    public class Dato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public int ServicioId { get;  set; }

        public ICollection<Empleado>? Empleados { get; set; } = default!;
        public ICollection<Cliente>? Clientes { get; set; } = default!;
        public ICollection<Servicio>? Servicios { get; set; } = default!;

    }
}
