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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Proyecto
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void txtIdentificacion_Validating(object sender, CancelEventArgs e)
        {


        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog(this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexio = new SqlConnection();
            try
            {

                string query = "SELECT FECHA, HORA, ESTADO, NOMBRE, APELLIDO, TIPODEUSUARIO, MARCA, SERIE, COLOR, MOUSE, CARGADOR" +
                "\r\nFROM(SELECT FECHA, HORA, ESTADO, ingreso.ID_INGRESO, SERIE, MOUSE, CARGADOR, IDENTIFICACION, MARCA, COLOR" +
                "\r\nFROM(SELECT entradapc.ID_INGRESO, entradapc.SERIE, entradapc.MOUSE, MARCA, COLOR, entradapc.CARGADOR" +
                "\r\nFROM entradapc INNER JOIN computador ON entradapc.SERIE = computador.SERIE)" +
                "\r\nentradapc INNER JOIN ingreso \r\nON entradapc.ID_INGRESO = ingreso.ID_INGRESO " +
                "WHERE ingreso.IDENTIFICACION = IDENTIFICACION)" +
                "\r\ningreso INNER JOIN diseño ON diseño.IDENTIFICACION = ingreso.IDENTIFICACION";

                conexio = Conexion.ConectarSQL();
                SqlCommand cmd = new SqlCommand(query, conexio);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    info.Rows.Add(reader["FECHA"], reader["HORA"], reader["ESTADO"], reader["NOMBRE"], reader["APELLIDO"],
                         reader["TIPODEUSUARIO"], reader["MARCA"], reader["SERIE"], reader["COLOR"], reader["MOUSE"], reader["CARGADOR"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }
    }
}

