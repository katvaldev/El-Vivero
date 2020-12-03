
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vivero.Models;

namespace El_Vivero.Models

{
    public class Tipoplanta
    {
        public int IDTipoplanta { get; set; }


        public string Tipo  { get; set; }

        public ICollection<Planta> Plantas { get; set; }

    }
}