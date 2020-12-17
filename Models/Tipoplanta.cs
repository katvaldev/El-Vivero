using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class TipoPlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Tipo")]
        public string Nombre { get; set; }

        [NotMapped]
        public ICollection<Planta> Plantas { get; set; }

        public TipoPlanta()
        {
            Plantas = new List<Planta>();
        }
    }
}