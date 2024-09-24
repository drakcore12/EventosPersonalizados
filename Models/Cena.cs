using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPersonalizados.Models
{
    public abstract class Cena
    {
        public int NumeroDePersonas { get; set; }
        public double CostoDecoracion { get; set; }
        public double BonoExtra { get; set; }
        public double CostoPersona { get; set; }
        public bool Decora { get; set; } = true;

        public abstract double CalcularCostoDecoracion();
        public abstract double CalcularCosto();
    }
}
