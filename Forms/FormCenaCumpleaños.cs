using EventosPersonalizados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosPersonalizados
{
    public partial class FormCenaCumpleaños : Form
    {
        public FormCenaCumpleaños()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular1_Click(object sender, EventArgs e)
        {
            // Validar que los campos estén llenos y que los valores sean numéricos
            if (!int.TryParse(textBoxNumeroPersonas1.Text, out int numeroInvitados) ||
                !double.TryParse(textBoxCostoPersona1.Text, out double costoPorPersona))
            {
                MessageBox.Show("Por favor, ingrese un número válido de personas y un costo por persona.");
                return;
            }

            CenaCumpleaños cenaCumpleaños = new CenaCumpleaños
            {
                NumeroDePersonas = numeroInvitados,
                CostoPersona = costoPorPersona,
                Decora = checkBoxDecoración1.Checked,
                TextoTorta = textBoxTextoTorta.Text,
                TamanoTorta = (double)TamañoTorta.Value
            };

            try
            {
                // Realizar los cálculos
                double costoTotal = cenaCumpleaños.CalcularCosto();

                // Mostrar el resultado en el label con formato de moneda personalizado
                Total1.Text = costoTotal.ToString("$0.00"); // Formato de dólar con dos decimales
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular el costo: " + ex.Message);
            }
        }
    }
}
