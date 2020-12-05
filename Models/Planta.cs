using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Vivero.Models
{
    [Table("Planta")]
    public class Planta
    {      
        [Display(Name="id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [Key]
        public int IDplanta { get; set; }

        [Display(Name="nombre_planta")]
        [Required(ErrorMessage = "Por favor, Ingrese el nombre de la Planta")]
        [Column("nombre_planta")]
        public string Nombreplanta { get; set; }

        [Display(Name="imagen_planta")]
        [Required(ErrorMessage = "Por favor, Ingrese el imagen de la Planta")]
        [Column("imagen_planta")]
        public string imagePlanta { get; set; }

        [Display(Name="precio")]
        [Required(ErrorMessage = "Por favor, Ingrese el precio de la Planta")]
        [Column("precio")]
        public decimal precio { get; set; }


        [Display(Name="stock")]
        [Required(ErrorMessage = "Por favor, Ingrese el stock de la Planta")]
        [Column("stock")]
        public int stock { get; set; }


        [NotMapped]
        public string Respuesta { get; set; }   

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


        [ForeignKey("IDTipoplanta")]
         public TipoPlanta TipoPlanta { get; set; }
         public int IDTipoplanta { get; set; }

    }
}