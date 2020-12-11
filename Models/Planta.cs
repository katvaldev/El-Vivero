using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vivero.Models
{
    [Table("Planta")]
    public class Planta
    {      
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        [Key]
        public int IDplanta { get; set; }

        [Display(Name="Nombre")]
        [Required(ErrorMessage = "Por favor, ingrese el nombre de la Planta")]
        [Column("nombre_planta")]
        public string Nombreplanta { get; set; }

        [Display(Name="Imagen")]
        [Required(ErrorMessage = "Por favor, ingrese la imagen de la Planta")]
        [Column("imagen_planta")]
        public string imagePlanta { get; set; }

        [Display(Name="Precio")]
        [Required(ErrorMessage = "Por favor, ingrese el precio de la Planta")]
        [Column("precio")]
        public decimal precio { get; set; }


        [Display(Name="Stock")]
        [Required(ErrorMessage = "Por favor, ingrese el stock de la Planta")]
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


        [Display(Name="Tipo de planta")]
        [ForeignKey("IDTipoPlanta")]
         public TipoPlanta TipoPlanta { get; set; }
         public int IDTipoPlanta { get; set; }

    }
}