using appNotas.Capas.Entidades;
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

namespace appNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            DALNotas dalNotas = new DALNotas();
            List<Notas> lista = new List<Notas>();
            lista = dalNotas.GetAllNotas();
            foreach(Notas notas in lista)
            {
                rTxtBDatos.Text += "\n" + notas.ToString() + "\n";
                rTxtBDatos.Text += "\n —⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿—⦿-" + "\n";

            }
        }
    }
}
