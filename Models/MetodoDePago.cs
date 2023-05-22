namespace RostrosFelices.Models
{
    public class MetodoDePago
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Method { get; set; }

        public ICollection<Servicio>? Servicios { get; set; } = default!;
    }
}
