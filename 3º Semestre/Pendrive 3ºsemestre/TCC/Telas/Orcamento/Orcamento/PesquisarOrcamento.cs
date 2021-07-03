using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orcamento
{
    public partial class PesquisarOrcamento : Form
    {
        public PesquisarOrcamento()
        {
            InitializeComponent();
        }

        private void btnNovoOrcamento_Click(object sender, EventArgs e)
        {
            NovoOrcamento novoorcamento = new NovoOrcamento();
            novoorcamento.Show();
        }
    }
}
