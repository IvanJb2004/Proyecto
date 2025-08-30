namespace Proyecto
{
    partial class PC
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdentificacion = new TextBox();
            txtMarca = new TextBox();
            txtSerie = new TextBox();
            txtColor = new TextBox();
            btnGuardar = new Button();
            label6 = new Label();
            btnVolver = new Button();
            label7 = new Label();
            cmbDispositivo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 81);
            label1.Name = "label1";
            label1.Size = new Size(267, 28);
            label1.TabIndex = 1;
            label1.Text = "Registro De Dispositivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.Location = new Point(179, 146);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 2;
            label2.Text = "N°Identificacion :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.Location = new Point(179, 287);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 3;
            label3.Text = "Marca :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label4.Location = new Point(179, 369);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 4;
            label4.Text = "Serie :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label5.Location = new Point(183, 444);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 5;
            label5.Text = "Color :";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(179, 168);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(252, 27);
            txtIdentificacion.TabIndex = 6;
            txtIdentificacion.KeyPress += txtIdentificacion_KeyPress;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(179, 319);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(252, 27);
            txtMarca.TabIndex = 7;
            txtMarca.KeyPress += txtMarca_KeyPress;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(179, 398);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(252, 27);
            txtSerie.TabIndex = 8;
            txtSerie.KeyPress += txtSerie_KeyPress;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(179, 472);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(252, 27);
            txtColor.TabIndex = 9;
            txtColor.KeyPress += TxtColor_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.disco_flexible;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Location = new Point(237, 535);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 74);
            btnGuardar.TabIndex = 10;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(250, 612);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Guardar";
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolver.Location = new Point(460, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(71, 63);
            btnVolver.TabIndex = 12;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(179, 212);
            label7.Name = "label7";
            label7.Size = new Size(172, 19);
            label7.TabIndex = 13;
            label7.Text = "Tipo De Dispositivo :";
            // 
            // cmbDispositivo
            // 
            cmbDispositivo.FormattingEnabled = true;
            cmbDispositivo.Items.AddRange(new object[] { "Portatil\t", "Tablet" });
            cmbDispositivo.Location = new Point(180, 245);
            cmbDispositivo.Name = "cmbDispositivo";
            cmbDispositivo.Size = new Size(251, 28);
            cmbDispositivo.TabIndex = 14;
            // 
            // PC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(554, 653);
            Controls.Add(cmbDispositivo);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(txtColor);
            Controls.Add(txtSerie);
            Controls.Add(txtMarca);
            Controls.Add(txtIdentificacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PC";
            Text = "PC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdentificacion;
        private TextBox txtMarca;
        private TextBox txtSerie;
        private TextBox txtColor;
        private Button btnGuardar;
        private Label label6;
        private Button btnVolver;
        private Label label7;
        private ComboBox cmbDispositivo;
    }
}