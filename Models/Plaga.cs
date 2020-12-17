using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{

    [Table("Plaga")]
    public class Plaga
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IDplaga")]
        public int IDplaga { get; set; }



        [Column("Descripcion")]
        public string Descripcion { get; set; }



        [Column("nombrePlaga")]
        public string nombrePlaga { get; set; }



        [Column("Adicional")]
        public string Adicional { get; set; }


        [Column("imageplaga")]
        public string imageplaga { get; set; }


        
        


        [NotMapped]
        public string Respuesta { get; set; }

    }
}