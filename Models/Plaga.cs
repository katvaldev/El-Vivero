using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vivero.Models
{

    [Table("Plaga")]
    public class Plaga
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }


        [Column("nombreplaga")]
        public string nombreplaga { get; set; }


        [Column("descripcion")]
        public string descripcion { get; set; }



        [Column("adicional")]
        public string adicional { get; set; }


        [NotMapped]
        public string Respuesta { get; set; }



    }
}