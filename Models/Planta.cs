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


        [Display(Name="Precio")]
        [Column("Precio")]
        public double precio { get; set; }


        [Display(Name="Stock")]
        [Column("Stock")]
        public int stock { get; set; }


        [Display(Name="Temperatura Inicial")]
        [Column("TemperaturaA_planta")]
        public double TemperaturaAplanta { get; set; }


        [Display(Name="Temperatura Final")]
        [Column("TemperaturaB_planta")]
        public double TemperaturaBplanta { get; set; }


        [Display(Name="Riego")]
        [Column("Riego_planta")]
        public string riegoPlanta { get; set; }


        [Display(Name="Tips")]
        [Column("Tips_planta")]
        public string tipsPlanta { get; set; }


        [ForeignKey("IdTipo")]
         public TipoPlanta TipoPlanta { get; set; }
         public int IdTipo { get; set; }

        [NotMapped]

        public string Respuesta { get; set; }


    }
}