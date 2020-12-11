using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vivero.Models
{
    public class TipoPlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Tipo")]
        public string Nombre { get; set; }

        // [ForeignKey("IdTipo")]
        public ICollection<Planta> Plantas { get; set; }

    }
}