namespace Proyecto
{
    partial class Menu
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
            btnEntrada = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrada
            // 
            btnEntrada.BackgroundImage = Properties.Resources.entrar;
            btnEntrada.BackgroundImageLayout = ImageLayout.Zoom;
            btnEntrada.Location = new Point(295, 33);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(127, 109);
            btnEntrada.TabIndex = 1;
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = Properties.Resources.actualizar;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(295, 214);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(127, 109);
            btnActualizar.TabIndex = 3;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar_sesion;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Location = new Point(494, 214);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(127, 109);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Underline);
            label1.Location = new Point(295, 145);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 5;
            label1.Text = "Registro De Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Underline);
            label3.Location = new Point(296, 326);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 7;
            label3.Text = "Actualizar Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Underline);
            label4.Location = new Point(494, 326);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 8;
            label4.Text = "Cerrar Sesion";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.simbolo_de_interfaz_de_historial_de_navegacion_de_un_reloj_con_una_flecha;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(494, 33);
            button1.Name = "button1";
            button1.Size = new Size(127, 109);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(533, 145);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 10;
            label5.Text = "Historial";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(699, 452);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEntrada);
            Controls.Add(pictureBox1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrada;
        private Button btnActualizar;
        private Button btnCerrar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}