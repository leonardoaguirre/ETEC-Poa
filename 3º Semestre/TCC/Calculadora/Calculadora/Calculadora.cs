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
    public partial class Calculadora : Form
    {
        int contVisor;
        double valor1, memAux;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '1'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '2'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '3'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '4'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '5'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '6'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '7'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '8'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '9'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += '0'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!
            {
                txtVisor.Text += ','; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variável de controle de texto do visor

            }
        }
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar
                operador = "+"; //Atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto
                contVisor = 0; //Zera o contador do visor
                btnAdicao.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar
                operador = "-"; //Atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto
                contVisor = 0; //Zera o contador do visor
                btnAdicao.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar
                operador = "*"; //Atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto
                contVisor = 0; //Zera o contador do visor
                btnAdicao.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar
                operador = "/"; //Atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto
                contVisor = 0; //Zera o contador do visor
                btnAdicao.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio
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
                btnAdicao.Enabled = true;
                btnSub.Enabled = true;
                btnMulti.Enabled = true;
                btnDiv.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = contVisor = 0;
            btnAdicao.Enabled = true;
            btnSub.Enabled = true;
            btnMulti.Enabled = true;
            btnDiv.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            contVisor = 0;
            valor1 = 0;
        }
    }
}
