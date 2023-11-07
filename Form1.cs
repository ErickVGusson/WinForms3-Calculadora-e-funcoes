using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            
            float numero1 = int.Parse( txbNumero1.Text );
            float numero2 = int.Parse( txbNumero2.Text );

            float resultado;

            resultado = numero1 + numero2;

            lblResultado.Text = resultado.ToString();

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            float numero1 = int.Parse(txbNumero1.Text);
            float numero2 = int.Parse(txbNumero2.Text);

            float resultado;

            resultado = numero1 - numero2;

            lblResultado.Text = resultado.ToString();

        }

        private void btnVezes_Click(object sender, EventArgs e)
        {

            float numero1 = int.Parse(txbNumero1.Text);
            float numero2 = int.Parse(txbNumero2.Text);

            float resultado;

            resultado = numero1 * numero2;

            lblResultado.Text = resultado.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            float numero1 = int.Parse(txbNumero1.Text);
            float numero2 = int.Parse(txbNumero2.Text);

            float resultado;

            resultado = numero1 / numero2;

            lblResultado.Text = resultado.ToString();

        }

    }
}
