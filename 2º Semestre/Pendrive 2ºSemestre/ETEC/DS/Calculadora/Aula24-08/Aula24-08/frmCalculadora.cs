using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula24_08
{
    public partial class Form1 : Form
    {
        int contVisor;
        double memAux, valor1;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contVisor = 0;
            valor1 = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '1';
            contVisor++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '2';
            contVisor++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '3';
            contVisor++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '4';
            contVisor++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '5';
            contVisor++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '6';
            contVisor++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '7';
            contVisor++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '8';
            contVisor++;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '9';
            contVisor++;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
                txtVisor.Text += '0';
            contVisor++;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();

            valor1 = memAux = contVisor = 0;

            btnMais.Enabled = true;

            btnMenos.Enabled = true;

            btnMultiplicar.Enabled = true;

            btnDividir.Enabled = true;
        }

      

    private void btnMais_Click(object sender, EventArgs e)
    {
        if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio

        {

            valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar

            operador = "+"; //Atribui o tipo de operação

            txtVisor.Clear(); //Limpa a caixa de texto

            contVisor = 0; //Zera o contador do visor

            btnMais.Enabled = false;

            btnMenos.Enabled = false;

            btnMultiplicar.Enabled = false;

            btnDividir.Enabled = false;
        }
    }

    private void btnMenos_Click(object sender, EventArgs e)
    {
        if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio

        {

            valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar

            operador = "-"; //Atribui o tipo de operação

            txtVisor.Clear(); //Limpa a caixa de texto

            contVisor = 0; //Zera o contador do visor

            btnMais.Enabled = false;

            btnMenos.Enabled = false;

            btnMultiplicar.Enabled = false;

            btnDividir.Enabled = false;
        }
    }

    private void btnMultiplicar_Click(object sender, EventArgs e)
    {
        if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio

        {

            valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar

            operador = "*"; //Atribui o tipo de operação

            txtVisor.Clear(); //Limpa a caixa de texto

            contVisor = 0; //Zera o contador do visor

            btnMais.Enabled = false;

            btnMenos.Enabled = false;

            btnMultiplicar.Enabled = false;

            btnDividir.Enabled = false;
        }
    }

    private void btnDividir_Click(object sender, EventArgs e)
    {
        if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio

        {

            valor1 = Convert.ToDouble(txtVisor.Text); // Armazena o valor do visor numa memória auxiliar

            operador = "/"; //Atribui o tipo de operação

            txtVisor.Clear(); //Limpa a caixa de texto

            contVisor = 0; //Zera o contador do visor

            btnMais.Enabled = false;

            btnMenos.Enabled = false;

            btnMultiplicar.Enabled = false;

            btnDividir.Enabled = false;
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

                btnMais.Enabled = true;

                btnMenos.Enabled = true;

                btnMultiplicar.Enabled = true;

                btnDividir.Enabled = true;

            }

        }
    }
}


