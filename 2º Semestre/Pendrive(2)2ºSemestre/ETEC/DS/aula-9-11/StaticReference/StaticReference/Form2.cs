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
    public partial class Form2 : Form
    {
        public int valor;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            valor = 2;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variaveis.meusNumeros.Add(Convert.ToInt32(textBox1.Text));
        }
    }
}
