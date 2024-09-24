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
    public partial class FormCenaGala : Form
    {
        public FormCenaGala()
        {
            InitializeComponent();
        }

        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            // Validar que los campos estén llenos y que los valores sean numéricos
            if (!int.TryParse(textBoxNumeroPersonas2.Text, out int numeroInvitados) ||
                !double.TryParse(textBoxCostoPersona2.Text, out double costoPorPersona))
            {
                MessageBox.Show("Por favor, ingrese un número válido de personas y un costo por persona.");
                return;
            }

            CenaGala cenaGala = new CenaGala
            {
                NumeroDePersonas = numeroInvitados,
                CostoPersona = costoPorPersona,
                Decora = checkBoxDecoración2.Checked, 
                OpcionSaludable = checkBoxMenuSaludable.Checked 
            };

            try
            {
                
                double costoTotal = cenaGala.CalcularCosto();

                
                Total2.Text = costoTotal.ToString("$0.00"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular el costo: " + ex.Message);
            }
        }

        private void textBoxNumeroPersonas2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
