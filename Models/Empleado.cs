namespace RostrosFelices.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Cargo { get; set; }
        ICollection<User> Users { get; set; } = default!; 
    }
}
