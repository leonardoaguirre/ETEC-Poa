using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunTime
{
    public partial class rdbTarde : Form
    {
        public rdbTarde()
        {
            InitializeComponent();
        }

        //Troca a cor do formulario para azul
        private void btnAzul_Click(object sender, EventArgs e)
        {
            //this refere-se ao proprio formulario 
            //backcolor é a propriedade
            this.BackColor = Color.Blue;
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;   
        }

        private void rdbTarde_Load(object sender, EventArgs e)
        {

        }

        private void rdbTarde1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNoite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupPeriodo_Enter(object sender, EventArgs e)
        {

        }
        //Habilita ou desabilita os botões de cor
        private void chbHabilita_CheckedChanged(object sender, EventArgs e)
        {
            //'!' funciona como negação
            //Se uma propriedade é 'True' ela passa a ser 'False'
            btnAzul.Enabled = !btnAzul.Enabled;
            btnVermelho.Enabled = !btnVermelho.Enabled;
        }
    }
}
