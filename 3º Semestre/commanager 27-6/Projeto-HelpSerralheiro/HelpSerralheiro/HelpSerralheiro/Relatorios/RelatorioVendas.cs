using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelpSerralheiro.Relatorios
{
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            DateTime dataInicial = Convert.ToDateTime(txtDataInicial.Text);
            // TODO: esta linha de código carrega dados na tabela 'bd_commanagerDataSet.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.bd_commanagerDataSet.vendas,dataInicial);

            this.reportViewer1.RefreshReport();
        }

        private void vendasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = Convert.ToDateTime(txtDataInicial.Text);
            // TODO: esta linha de código carrega dados na tabela 'bd_commanagerDataSet.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.bd_commanagerDataSet.vendas, dataInicial);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
