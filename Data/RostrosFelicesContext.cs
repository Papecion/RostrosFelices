using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using RostrosFelices.Models;
using System.Collections.Generic;

namespace RostrosFelices.Data
{
    public class RostrosFelicesContext: DbContext
    {
        public RostrosFelicesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Dato> Datos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
