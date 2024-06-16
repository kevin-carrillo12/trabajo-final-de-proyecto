using Proyecto_Programacion_Estructurada_2024.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programacion_Estructurada_2024
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void surpryse_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumero1.Text, out int numero1);
            int.TryParse(txtNumero2.Text, out int numero2);

            txtResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumero1.Text, out int numero1);
            int.TryParse(txtNumero2.Text, out int numero2);

            txtResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumero1.Text, out int numero1);
            int.TryParse(txtNumero2.Text, out int numero2);

            txtResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float.TryParse(txtNumero1.Text, out float numero1);
            float.TryParse(txtNumero2.Text, out float numero2);

            txtResultado.Text = (numero1 / numero2).ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formsiguiente  formsiguiente = new Formsiguiente();
            this.Hide();
            formsiguiente.ShowDialog();
        }
    }
}
