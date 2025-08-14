using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }
        void borrar()
        {
            txtIdentificacion.Text = "";
            txtEstado.Text = "";
            info.Rows.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            MySqlConnection conecta = new MySqlConnection();
            int ID_REGISTRO = 0;
            try
            {
                conecta = Conexion.ConectarSQL();
                string query = "INSERT INTO ingreso (IDENTIFICACION,ESTADO,FECHA,HORA)" +
                    "VALUES(@IDENTIFICACION,@ESTADO,@FECHA,@HORA)";
                MySqlCommand cmd = new MySqlCommand(query, conecta);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                cmd.Parameters.AddWithValue("@ESTADO", txtEstado.SelectedIndex);
                cmd.Parameters.AddWithValue("@FECHA", dtFecha.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@HORA", dtFecha.Value.ToShortTimeString());
                ID_REGISTRO = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }

            foreach (DataGridViewRow row in info.Rows)
            {
                if (!row.IsNewRow)
                {
                    guardarinfo guardarinf = new guardarinfo();
                    if (Convert.ToBoolean(row.Cells[5].Value) == true)
                    {
                        guardarinf.ID_REGISTRO = ID_REGISTRO;
                        guardarinf.Dispositivo = row.Cells[0].Value.ToString();
                        guardarinf.Serie = row.Cells[2].Value.ToString();
                        guardarinf.Mouse = row.Cells[3].Value.ToString();
                        guardarinf.Cargador = row.Cells[4].Value.ToString();

                        seleccion(guardarinf);

                    }
                    MessageBox.Show("Guardado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
            }

        }
        void seleccion(guardarinfo guardarinf)
        {
            MySqlConnection cnn = new MySqlConnection();
            try
            {
                cnn = Conexion.ConectarSQL();
                string query = "INSERT INTO entradapc (IDINGRESO,TIPODEDISPOSITIVO,SERIE,MOUSE,CARGADOR)" +
                    "VALUES(@ID_INGRESO,@TIPO_DE_DISPOSITIVO,@SERIE,@MOUSE,@CARGADOR)";


                MySqlCommand cmd = new MySqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@ID_INGRESO", guardarinf.ID_REGISTRO);
                cmd.Parameters.AddWithValue("@TIPO_DE_DISPOSITIVO", guardarinf.Dispositivo);
                cmd.Parameters.AddWithValue("@SERIE", guardarinf.Serie);
                cmd.Parameters.AddWithValue("@MOUSE", guardarinf.Mouse);
                cmd.Parameters.AddWithValue("@CARGADOR", guardarinf.Cargador);
                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }


        private void txtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            MySqlConnection conexionn = new MySqlConnection();

            try
            {
                string query = "SELECT IDENTIFICACION,NOMBRE,APELLIDO,TIPODEUSUARIO FROM diseño WHERE IDENTIFICACION=@IDENTIFICACION";

                conexionn = Conexion.ConectarSQL();
                MySqlCommand cmd = new MySqlCommand(query, conexionn);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtIdentificacion.Text = reader["IDENTIFICACION"].ToString();

                }
            }
            catch
            {

            }
            finally
            {
                conexionn.Close();
            }
            try
            {
                string computadores = "SELECT TIPODEDISPOSITIVO,MARCA,SERIE FROM computador " +
                    " WHERE IDENTIFICACION=@IDENTIFICACION ";
                conexionn = Conexion.ConectarSQL();
                MySqlCommand pvd = new MySqlCommand(computadores, conexionn);
                pvd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                MySqlDataReader reader = pvd.ExecuteReader();
                while (reader.Read())
                {
                    info.Rows.Add(reader["TIPODEDISPOSITIVO"], reader["MARCA"], reader["SERIE"]);

                }
            }
            catch
            {

            }

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            dtFecha.Value = DateTime.Now;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
