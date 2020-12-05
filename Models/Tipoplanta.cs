
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models

{
    [Table("TipoPlanta")]
    public class TipoPlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Tipo")]
        public string Nombre { get; set; }

        // [ForeignKey("IDTipoPlanta")]
        public ICollection<Planta> Plantas { get; set; }

    }
    
}