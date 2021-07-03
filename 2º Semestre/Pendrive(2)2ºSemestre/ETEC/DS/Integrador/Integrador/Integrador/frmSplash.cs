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
    public partial class frmSplash : Form
    {
        int contTick = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            contTick++;
            if (contTick == 5)
            {
                timer1.Enabled = false;
                this.Hide();
            */

        pgbSplash.Value += 10;
        if (pgbSplash.Value == 100)
        {
            timer1.Enabled = false;
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        }
    }

