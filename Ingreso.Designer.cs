namespace Proyecto
{
    partial class Ingreso
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
            dtFecha = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtIdentificacion = new TextBox();
            txtEstado = new ComboBox();
            info = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            Column6 = new DataGridViewComboBoxColumn();
            Column7 = new DataGridViewCheckBoxColumn();
            btnGuardar = new Button();
            btnUsuario = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnVolver = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.descarga;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 44);
            label1.Name = "label1";
            label1.Size = new Size(280, 28);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE ENTRADA";
            // 
            // dtFecha
            // 
            dtFecha.CustomFormat = "dd:MM:yyy:hh:mm:tt";
            dtFecha.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.Location = new Point(616, 45);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(289, 27);
            dtFecha.TabIndex = 2;
            dtFecha.Value = new DateTime(2024, 6, 16, 0, 0, 0, 0);
            dtFecha.ValueChanged += dtFecha_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(226, 141);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 3;
            label2.Text = "IDENTIFICACION :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(619, 144);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 4;
            label3.Text = "ESTADO :";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(368, 135);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(245, 27);
            txtIdentificacion.TabIndex = 5;
            txtIdentificacion.TextChanged += txtIdentificacion_TextChanged;
            txtIdentificacion.KeyPress += txtIdentificacion_KeyPress;
            txtIdentificacion.Validating += txtIdentificacion_Validating;
            // 
            // txtEstado
            // 
            txtEstado.FormattingEnabled = true;
            txtEstado.Items.AddRange(new object[] { "SALIDA", "ENTRADA" });
            txtEstado.Location = new Point(701, 133);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(189, 28);
            txtEstado.TabIndex = 6;
            txtEstado.SelectedIndexChanged += txtEstado_SelectedIndexChanged;
            // 
            // info
            // 
            info.BackgroundColor = Color.White;
            info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            info.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6, Column7 });
            info.Location = new Point(12, 219);
            info.Name = "info";
            info.RowHeadersWidth = 51;
            info.Size = new Size(926, 273);
            info.TabIndex = 7;
            info.CellContentClick += info_CellContentClick;
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
            // Column5
            // 
            Column5.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Column5.HeaderText = "Mouse";
            Column5.Items.AddRange(new object[] { "SI", "NO" });
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Column6.HeaderText = "Cargador";
            Column6.Items.AddRange(new object[] { "SI\t", "NO" });
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Seleccionar";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.disco_flexible;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Location = new Point(89, 498);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 85);
            btnGuardar.TabIndex = 8;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.BackgroundImage = Properties.Resources.nueva_cuenta;
            btnUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsuario.Location = new Point(319, 498);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(81, 85);
            btnUsuario.TabIndex = 9;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = Properties.Resources.goma_de_borrar;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnLimpiar.Location = new Point(546, 498);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 85);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Underline);
            label4.Location = new Point(94, 586);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 11;
            label4.Text = "Guardar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Underline);
            label5.Location = new Point(319, 584);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 12;
            label5.Text = "Nuevo Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Underline);
            label6.Location = new Point(557, 586);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 13;
            label6.Text = "Limpiar";
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolver.Location = new Point(776, 498);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 85);
            btnVolver.TabIndex = 14;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(795, 586);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 15;
            label7.Text = "Volver";
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(939, 615);
            Controls.Add(label7);
            Controls.Add(btnVolver);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(info);
            Controls.Add(txtEstado);
            Controls.Add(txtIdentificacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtFecha);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Ingreso";
            Text = "Ingreso";
            Load += Ingreso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DateTimePicker dtFecha;
        private Label label2;
        private Label label3;
        private TextBox txtIdentificacion;
        private ComboBox txtEstado;
        private DataGridView info;
        private Button btnGuardar;
        private Button btnUsuario;
        private Button btnLimpiar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnVolver;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewComboBoxColumn Column5;
        private DataGridViewComboBoxColumn Column6;
        private DataGridViewCheckBoxColumn Column7;
    }
}