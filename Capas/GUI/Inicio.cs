using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appNotas.Capas.GUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            Prueba1 oPrueba = new Prueba1();
            oPrueba.Show();
            this.Hide();
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            Prueba2 oPrueba2 = new Prueba2();
            oPrueba2.Show();
            this.Hide();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
