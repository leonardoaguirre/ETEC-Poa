using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaticReference
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Text = form2.valor.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = "Olá " + variaveis.nome+". Você tem "+variaveis.idade +" anos.";
            this.Text = string.Format("Olá {0}. Você tem {1} anos.", variaveis.nome, variaveis.idade);
        }
    }
}
