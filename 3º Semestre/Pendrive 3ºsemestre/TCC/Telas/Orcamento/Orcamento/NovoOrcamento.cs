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
    public partial class NovoOrcamento : Form
    {
        public NovoOrcamento()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            String clienteOrcamento = txtClienteOrcamento.Text.Trim();
            String vendedorOrcamento = txtVendedorOrcamento.Text.Trim();
            int DescontoOrcamento = Convert.ToInt32(txtDescontoOrcamento.Text.Trim());
            int FreteOrcamento = Convert.ToInt32(txtFreteOrcamento.Text.Trim());



        }
    }
}
