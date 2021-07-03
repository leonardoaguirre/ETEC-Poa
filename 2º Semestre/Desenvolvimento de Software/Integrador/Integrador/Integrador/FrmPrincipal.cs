using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Integrador
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuComponentesSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuComponentesForm1_Click(object sender, EventArgs e)
        {
            statusOp3.Text = "Atual : Form1";
            Form1 form1 = new Form1();
            form1.ShowDialog();
            statusOp3.Text = "Atual : Principal";
        }

        private void menuComponentesForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda frmAjuda = new frmAjuda();
            frmAjuda.ShowDialog();
        }
    }
}
