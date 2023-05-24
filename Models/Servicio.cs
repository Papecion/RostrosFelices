namespace RostrosFelices.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Name { get; set; }
        public string Tipo { get; set; } 
        public string Precio { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }

        public Cliente Cliente { get; set;} = default!;
		public Empleado Empleado { get; set;} = default!;

	}
}
