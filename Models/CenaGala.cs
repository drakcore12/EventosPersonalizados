using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPersonalizados.Models
{
    public class CenaGala : Cena
    {
        public bool OpcionSaludable { get; set; }

        public override double CalcularCostoDecoracion()
        {
            double costoBase = 500;
            return NumeroDePersonas > 100 ? NumeroDePersonas * 15 + costoBase : NumeroDePersonas * 15;
        }

        public override double CalcularCosto()
        {
            // Validaciones según reglas 1, 3 y 7
            if (NumeroDePersonas < 1 || NumeroDePersonas > 500)
                throw new ArgumentException("Número de personas inválido.");

            if (CostoPersona < 10 || CostoPersona > 500)
                throw new ArgumentException("Costo promedio por persona inválido.");

            if (OpcionSaludable && CostoPersona <= 50)
                throw new InvalidOperationException("Opción saludable no disponible para un costo menor de 50.");

            // Cálculos
            double costoComida = NumeroDePersonas * CostoPersona;
            double costoDecoracion = CalcularCostoDecoracion();
            double costoAdicionalSaludable = OpcionSaludable ? NumeroDePersonas * 5 : 0;
            double costoTotal = costoComida + costoDecoracion + costoAdicionalSaludable + BonoExtra;

            // Validación según regla 9
            if (costoTotal < 100)
                throw new InvalidOperationException("El costo total debe ser al menos de $100.");
                costoTotal = 100;

            return costoTotal;
        }

        // Método para establecer la opción saludable con validación
        public void SetOpcionSaludable(bool valor)
        {
            if (valor && CostoPersona <= 50)
                throw new InvalidOperationException("Opción saludable no disponible para un costo menor de 50.");
            OpcionSaludable = valor;
        }
    }
}
