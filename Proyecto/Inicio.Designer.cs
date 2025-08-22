namespace Proyecto
{
    partial class Inicio
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            label4 = new Label();
            btnRegistrar = new Button();
            label5 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(110, 56);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 17);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 1;
            label1.Text = "COMPLEJO TECNOLOGICO PARA LA\r\n     GESTION AGROEMPRESARIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(110, 270);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "USUARIO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(110, 330);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "CONTRASEÑA:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(110, 296);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(196, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(110, 358);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(196, 23);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackgroundImage = Properties.Resources.iniciar_sesion;
            btnIniciarSesion.BackgroundImageLayout = ImageLayout.Zoom;
            btnIniciarSesion.Location = new Point(109, 394);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(83, 64);
            btnIniciarSesion.TabIndex = 6;
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 460);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Iniciar Sesion";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackgroundImage = Properties.Resources.registro;
            btnRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegistrar.Location = new Point(224, 394);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(81, 64);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 460);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 9;
            label5.Text = "Registrar Usuario";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(310, 361);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Mostrar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 509);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private Label label4;
        private Button btnRegistrar;
        private Label label5;
        private CheckBox checkBox1;
    }
}
