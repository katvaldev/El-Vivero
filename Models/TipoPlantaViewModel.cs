using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vivero.Models
{
    public class TipoPlantaViewModel
    {
        [Display(Name="Tipo de planta")]
        public string ID { get; set; }
        public List<SelectListItem> ListaTipoPlanta { get; set; }
    }
}