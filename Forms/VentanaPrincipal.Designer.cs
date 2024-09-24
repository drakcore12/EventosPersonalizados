namespace EventosPersonalizados
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCenaGala = new Button();
            buttonCenaCumpleaños = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCenaGala
            // 
            buttonCenaGala.BackColor = Color.Gold;
            buttonCenaGala.ForeColor = Color.Black;
            buttonCenaGala.Location = new Point(302, 175);
            buttonCenaGala.Margin = new Padding(6);
            buttonCenaGala.Name = "buttonCenaGala";
            buttonCenaGala.Size = new Size(296, 55);
            buttonCenaGala.TabIndex = 0;
            buttonCenaGala.Text = "Cena Gala";
            buttonCenaGala.UseVisualStyleBackColor = false;
            buttonCenaGala.Click += buttonCenaGala_Click;
            // 
            // buttonCenaCumpleaños
            // 
            buttonCenaCumpleaños.BackColor = Color.Gold;
            buttonCenaCumpleaños.ForeColor = Color.Black;
            buttonCenaCumpleaños.Location = new Point(302, 276);
            buttonCenaCumpleaños.Margin = new Padding(6);
            buttonCenaCumpleaños.Name = "buttonCenaCumpleaños";
            buttonCenaCumpleaños.Size = new Size(296, 55);
            buttonCenaCumpleaños.TabIndex = 1;
            buttonCenaCumpleaños.Text = "Cena Cumpleaños";
            buttonCenaCumpleaños.UseVisualStyleBackColor = false;
            buttonCenaCumpleaños.Click += buttonCenaCumpleaños_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(241, 46);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(492, 58);
            label1.TabIndex = 2;
            label1.Text = "Eventos Personalizados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-28, -25);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 128);
            panel1.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(899, 451);
            Controls.Add(panel1);
            Controls.Add(buttonCenaCumpleaños);
            Controls.Add(buttonCenaGala);
            Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "VentanaPrincipal";
            Text = "Form1";
            Load += VentanaPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCenaGala;
        private Button buttonCenaCumpleaños;
        private Label label1;
        private Panel panel1;
    }
}
