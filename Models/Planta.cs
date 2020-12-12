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
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        [Display(Name="Nombre")]
        [Required(ErrorMessage = "Por favor, ingrese el nombre de la Planta")]
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Display(Name="Imagen")]
        [Required(ErrorMessage = "Por favor, ingrese la imagen de la Planta")]
        [Column("Imagen")]
        public byte[] Imagen { get; set; }

        [NotMapped]
        public String ImageData { get; set; }

        [Display(Name="Precio")]
        [Required(ErrorMessage = "Por favor, ingrese el precio de la Planta")]
        [Column("Precio")]
        public decimal Precio { get; set; }


        [Display(Name="Stock")]
        [Required(ErrorMessage = "Por favor, ingrese stock")]
        [Column("Stock")]
        public int Stock { get; set; }


        [NotMapped]
        public string Respuesta { get; set; }   

        [Display(Name="Temperatura Inicial")]
        [Column("Temperatura Inicial")]
        public double TemperaturaAplanta { get; set; }


        [Display(Name="Temperatura Final")]
        [Column("Temperatura Final")]
        public double TemperaturaBplanta { get; set; }


        [Display(Name="Riego")]
        [Column("Riego")]
        public string Riego { get; set; }


        [Display(Name="Tips")]
        [Column("Tips")]
        public string Tips { get; set; }


        [Display(Name="Tipo de planta")]
        [ForeignKey("IDTipoPlanta")]
         public TipoPlanta TipoPlanta { get; set; }
         public int IDTipoPlanta { get; set; }

    }
}