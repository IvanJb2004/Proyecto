namespace Proyecto
{
    partial class Usuario
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnGuardar = new Button();
            btnSiguiente = new Button();
            label6 = new Label();
            label7 = new Label();
            cmbUsuario = new ComboBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.descarga;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-241, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 66);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 1;
            label1.Text = "CREAR USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.Location = new Point(195, 210);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.Location = new Point(195, 278);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 3;
            label3.Text = "Apellido :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label4.Location = new Point(195, 140);
            label4.Name = "label4";
            label4.Size = new Size(142, 19);
            label4.TabIndex = 4;
            label4.Text = "N°Identificacion :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label5.Location = new Point(199, 355);
            label5.Name = "label5";
            label5.Size = new Size(146, 19);
            label5.TabIndex = 5;
            label5.Text = "Tipo De Usuario :";
            label5.Click += label5_Click;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(195, 162);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(231, 27);
            txtIdentificacion.TabIndex = 6;
            txtIdentificacion.KeyPress += txtIdentificacion_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 232);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(229, 27);
            txtNombre.TabIndex = 7;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(199, 302);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(227, 27);
            txtApellido.TabIndex = 8;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.disco_flexible;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Location = new Point(204, 426);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 72);
            btnGuardar.TabIndex = 10;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackgroundImage = Properties.Resources.proximo;
            btnSiguiente.BackgroundImageLayout = ImageLayout.Zoom;
            btnSiguiente.Location = new Point(337, 426);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(89, 72);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Underline);
            label6.Location = new Point(204, 509);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 12;
            label6.Text = "Guardar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Underline);
            label7.Location = new Point(337, 509);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 13;
            label7.Text = "Siguiente";
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Items.AddRange(new object[] { "APRENDIZ\t", "INSTRUCTOR\t", "ADMINISTRATIVO", "VISITANTE" });
            cmbUsuario.Location = new Point(197, 377);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(228, 28);
            cmbUsuario.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolver.Location = new Point(440, 24);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(56, 54);
            btnVolver.TabIndex = 15;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(518, 557);
            Controls.Add(btnVolver);
            Controls.Add(cmbUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnSiguiente);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Usuario";
            Text = "Usuario";
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnGuardar;
        private Button btnSiguiente;
        private Label label6;
        private Label label7;
        private ComboBox cmbUsuario;
        private Button btnVolver;
    }
}