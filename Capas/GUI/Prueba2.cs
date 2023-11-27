using appNotas.Capas.Logica;
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
    public partial class Prueba2 : Form
    {
        public Prueba2()
        {
            InitializeComponent();
        }

        private void rtxtProm5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DALNotas dalNotas = new DALNotas();
            ProblemaDos oProblema2 = new ProblemaDos();
            oProblema2.listNotas = dalNotas.GetAllNotas();

            //Valores
            rtxtProm6.Text = Convert.ToString(oProblema2.GetPromedio6());
            rtxtProm5.Text = Convert.ToString(oProblema2.GetPromedio5());
            rtxtDesvEst6.Text = Convert.ToString(oProblema2.GetDesvEstandar6());

            //Z
            rtxtZ.Text = Convert.ToString(oProblema2.GetZ());

            //Interpretación
            rtxtInterpretacion.Text = oProblema2.ToString();
        }

        private void Prueba2_Load(object sender, EventArgs e)
        {

        }

        private void Prueba2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            Prueba1 oPrueba = new Prueba1();
            oPrueba.Show();
            this.Hide();
        }
    }
}
