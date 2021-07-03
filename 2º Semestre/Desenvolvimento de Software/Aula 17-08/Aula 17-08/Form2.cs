using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_17_08
{
    public partial class Form2 : Form
    {

        // Área de declaração de variáveis globais

        int valor1;
        int valor2;
        int result;
        int num1, num2;


        // Método construtor padrão 
        public Form2()
        {
            InitializeComponent();
        }

        //Método construtor passando uma frase 
        public Form2(string frase)
        {
            InitializeComponent();
            MessageBox.Show(frase);
        }

        //Método construtor com números
        public Form2(int num1, int num2, int result)
        {
            InitializeComponent();
            valor1 = num1;
            valor2 = num2;


        }

        private void btnExibirValores_Click(object sender, EventArgs e)
        {
            string meuValor1, meuValor2;

            meuValor1 = Convert.ToString(valor1);
            meuValor2 = Convert.ToString(valor2);



            // MessageBox.Show("Valor1:" + valor1.ToString() + "\nValor2:" + valor2.ToString());
            MessageBox.Show("Valor1:" + meuValor1 + "\nValor2:" + meuValor2);
            {
             private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            int result = num1 + num2;
            MessageBox.Show("Valor:" + result);
            
            
            }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            int result = num1 - num2;
            MessageBox.Show("Valor:" + result);
            
        }

        private void rdbMultiplicação_CheckedChanged(object sender, EventArgs e)
        {
            int result = num1 * num2;
            MessageBox.Show("Valor1:" + result);
            
        }

        private void rdbDivisão_CheckedChanged(object sender, EventArgs e)
        {
            int result = num1 / num2;
            MessageBox.Show("Valor1:" + result);
            
        }
        }


       
    }
}
