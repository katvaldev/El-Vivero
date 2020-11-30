using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    [Table("Planta")]
    public class Planta
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Nombre_planta")]
        public string planta { get; set; }

        [Column("Imagen_planta")]

        public string imagePlanta { get; set; }

        [Column("Precio")]
        public double precio { get; set; }

        [Column("Stock")]

        public int stock { get; set; }

        [NotMapped]

        public string Response { get; set; }


    }
}