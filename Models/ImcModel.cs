using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImcBlazorWasm.Models
{
    public class ImcModel
    {
        [Required(ErrorMessage = "Informe a altura")]
        [Range(1, 3, ErrorMessage = "Altura inválida")]
        public double? Height {get;set;}
        
        [Required(ErrorMessage = "Informe o peso")]
        [Range(15, 180, ErrorMessage = "peso inválido")]
        public double? Weight {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public double Imc => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1));

    }
}