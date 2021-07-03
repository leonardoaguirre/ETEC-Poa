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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i>=1900 ; i--)
            {
                cbxIdade.Items.Add(i);
            }
            cbxIdade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variaveis.nome = txtNome.Text.Trim();
            variaveis.idade = DateTime.Now.Year - Convert.ToInt32(cbxIdade.Text);
            
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
