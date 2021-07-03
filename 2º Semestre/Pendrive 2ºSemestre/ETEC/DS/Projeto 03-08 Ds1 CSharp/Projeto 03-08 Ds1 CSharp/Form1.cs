using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class lblcurso : Form
    {
        public lblcurso()
        {
            InitializeComponent();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comando que contabiliza a quantidade de caracteres de uma frase
            //Método ToString transforma qualquer numero em "string"
            lblletras.Text = cbxCurso.Text.Length.ToString();


        }

        private void lblletras_Click(object sender, EventArgs e)
        {

        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {

            //se trata o formulario dentro do algoritmo como "this"

            //associa a caixa de texto ao txt do formulario
            this.Text = txtNome.Text.ToUpper().Trim();

            txtNomecomp.Text = txtNome.Text.Trim() + " " + txtsobrenome.Text.Trim();

        }

        private void lblcurso_Load(object sender, EventArgs e)
        {

        }

        private void txtNomecomp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtsobrenome.Clear();
            txtNomecomp.Clear();
            txtNome.Focus();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
