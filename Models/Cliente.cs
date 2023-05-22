namespace RostrosFelices.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        ICollection<User> Users { get; set; }

    }
}
