using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = 0;
                int valor2 = 0;
                int resultado = 0;

                valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
                valor2 = Convert.ToInt16(txtDigiteSegundoNumero.Text);

                if (valor1 != 0)
                {
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        MessageBox.Show("O valor da divisão é: " + resultado);
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel efetuar divisão por zero(0)");
                    }
                }
                else
                {
                    MessageBox.Show("Insira um número para efetuar o cálculo.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira números inteiros nos locais indicados em seguida escolha a operação desejada.");
            }

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
                int valor2 = Convert.ToInt16(txtDigiteSegundoNumero.Text);

                int resultado = valor1 + valor2;

                txtResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira números inteiros nos locais indicados em seguida escolha a operação desejada.");
            }


        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
                int valor2 = Convert.ToInt16(txtDigiteSegundoNumero.Text);

                int resultado = valor1 - valor2;

                txtResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira números inteiros nos locais indicados em seguida escolha a operação desejada.");
            }

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
                int valor2 = Convert.ToInt16(txtDigiteSegundoNumero.Text);

                int resultado = valor1 * valor2;

                txtResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira números inteiros nos locais indicados em seguida escolha a operação desejada.");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Deseja realmente fechar essa aplicação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDigitePrimeiroNumero.Clear();
            txtDigiteSegundoNumero.Clear();
            txtResultado.Clear();
        }

    }
}
