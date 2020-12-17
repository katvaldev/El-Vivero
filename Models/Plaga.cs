using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class Plaga
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int IDplaga { get; set; }

        
        [Column("nombreplaga")]
        public string nombrePlaga { get; set; }



        [Column("descripcion")]
        public string Descripcion { get; set; }



        [Column("imageplaga")]
        public string imageplaga { get; set; }


        [Column("adicional")]
        public string Adicional { get; set; }
        


        [NotMapped]

        public string Respuesta { get; set; }

    }
}