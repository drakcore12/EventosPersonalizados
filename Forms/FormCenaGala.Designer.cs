namespace EventosPersonalizados
{
    partial class FormCenaGala
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
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            buttonCalcular2 = new Button();
            textBoxCostoPersona2 = new TextBox();
            textBoxNumeroPersonas2 = new TextBox();
            checkBoxDecoración2 = new CheckBox();
            checkBoxMenuSaludable = new CheckBox();
            Total2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkMagenta;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-187, -5);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 128);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkMagenta;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(532, 34);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 58);
            label1.TabIndex = 2;
            label1.Text = "Cena Gala";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 9F);
            label5.Location = new Point(173, 239);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 19;
            label5.Text = "Costo Persona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F);
            label2.Location = new Point(173, 191);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 16;
            label2.Text = "Numero Personas";
            // 
            // buttonCalcular2
            // 
            buttonCalcular2.BackColor = Color.Gold;
            buttonCalcular2.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold);
            buttonCalcular2.Location = new Point(275, 309);
            buttonCalcular2.Name = "buttonCalcular2";
            buttonCalcular2.Size = new Size(174, 48);
            buttonCalcular2.TabIndex = 15;
            buttonCalcular2.Text = "Calcular";
            buttonCalcular2.UseVisualStyleBackColor = false;
            buttonCalcular2.Click += buttonCalcular2_Click;
            // 
            // textBoxCostoPersona2
            // 
            textBoxCostoPersona2.Location = new Point(324, 236);
            textBoxCostoPersona2.Name = "textBoxCostoPersona2";
            textBoxCostoPersona2.Size = new Size(125, 27);
            textBoxCostoPersona2.TabIndex = 13;
            // 
            // textBoxNumeroPersonas2
            // 
            textBoxNumeroPersonas2.Location = new Point(324, 188);
            textBoxNumeroPersonas2.Name = "textBoxNumeroPersonas2";
            textBoxNumeroPersonas2.Size = new Size(125, 27);
            textBoxNumeroPersonas2.TabIndex = 10;
            textBoxNumeroPersonas2.TextChanged += textBoxNumeroPersonas2_TextChanged;
            // 
            // checkBoxDecoración2
            // 
            checkBoxDecoración2.AutoSize = true;
            checkBoxDecoración2.Font = new Font("Palatino Linotype", 9F);
            checkBoxDecoración2.Location = new Point(543, 191);
            checkBoxDecoración2.Name = "checkBoxDecoración2";
            checkBoxDecoración2.Size = new Size(106, 24);
            checkBoxDecoración2.TabIndex = 20;
            checkBoxDecoración2.Text = "Decoración";
            checkBoxDecoración2.UseVisualStyleBackColor = true;
            // 
            // checkBoxMenuSaludable
            // 
            checkBoxMenuSaludable.AutoSize = true;
            checkBoxMenuSaludable.Font = new Font("Palatino Linotype", 9F);
            checkBoxMenuSaludable.Location = new Point(543, 238);
            checkBoxMenuSaludable.Name = "checkBoxMenuSaludable";
            checkBoxMenuSaludable.Size = new Size(140, 24);
            checkBoxMenuSaludable.TabIndex = 21;
            checkBoxMenuSaludable.Text = "Menú Saludable";
            checkBoxMenuSaludable.UseVisualStyleBackColor = true;
            // 
            // Total2
            // 
            Total2.AutoSize = true;
            Total2.BackColor = Color.BlueViolet;
            Total2.Location = new Point(512, 327);
            Total2.Name = "Total2";
            Total2.Size = new Size(0, 20);
            Total2.TabIndex = 22;
            // 
            // FormCenaGala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(899, 451);
            Controls.Add(Total2);
            Controls.Add(checkBoxMenuSaludable);
            Controls.Add(checkBoxDecoración2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(buttonCalcular2);
            Controls.Add(textBoxCostoPersona2);
            Controls.Add(textBoxNumeroPersonas2);
            Controls.Add(panel1);
            Name = "FormCenaGala";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Button buttonCalcular2;
        private TextBox textBoxCostoPersona2;
        private TextBox textBoxNumeroPersonas2;
        private CheckBox checkBoxDecoración2;
        private CheckBox checkBoxMenuSaludable;
        private Label Total2;
    }
}