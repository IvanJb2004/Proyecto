using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection conecta = Conexion.ConectarSQL();
            string query = " INSERT INTO diseño (IDENTIFICACION,NOMBRE,APELLIDO,TIPODEUSUARIO)VALUES(@IDENTIFICACION,@NOMBRE,@APELLIDO,@TIPODEUSUARIO)";

            SqlCommand cmd = new SqlCommand(query, conecta);
            cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
            cmd.Parameters.AddWithValue("@TIPODEUSUARIO", cmbUsuario.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("datos guardado exitosamente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            PC pC = new PC();
            pC.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso ingreso = new Ingreso();
            ingreso.ShowDialog();
        }
    }
}
