using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class DetalleOrden
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }  

        [Display(Name="Tipo de planta")]
        [ForeignKey("OrdenID")]
        public int OrdenID { get; set; }

        [Display(Name="Tipo de planta")]
        [ForeignKey("PlantaID")]
        public int PlantaID { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("PrecioUnit")]
        public double Preciounit { get; set; }

        [NotMapped]
        public double SubTotal { get; set; }
    }
}