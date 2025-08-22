using System;
using MySql.Data.MySqlClient;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
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
        private void Registro_Load(object sender, EventArgs e)
        {

        }
        void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(txtIdentificacion.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text)
            && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text) && !string.IsNullOrEmpty(txtConfirmar.Text)
            && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtTelefono.Text);
            btnGuardar.Enabled = vr;
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
            validarcampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
            validarcampos();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
            validarcampos();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
            validarcampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;

            MySqlConnection conecta = Conexion.ConectarSQL();
            string query = "INSERT INTO usuario (IDENTIFICACION, NOMBRE, APELLIDO, USUARIO, CONTRASENA, CELULAR, EMAIL) " +
                           "VALUES (@IDENTIFICACION, @NOMBRE, @APELLIDO, @USUARIO, @CONTRASEÑA, @CELULAR, @EMAIL)";

            MySqlCommand cmd = new MySqlCommand(query, conecta);
            cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
            cmd.Parameters.AddWithValue("@APELLIDO", txtApellido.Text);
            cmd.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);

            // 🔐 Encriptar la contraseña antes de guardarla
            string contraseñaPlano = txtContraseña.Text;
            string contraseñaEncriptada = Encriptador.Encriptar(contraseñaPlano);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", contraseñaEncriptada);

            cmd.Parameters.AddWithValue("@CELULAR", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtCorreo.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.ShowDialog();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
