using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_nova
{
    public partial class frmSplash : Form
    {
        int mudaImagem;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbBarra.Value += 10;
            if (pgbBarra.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Calc frm1 = new Calc();
                frm1.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mudaImagem++;
            if (mudaImagem == 1)
            {
                pictureBox1.Image = Properties.Resources.calc;
            }
            if (mudaImagem == 2)
            {
                pictureBox1.Image = Properties.Resources.Nextweb;
                mudaImagem = 0;
            }
        }
    }
}
