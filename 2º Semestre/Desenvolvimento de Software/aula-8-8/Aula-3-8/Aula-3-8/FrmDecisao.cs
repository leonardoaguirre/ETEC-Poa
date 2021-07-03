using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_3_8
{
    public partial class FrmDecisao : Form
    {
        public FrmDecisao()
        {
            InitializeComponent();
        }

        private void btnCores_Click(object sender, EventArgs e)
        {
            if (btnCores.Text == "Vermelho")
            {
                this.BackColor = Color.Red;
                btnCores.Text = "Azul";
            }
            else
            {
                if (btnCores.Text == "Azul")
                {
                    this.BackColor = Color.Blue;
                    btnCores.Text = "Verde";
                }
                else
                {
                    if (btnCores.Text == "Verde")
                    {
                        this.BackColor = Color.Green;
                        btnCores.Text = "Foda-se o Padrão";
                    }
                    else
                    {
                        this.BackColor = Color.Empty;

                    }
                }
            }
         
        }
    }
}
