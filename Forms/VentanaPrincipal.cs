namespace EventosPersonalizados
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCenaCumplea�os_Click(object sender, EventArgs e)
        {
            FormCenaCumplea�os formCenaCumpleA�os = new FormCenaCumplea�os();

            formCenaCumpleA�os.ShowDialog();
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
