using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class Planta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int IDplanta { get; set; }

        [Display(Name="Nombre")]

        [Column("Nombre_planta")]
        public string Nombreplanta { get; set; }

        [Display(Name="Imagen")]

        [Column("Imagen_planta")]

        public string imagePlanta { get; set; }

        [Column("Precio")]
        public double precio { get; set; }

        [Column("Stock")]

        public int stock { get; set; }

        [ForeignKey("IdTipo")]
         public TipoPlanta TipoPlanta { get; set; }
         public int IdTipo { get; set; }

        [NotMapped]

        public string Respuesta { get; set; }


    }
}