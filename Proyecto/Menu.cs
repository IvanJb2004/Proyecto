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
    }
}
