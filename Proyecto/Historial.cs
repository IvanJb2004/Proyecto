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
            MySqlConnection conexio = new MySqlConnection(); 
            try
            {

                string query = "SELECT FECHA, HORA, ESTADO, NOMBRE, APELLIDO, TIPODEUSUARIO, MARCA, SERIE, COLOR, MOUSE, CARGADOR" +
                "\r\nFROM(SELECT FECHA, HORA, ESTADO, ingreso.IDINGRESO, SERIE, MOUSE, CARGADOR, IDENTIFICACION, MARCA, COLOR" +
                "\r\nFROM(SELECT entradapc.IDINGRESO, entradapc.SERIE, entradapc.MOUSE, MARCA, COLOR, entradapc.CARGADOR" +
                "\r\nFROM entradapc INNER JOIN computador ON entradapc.SERIE = computador.SERIE)" +
                "\r\nentradapc INNER JOIN ingreso \r\nON entradapc.IDINGRESO = ingreso.IDINGRESO " +
                "WHERE ingreso.IDENTIFICACION = @IDENTIFICACION)" +
                "\r\ningreso INNER JOIN diseño ON diseño.IDENTIFICACION = ingreso.IDENTIFICACION";

                conexio = Conexion.ConectarSQL();
                MySqlCommand cmd = new MySqlCommand(query, conexio);
                cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int estadoNumerico = Convert.ToInt32(reader["ESTADO"]);
                    string estadoTexto;
                    if (estadoNumerico == 1)
                    {
                        estadoTexto = "Entrada";
                    }
                    else if (estadoNumerico == 0)
                    {
                        estadoTexto = "Salida";
                    }
                    else
                    {
                        
                        estadoTexto = "Desconocido";
                    }
                    info.Rows.Add(reader["FECHA"], reader["HORA"], estadoTexto, reader["NOMBRE"], reader["APELLIDO"],
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

