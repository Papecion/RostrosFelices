namespace RostrosFelices.Models
{
    public class Dato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int ServicioId { get;  set; }
        public Servicio Servicio { get; set; }

        

    }
}
