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
            info = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Mouse = new DataGridViewTextBoxColumn();
            Cargador = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
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
            btnEntrada.Location = new Point(523, 317);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(69, 80);
            btnEntrada.TabIndex = 1;
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = Properties.Resources.actualizar;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(377, 317);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 80);
            btnActualizar.TabIndex = 3;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar_sesion;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Location = new Point(1444, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(52, 47);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Underline);
            label1.Location = new Point(494, 400);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 5;
            label1.Text = "Registro De Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Underline);
            label3.Location = new Point(362, 400);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 7;
            label3.Text = "Actualizar Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Underline);
            label4.Location = new Point(1008, 403);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.simbolo_de_interfaz_de_historial_de_navegacion_de_un_reloj_con_una_flecha;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(270, 317);
            button1.Name = "button1";
            button1.Size = new Size(92, 80);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 403);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 10;
            label5.Text = "Historial";
            // 
            // info
            // 
            info.BackgroundColor = Color.White;
            info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            info.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, Column1, Column2, Column3, Mouse, Cargador, Fecha, Hora });
            info.Location = new Point(248, 28);
            info.Name = "info";
            info.RowHeadersWidth = 51;
            info.Size = new Size(1179, 273);
            info.TabIndex = 11;
            info.CellFormatting += info_CellFormatting;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Dispositivo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Marca";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Serie";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Mouse
            // 
            Mouse.HeaderText = "Mouse";
            Mouse.MinimumWidth = 6;
            Mouse.Name = "Mouse";
            Mouse.Width = 125;
            // 
            // Cargador
            // 
            Cargador.HeaderText = "Cargador";
            Cargador.MinimumWidth = 6;
            Cargador.Name = "Cargador";
            Cargador.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            Hora.Width = 125;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1508, 452);
            Controls.Add(info);
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
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
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
        private DataGridView info;
        private DataGridViewComboBoxColumn Column5;
        private DataGridViewComboBoxColumn Column6;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Mouse;
        private DataGridViewTextBoxColumn Cargador;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
    }
}