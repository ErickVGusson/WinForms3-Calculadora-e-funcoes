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

        public void escolhaOperador(double numero, string operadorEscolhido)
        {

            lblTemporario.Text = numero.ToString();
            lblOperador.Text = operadorEscolhido;

            txbNumero1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Funções para cada botão
        //public double resultadoSoma(double num1, double num2)
        //{

        //    double resultado = 0;

        //    resultado = num1 + num2;

        //    return resultado;

        //}

        //public double resultadoMenos(double num1, double num2)
        //{

        //    double resultado = 0;

        //    resultado = num1 - num2;

        //    return resultado;

        //}

        //public double resultadoVezes(double num1, double num2)
        //{

        //    double resultado = 0;

        //    resultado = num1 * num2;

        //    return resultado;

        //}

        //public double resultadoDividir(double num1, double num2)
        //{

        //    double resultado = 0;

        //    resultado = num1 / num2;

        //    return resultado;

        //}

        public double calculos(double num1, double num2, string operador)
        {

            double resultado = 0;

            if (operador == "+")
            {

                resultado = num1 + num2;

            }

            else if (operador == "-")
            {

                resultado = num1 - num2;

            }

            else if (operador == "x")
            {

                resultado = num1 * num2;

            }

            else if (operador == "/")
            {

                resultado = num1 / num2;

            }

            else
            {
                resultado = 0;
            }

            return resultado;

        }

        private void btnCalcular(object sender, EventArgs e)
        {
            if (txbNumero1.Text != "")
            {

                double numero1 = double.Parse(txbNumero1.Text);
                //double numero2 = double.Parse(txbNumero2.Text);
                //double numero2 = 0;

                Button botao = (Button)sender;
                string operadorSelecionado = botao.Text;

                //double total;

                //total = calculos(numero1, numero2, operadorSelecionado);

                //txbResultado.Text = total.ToString();

                escolhaOperador(numero1, operadorSelecionado);

            }

            else
            {

                lblTemporario.Text = "Erro";

            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {

            Button valorBotao = (Button)sender;

            //MessageBox.Show(valorBotao.Text);

            //txbNumero1.Text = txbNumero1.Text + valorBotao.Text;

            txbNumero1.Text += valorBotao.Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txbNumero1.Text = "";

        }



        //Funções de click para cada botão
        //private void btnMais_Click(object sender, EventArgs e)
        //{

        //    double numero1 = double.Parse(txbNumero1.Text);
        //    double numero2 = double.Parse(txbNumero2.Text);

        //    double total;

        //    total = calculos(numero1, numero2, "+");

        //    lblResultado.Text = total.ToString();

        //}

        //private void btnMenos_Click(object sender, EventArgs e)
        //{

        //    double numero1 = double.Parse(txbNumero1.Text);
        //    double numero2 = double.Parse(txbNumero2.Text);

        //    double total;

        //    total = calculos(numero1, numero2, "-");

        //    lblResultado.Text = total.ToString();

        //}

        //private void btnVezes_Click(object sender, EventArgs e)
        //{

        //    double numero1 = double.Parse(txbNumero1.Text);
        //    double numero2 = double.Parse(txbNumero2.Text);

        //    double total;

        //    total = calculos(numero1, numero2, "*");

        //    lblResultado.Text = total.ToString();

        //}

        //private void btnDividir_Click(object sender, EventArgs e)
        //{

        //    double numero1 = double.Parse( txbNumero1.Text );
        //    double numero2 = double.Parse( txbNumero2.Text );

        //    double total;

        //    total = calculos(numero1, numero2, "/");

        //    lblResultado.Text = total.ToString();

        //}

    }
}
