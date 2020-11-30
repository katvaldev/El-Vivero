using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vivero.Models
{
    public class Planta
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int IDplanta { get; set; }

        [Column("Nombre_planta")]
        public string Nombreplanta { get; set; }


        [Column("Imagen_planta")]
        public string imagePlanta { get; set; }


        [Column("Precio")]
        public int precio { get; set; }




        [Column("Stock")]
        public int stock { get; set; }




    }
}