﻿namespace RostrosFelices.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }

        ICollection<User> Users { get; set; } = default!; 

	}
}
