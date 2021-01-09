using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class Orden
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Fecha")]
        public DateTime Fecha { get; set; }

        [NotMapped]
        public double Total { get; set; }

    }
}