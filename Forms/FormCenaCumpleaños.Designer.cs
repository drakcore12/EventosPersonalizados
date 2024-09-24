namespace EventosPersonalizados
{
    partial class FormCenaCumpleaños
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNumeroPersonas1 = new TextBox();
            textBoxTextoTorta = new TextBox();
            textBoxCostoPersona1 = new TextBox();
            checkBoxDecoración1 = new CheckBox();
            buttonCalcular1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Total1 = new Label();
            TamañoTorta = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TamañoTorta).BeginInit();
            SuspendLayout();
            // 
            // textBoxNumeroPersonas1
            // 
            textBoxNumeroPersonas1.Location = new Point(282, 173);
            textBoxNumeroPersonas1.Name = "textBoxNumeroPersonas1";
            textBoxNumeroPersonas1.Size = new Size(125, 27);
            textBoxNumeroPersonas1.TabIndex = 0;
            // 
            // textBoxTextoTorta
            // 
            textBoxTextoTorta.Location = new Point(620, 173);
            textBoxTextoTorta.Name = "textBoxTextoTorta";
            textBoxTextoTorta.Size = new Size(125, 27);
            textBoxTextoTorta.TabIndex = 2;
            // 
            // textBoxCostoPersona1
            // 
            textBoxCostoPersona1.Location = new Point(620, 226);
            textBoxCostoPersona1.Name = "textBoxCostoPersona1";
            textBoxCostoPersona1.Size = new Size(125, 27);
            textBoxCostoPersona1.TabIndex = 3;
            // 
            // checkBoxDecoración1
            // 
            checkBoxDecoración1.AutoSize = true;
            checkBoxDecoración1.Font = new Font("Palatino Linotype", 9F);
            checkBoxDecoración1.Location = new Point(282, 278);
            checkBoxDecoración1.Name = "checkBoxDecoración1";
            checkBoxDecoración1.Size = new Size(106, 24);
            checkBoxDecoración1.TabIndex = 4;
            checkBoxDecoración1.Text = "Decoración";
            checkBoxDecoración1.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular1
            // 
            buttonCalcular1.BackColor = Color.Gold;
            buttonCalcular1.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold);
            buttonCalcular1.Location = new Point(233, 319);
            buttonCalcular1.Name = "buttonCalcular1";
            buttonCalcular1.Size = new Size(174, 48);
            buttonCalcular1.TabIndex = 5;
            buttonCalcular1.Text = "Calcular";
            buttonCalcular1.UseVisualStyleBackColor = false;
            buttonCalcular1.Click += buttonCalcular1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-187, -3);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 128);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkMagenta;
            label2.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(456, 28);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(376, 58);
            label2.TabIndex = 2;
            label2.Text = "Cena Cumpleaños";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F);
            label1.Location = new Point(131, 176);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Numero Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9F);
            label3.Location = new Point(131, 229);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 7;
            label3.Text = "Tamaño Torta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9F);
            label4.Location = new Point(469, 176);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Texto Torta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 9F);
            label5.Location = new Point(467, 229);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Costo Persona";
            // 
            // Total1
            // 
            Total1.AutoSize = true;
            Total1.BackColor = Color.BlueViolet;
            Total1.Location = new Point(482, 337);
            Total1.Name = "Total1";
            Total1.Size = new Size(0, 20);
            Total1.TabIndex = 10;
            // 
            // TamañoTorta
            // 
            TamañoTorta.Location = new Point(282, 229);
            TamañoTorta.Name = "TamañoTorta";
            TamañoTorta.Size = new Size(125, 27);
            TamañoTorta.TabIndex = 11;
            // 
            // FormCenaCumpleaños
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(899, 451);
            Controls.Add(TamañoTorta);
            Controls.Add(Total1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonCalcular1);
            Controls.Add(checkBoxDecoración1);
            Controls.Add(textBoxCostoPersona1);
            Controls.Add(textBoxTextoTorta);
            Controls.Add(textBoxNumeroPersonas1);
            Name = "FormCenaCumpleaños";
            Text = "FormCenaCumpleaños";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TamañoTorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumeroPersonas1;
        private TextBox textBoxTextoTorta;
        private TextBox textBoxCostoPersona1;
        private CheckBox checkBoxDecoración1;
        private Button buttonCalcular1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Total1;
        private NumericUpDown TamañoTorta;
    }
}