using appNotas.Capas.Entidades;
using appNotas.Capas.Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace appNotas.Capas.GUI
{
    public partial class Prueba1 : Form
    {
        public Prueba1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            DALNotas dalNotas = new DALNotas();
            ProblemaUno oProblema = new ProblemaUno();
            oProblema.listNotas = dalNotas.GetAllNotas();

            //Sexto
            rtxtProm6.Text = Convert.ToString(oProblema.GetPromedio6());
            rtxtProm5.Text = Convert.ToString(oProblema.GetPromedio5());
            rtxtDesvEst6.Text = Convert.ToString(oProblema.GetDesvEstandar6());
            rtxtZ6.Text = Convert.ToString(oProblema.GetTotalZ6());
            rtxtDifZ6.Text = Convert.ToString(oProblema.GetRestaZ6());

            //Quinto
            rtxtZ5.Text = Convert.ToString(oProblema.GetTotalZ5());
            rtxtDifZ5.Text = Convert.ToString(oProblema.GetRestaZ5());

            //Interpretación
            rtxtInt.Text = oProblema.ToString();

        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            Prueba2 oPrueba2 = new Prueba2();
            oPrueba2.Show();
            this.Hide();
        }

        private void Prueba1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rtxtDesvEst6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
