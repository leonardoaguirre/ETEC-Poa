using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aula_3_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnTitulo_Click(object sender, EventArgs e)
        {
            this.Text = txtNome.Text.ToUpper().Trim();
            //associa o conteudo do text da caixa de texto no text do form
            this.Text = txtNome.Text.ToUpper().Trim();
            txtNomeCompleto.Text = txtNome.Text.Trim() + " " + txtSobrenome.Text.Trim();
        }



        private void cbxCursos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //comando que contabiliza a quantidade de caracteres de uma frase 
            lblLetras.Text = cbxCursos.Text.Length.ToString();
           
        }

    

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Clear();
            txtNomeCompleto.Clear();
            txtNome.Focus();
        }

    
       
    }
}
