using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        //Declaração de variáveis

        int contVisor;
        double valor1, memAux;
        string operador;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            contVisor = 0;
            valor1 = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '1';

                contVisor++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '2';

                contVisor++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '3';

                contVisor++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '4';

                contVisor++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '5';

                contVisor++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '6';

                contVisor++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '7';

                contVisor++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '8';

                contVisor++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '9';

                contVisor++;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '0';

                contVisor++;
            }
        }

      //private void FrmCalculadora_Load(object sender, EventArgs e)
       //
        //  valor1 = 0;
      //}

        private void btnAdição_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "+";
                txtVisor.Clear();
                contVisor = 0;

                btnAdição.Enabled = false;
                btnSubtração.Enabled = false;
                btnMultiplicação.Enabled = false;
                btnDivisão.Enabled = false;

            }

        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "-";
                txtVisor.Clear();
                contVisor = 0;

                btnAdição.Enabled = false;
                btnSubtração.Enabled = false;
                btnMultiplicação.Enabled = false;
                btnDivisão.Enabled = false;

            }
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "x";
                txtVisor.Clear();
                contVisor = 0;

                btnAdição.Enabled = false;
                btnSubtração.Enabled = false;
                btnMultiplicação.Enabled = false;
                btnDivisão.Enabled = false;

            }
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "/";
                txtVisor.Clear();
                contVisor = 0;

                btnAdição.Enabled = false;
                btnSubtração.Enabled = false;
                btnMultiplicação.Enabled = false;
                btnDivisão.Enabled = false;

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                memAux = Convert.ToDouble(txtVisor.Text);

                switch (operador)
                {
                    case "+":
                        valor1 += memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "-":
                        valor1 -= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "*":
                        valor1 *= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "/":
                        if (valor1 != 0 && memAux != 0)
                        {
                            valor1 = valor1 / memAux;
                            txtVisor.Text = Convert.ToString(valor1);
                            valor1 = 0;
                        }
                        else
                        {
                            MessageBox.Show("Impossível realizar divisão por 0!", "Erro de execução");

                            valor1 = 0;
                            memAux = 0;
                            txtVisor.Clear();
                        }
                        break;

                    default:
                        break;
                }
                contVisor = 0;

                btnAdição.Enabled = true;
                btnSubtração.Enabled = true;
                btnMultiplicação.Enabled = true;
                btnDivisão.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = contVisor = 0;

            btnAdição.Enabled = true;
            btnSubtração.Enabled = true;
            btnMultiplicação.Enabled = true;
            btnDivisão.Enabled = true;
        }

    }
}
