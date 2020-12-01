using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vivero.Models
{

        [Table("Planta")]
    public class Planta
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int IDplanta { get; set; }

        [Column("nombre_planta")]
        public string Nombreplanta { get; set; }


        [Column("imagen_planta")]
        public string imagePlanta { get; set; }


        [Column("precio")]
        public int precio { get; set; }




        [Column("stock")]
        public int stock { get; set; }




    }
}