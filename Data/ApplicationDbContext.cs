using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vivero.Models;

namespace Vivero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vivero.Models.Contacto> Contacto {get; set;}
        public DbSet<Vivero.Models.Planta> Planta { get; set; }
        public DbSet<TipoPlanta> TipoPlanta { get; set; }
        public DbSet<Plaga> Plagas { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<DetalleOrden> DetalleOrden { get; set; }
    }
}
