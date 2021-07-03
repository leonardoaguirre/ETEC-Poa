using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_22_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rdb_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_1_CheckedChanged(object sender, EventArgs e)
        {
           image.ImageLocation = "properties\resources.resx\gif1.gif" ;
        }


    }
}
