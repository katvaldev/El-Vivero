using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class Orden
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Name="Total")]

        [Column("Total")]
        public decimal Total { get; set; }


        [Display(Name="Producto")]
        [Column("Producto")]
        public string Producto { get; set; }

        [Display(Name="Correo")]
        [Column("Correo")]
        public string Usuario { get; set; }

        [Display(Name="Tipo de planta")]
        [ForeignKey("PlantaID")]
        public int PlantaID { get; set; }

        [Display(Name="Cantidad")]
        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name="Precio Unitario")]

        [Column("PrecioUnit")]
        public decimal Preciounit { get; set; }

    }
}