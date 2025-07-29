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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }
        void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(txtIdentificacion.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text)
                && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text) && !string.IsNullOrEmpty(txtConfirmar.Text)
                && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtTelefono.Text);
            btnActualizar.Enabled = vr;
        }
        void borrar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmar.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
            validarcampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
            validarcampos();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validarcampos();

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
            validarcampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            string query = "UPDATE usuario SET " +
               "NOMBRE=@NOMBRE,APELLIDO=@APELLIDO,USUARIO=@USUARIO,CONTRASEÑA=@CONTRASEÑA,CELULAR=@CELULAR,EMAIL=@EMAIL WHERE " +
               "IDENTIFICACION=@IDENTIFICACION";
            SqlConnection conexio = new SqlConnection();

            try
            {
                conexio = Conexion.ConectarSQL();
                SqlCommand cmd = new SqlCommand(query, conexio);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
                cmd.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@CELULAR", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txtCorreo.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("datos actualizado", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("se ha presentado un error" + ex.Message);

            }
            finally
            {
                conexio.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void txtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                string query = "SELECT IDENTIFICACION, NOMBRE,APELLIDO,USUARIO, CONTRASEÑA,CELULAR,EMAIL FROM usuario WHERE IDENTIFICACION=@IDENTIFICACION";

                SqlConnection conexionn = Conexion.ConectarSQL();
                SqlCommand cmd = new SqlCommand(query, conexionn);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtIdentificacion.Text = reader["IDENTIFICACION"].ToString();
                    txtNombre.Text = reader["NOMBRE"].ToString();
                    txtApellido.Text = reader["APELLIDO"].ToString();
                    txtUsuario.Text = reader["USUARIO"].ToString();
                    txtContraseña.Text = reader["CONTRASEÑA"].ToString();
                    txtTelefono.Text = reader["CELULAR"].ToString();
                    txtCorreo.Text = reader["EMAIL"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("se ha presentado un error");
            }
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }
    }
}
