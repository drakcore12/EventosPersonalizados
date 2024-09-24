namespace EventosPersonalizados
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCenaCumpleaños_Click(object sender, EventArgs e)
        {
            FormCenaCumpleaños formCenaCumpleAños = new FormCenaCumpleaños();

            formCenaCumpleAños.ShowDialog();
        }
        private void buttonCenaGala_Click(object sender, EventArgs e)
        {
            FormCenaGala formCenaGala = new FormCenaGala();

            formCenaGala.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
