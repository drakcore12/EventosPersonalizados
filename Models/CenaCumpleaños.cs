using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPersonalizados.Models
{
    public class CenaCumpleaños : Cena
    {
        public double TamanoTorta { get; set; }
        public string TextoTorta { get; set; } = "";

        public override double CalcularCostoDecoracion()
        {
            double costoBase = 50 + TamanoTorta * 10;
            double costoAdicional = Decora ? 100 : 0;

            return costoBase + costoAdicional;
        }

        public override double CalcularCosto()
        {

            if (TamanoTorta < 1 || TamanoTorta > 5)
                throw new ArgumentException("Tamaño de pastel inválido.");

            if (TextoTorta.Length > 30)
                throw new ArgumentException("Texto del pastel demasiado largo.");

            double costoPastel = TamanoTorta * 50;
            double costoDecoracion = CalcularCostoDecoracion();
            double costoTotal = costoDecoracion + costoPastel + BonoExtra; // No se incluye costoComida

            // Validaciones adicionales (Reglas 1, 4, 9)
            if (NumeroDePersonas < 1 || NumeroDePersonas > 500)
                throw new ArgumentException("Número de personas inválido.");

            if (costoTotal < 100)
                throw new InvalidOperationException("El costo total debe ser al menos de $100.");

            return costoTotal;
        }
    }
}
