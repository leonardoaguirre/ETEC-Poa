﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_17_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbreForm2_Click(object sender, EventArgs e)
        {
            //Declaração de uma nova instância de formulário
            //Form2 form2 = new Form2("Essa é a técnica de overload");
            Form2 form2 =  new Form2(2,6,1);
            form2.ShowDialog();
        
        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
