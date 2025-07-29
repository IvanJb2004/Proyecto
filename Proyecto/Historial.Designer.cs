namespace Proyecto
{
    partial class Historial
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
            txtIdentificacion = new TextBox();
            info = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)info).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 36);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 1;
            label1.Text = "HISTORIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 149);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 2;
            label2.Text = "N°IDENTIFICACION:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(239, 149);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(231, 27);
            txtIdentificacion.TabIndex = 3;
            txtIdentificacion.Validating += txtIdentificacion_Validating;
            // 
            // info
            // 
            info.BackgroundColor = Color.White;
            info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            info.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column12, Column1, Column2, Column3, Column4, Column5, Column6, Column10, Column11 });
            info.Location = new Point(-5, 203);
            info.Name = "info";
            info.RowHeadersWidth = 51;
            info.Size = new Size(1236, 273);
            info.TabIndex = 4;
            info.CellContentClick += info_CellContentClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "FECHA";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "HORA";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "ESTADO";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "NOMBRE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "APELLIDO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "TIPO DE USUARIO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "MARCA";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "SERIAL";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "COLOR";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "MOUSE";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "CARGADOR";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 125;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.volver;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1101, 12);
            button1.Name = "button1";
            button1.Size = new Size(90, 59);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.buscar;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Location = new Point(485, 149);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(65, 33);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1243, 540);
            Controls.Add(btnBuscar);
            Controls.Add(button1);
            Controls.Add(info);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)info).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtIdentificacion;
        private DataGridView info;
        private Button button1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Button btnBuscar;
    }
}