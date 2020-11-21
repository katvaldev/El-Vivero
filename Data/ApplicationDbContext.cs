using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vivero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // public DbSet<Vivero.Models.Carrito> Carrito { get; set; }

        // public DbSet<Vivero.Models.Plaga> Plaga { get; set; }

        // public DbSet<Vivero.Models.Planta> Planta { get; set; }
    }
}
