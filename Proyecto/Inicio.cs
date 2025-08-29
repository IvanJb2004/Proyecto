using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrase�aIngresada = txtContrase�a.Text.Trim();

                using (MySqlConnection conexion = Conexion.ConectarSQL())
                {
                    string query = "SELECT CONTRASENA FROM usuario WHERE USUARIO = @usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashGuardado = reader.GetString("CONTRASENA");

                            if (Encriptador.Verificar(contrase�aIngresada, hashGuardado))
                            {
                                this.Hide();
                                Menu form1 = new Menu();
                                form1.ShowDialog();
                            }
                            else
                            {
                                MostrarError();
                            }
                        }
                        else
                        {
                            MostrarError();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MostrarError()
        {
            MessageBox.Show("Usuario o contrase�a incorrectos");
            txtUsuario.Text = "";
            txtContrase�a.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtContrase�a.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContrase�a.Focus();
            }
        }

        private void txtContrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    string query = "SELECT usuario,contrasena FROM usuario WHERE usuario=@usuario AND contrasena=@contrase�a";
                    MySqlConnection conexionnnn = Conexion.ConectarSQL();
                    MySqlCommand cmd = new MySqlCommand(query, conexionnnn);
                    cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("contrase�a", txtContrase�a.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {


                        this.Hide();
                        Menu form1 = new Menu();
                        form1.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("el error es" + ex.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
