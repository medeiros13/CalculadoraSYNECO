using System.Collections.Generic;

namespace CalculadoraSYNECO.Models.ViewModels
{
    public class CalculoViewModel
    {
        public Calculo Calculo { get; set; }
        public ICollection<Calculo> Calculos { get; set; }
    }
}
