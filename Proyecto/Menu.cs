using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso ingreso = new Ingreso();
            ingreso.ShowDialog();
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar actualizar = new Actualizar();
            actualizar.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial historial = new Historial();
            historial.ShowDialog();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void info_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MySqlConnection conexio = new MySqlConnection();
            try
            {
                string query = "SELECT DISTINC d.NOMBRE, d.APELLIDO, c.TIPODEDISPOSITIVO, c.MARCA, c.SERIE, i.ESTADO, i.FECHA, i.HORA, e.MOUSE, e.CARGADOR  FROM diseño d INNER JOIN computador c ON c.IDENTIFICACION = d.IDENTIFICACION INNER JOIN ingreso i ON i.IDENTIFICACION  = c.IDENTIFICACION INNER JOIN entradapc e ON e.IDINGRESO = i.IDINGRESO WHERE i.ESTADO = '1' LIMIT 1;";
                conexio = Conexion.ConectarSQL();
                MySqlCommand cmd = new MySqlCommand(query, conexio);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    info.Rows.Add( reader["NOMBRE"], reader["APELLIDO"], reader["TIPODEDISPOSITIVO"],reader["MARCA"], 
                                   reader["SERIE"], reader["MOUSE"], reader["CARGADOR"],reader["FECHA"], reader["HORA"]);
                }
            }
            catch { }
        }
    }
}
