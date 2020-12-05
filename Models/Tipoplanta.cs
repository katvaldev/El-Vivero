
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models

{
    [Table("Tipoplanta")]
    public class TipoPlanta
    {
        [Key]
        public int IDTipoplanta { get; set; }


        public string Tipo  { get; set; }

        public ICollection<Planta> Plantas { get; set; }

    }
}