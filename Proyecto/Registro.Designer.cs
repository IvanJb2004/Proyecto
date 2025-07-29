namespace Proyecto
{
    partial class Registro
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtConfirmar = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label10 = new Label();
            label11 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(27, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 71);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 1;
            label1.Text = "Registar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.Location = new Point(96, 184);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 2;
            label2.Text = "N°Identificacion :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.Location = new Point(99, 259);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 3;
            label3.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label4.Location = new Point(99, 329);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 4;
            label4.Text = "Apellido : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label5.Location = new Point(99, 402);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 5;
            label5.Text = "Usuario :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label6.Location = new Point(457, 184);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 6;
            label6.Text = "Contraseña :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label7.Location = new Point(457, 259);
            label7.Name = "label7";
            label7.Size = new Size(194, 19);
            label7.TabIndex = 7;
            label7.Text = "Confirmar Contraseña :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label8.Location = new Point(457, 329);
            label8.Name = "label8";
            label8.Size = new Size(86, 19);
            label8.TabIndex = 8;
            label8.Text = "Telefono :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label9.Location = new Point(457, 402);
            label9.Name = "label9";
            label9.Size = new Size(169, 19);
            label9.TabIndex = 9;
            label9.Text = "Correo Electronico :";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(99, 206);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(251, 27);
            txtIdentificacion.TabIndex = 10;
            txtIdentificacion.TextChanged += txtIdentificacion_TextChanged;
            txtIdentificacion.KeyPress += txtIdentificacion_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 281);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 27);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(99, 351);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 27);
            txtApellido.TabIndex = 12;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 424);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(251, 27);
            txtUsuario.TabIndex = 13;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(457, 206);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(242, 27);
            txtContraseña.TabIndex = 14;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(457, 281);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(242, 27);
            txtConfirmar.TabIndex = 15;
            txtConfirmar.TextChanged += txtConfirmar_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(457, 354);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(242, 27);
            txtTelefono.TabIndex = 16;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(457, 429);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(242, 27);
            txtCorreo.TabIndex = 17;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.disco_flexible;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Location = new Point(245, 481);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 100);
            btnGuardar.TabIndex = 18;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = Properties.Resources.goma_de_borrar;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Location = new Point(457, 481);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 100);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Underline);
            label10.Location = new Point(255, 589);
            label10.Name = "label10";
            label10.Size = new Size(61, 17);
            label10.TabIndex = 20;
            label10.Text = "Guardar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Underline);
            label11.Location = new Point(456, 588);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 21;
            label11.Text = "Limpiar";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.volver;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(653, 21);
            button3.Name = "button3";
            button3.Size = new Size(67, 64);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(763, 648);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtConfirmar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
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
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtConfirmar;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label10;
        private Label label11;
        private Button button3;
    }
}