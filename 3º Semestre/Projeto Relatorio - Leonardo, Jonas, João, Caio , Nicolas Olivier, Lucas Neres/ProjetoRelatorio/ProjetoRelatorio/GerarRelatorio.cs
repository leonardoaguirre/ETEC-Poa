using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRelatorio
{
    public partial class GerarRelatorio : Form
    {
        public GerarRelatorio()
        {
            InitializeComponent();
        }

        private void GerarRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.uspConsultaAgenda' table. You can move, or remove it, as needed.
            this.uspConsultaAgendaTableAdapter.Fill(this.DataSet1.uspConsultaAgenda, txtNome.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
