using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class PC : Form
    {
        public PC()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlConnection guardar = Conexion.ConectarSQL();
            string query = "INSERT INTO computador (IDENTIFICACION,TIPODEDISPOSITIVO,MARCA,SERIE,COLOR)" +
                "VALUES(@IDENTIFICACION,@TIPO_DE_DISPOSITIVO,@MARCA,@SERIE,@COLOR)";

            MySqlCommand cmd = new MySqlCommand(query, guardar);
            cmd.Parameters.AddWithValue("@IDENTIFICACION", txtIdentificacion.Text);
            cmd.Parameters.AddWithValue("@TIPO_DE_DISPOSITIVO", cmbDispositivo.Text);
            cmd.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            cmd.Parameters.AddWithValue("@SERIE", txtSerie.Text);
            cmd.Parameters.AddWithValue("@COLOR", txtColor.Text);
            if (cmd.ExecuteNonQuery() > 0)

            {
                MessageBox.Show("los datos se han guardado exitosamente", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Ingreso usuario = new Ingreso();
                usuario.ShowDialog();
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.numero(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letra(e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide ();
            Ingreso usuario = new Ingreso();
            usuario.ShowDialog();

        }
    }
}
