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
                string query = "SELECT USUARIO,CONTRASE�A FROM usuario WHERE USUARIO=@USUARIO AND CONTRASE�A=@CONTRASE�A";
                SqlConnection conexionn = Conexion.ConectarSQL();
                SqlCommand cmd = new SqlCommand(query, conexionn);
                cmd.Parameters.AddWithValue("USUARIO", txtUsuario.Text);
                cmd.Parameters.AddWithValue("CONTRASE�A", txtContrase�a.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {


                    this.Hide();
                    Menu form1 = new Menu();
                    form1.ShowDialog();
                }
                else
                {

                    MessageBox.Show(" el usuario o contrase�a incorrecta");
                    txtUsuario.Text = "";
                    txtContrase�a.Text = "";

                }


            }
            catch { }
            finally { }

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
                    string query = "SELECT usuario,contrase�a FROM usuario WHERE usuario=@usuario AND contrase�a=@contrase�a";
                    SqlConnection conexionnnn = Conexion.ConectarSQL();
                    SqlCommand cmd = new SqlCommand(query, conexionnnn);
                    cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("contrase�a", txtContrase�a.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
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
