using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
namespace ProjetoRelatorio
{
    public partial class ConsultaAgenda : Form
    {
        public ConsultaAgenda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            InserirAgenda ins = new InserirAgenda();
            ins.Show();
            
        }

        private void btnAlterarRegistro_Click(object sender, EventArgs e)
        {
            

            //verificação de linhas selecionadas para alteração
            if (dgvAgendamento.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado!");
                return;

            }
            else
            {
                //pega as colunas correspondentes de cada classe para a alteração
                Agenda agenda = dgvAgendamento.SelectedRows[0].DataBoundItem as Agenda;

                AlterarAgenda alter = new AlterarAgenda(agenda);

                alter.ShowDialog();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
             AgendaNegocios agendaNegocios = new AgendaNegocios();

            //instancia do metodo de consultar os dados no banco de dados
            AgendaColecao agendaColecao = agendaNegocios.ConsutaAgendaNome(txtNome.Text.Trim());




            dgvAgendamento.DataSource = null;
            dgvAgendamento.DataSource = agendaColecao;

            dgvAgendamento.Update();
            dgvAgendamento.Refresh();
        }

        private void ConsultaAgenda_Load(object sender, EventArgs e)
        {
            AgendaNegocios agendaNegocios = new AgendaNegocios();

            //instancia do metodo de consultar os dados no banco de dados
            AgendaColecao agendaColecao = agendaNegocios.ConsutaAgendaNome(txtNome.Text.Trim());




            dgvAgendamento.DataSource = null;
            dgvAgendamento.DataSource = agendaColecao;


            dgvAgendamento.Update();
            dgvAgendamento.Refresh();
        }

        private void btnExcluirRegistro_Click(object sender, EventArgs e)
        {
            //verificação de linhas selecionadas para exclusão
            if (dgvAgendamento.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado");
                return;

            }
            if (MessageBox.Show("Deseja excluir o registro selecionado:", "Excluir - Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //verificação de linhas selecionadas no datagridview para a exclusão
                Agenda agendaClick = dgvAgendamento.SelectedRows[0].DataBoundItem as Agenda;
                AgendaNegocios agendaNegocios = new AgendaNegocios();
                string retorno = agendaNegocios.ExcluiAgenda(agendaClick);

                    // retorno da exclusão se foi bem ou mal sucedida
                    int num = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro destruido com sucesso!");
                    btPesquisar2.PerformClick();

                


            }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GerarRelatorio ger = new GerarRelatorio();
            ger.ShowDialog();
        }
    }
}