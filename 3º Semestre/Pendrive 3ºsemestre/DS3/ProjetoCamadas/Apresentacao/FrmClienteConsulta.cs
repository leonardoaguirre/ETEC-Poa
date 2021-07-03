using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;


namespace Apresentacao
{
    public partial class FrmClienteConsulta : Form
    {
        public FrmClienteConsulta()
        {
            InitializeComponent();

            //evita que o datagrid crie as colunas com o retorno do BD
            dgvPrincipal.AutoGenerateColumns=false;
        }

        private void FrmClienteConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //instancia de classe e objetos
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
            TipoTelefoneNegocios tipoTelefoneNegocios = new TipoTelefoneNegocios();
            
            //instancia do metodo de consultar os dados no banco de dados
            ClienteColecao clienteColecao = clienteNegocios.ConsutaClienteNome(txtPesquisar.Text.Trim());
            TelefoneColecao telefoneColecao = telefoneNegocios.ConsutaTelefoneNumero(txtPesquisar.Text.Trim());
            TipoTelefoneColecao tipoTelefoneColecao = tipoTelefoneNegocios.ConsutaTipoTelefoneNumero(txtPesquisar.Text.Trim());
            
            //exibe as informações contidas na busca de dados que estão nos objetos diretamente no datagridview
            
            dgvPrincipal.DataSource = clienteColecao;
            /*dgvPrincipal.DataSource = telefoneColecao;
            dgvPrincipal.DataSource = tipoTelefoneColecao;*/
            dgvPrincipal.Refresh();
            dgvPrincipal.Update();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fecha o programa
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verificação de linhas selecionadas para exclusão
            if (dgvPrincipal.SelectedRows.Count <= 0) 
            {
                MessageBox.Show("Não há registro selecionado");
                return;

            }
            if (MessageBox.Show("Deseja excluir o registro selecionado:","Excluir - Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //verificação de linhas selecionadas no datagridview para a exclusão
                Cliente clienteClick = dgvPrincipal.SelectedRows[0].DataBoundItem as Cliente;
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.ExcluiCliente(clienteClick);

                Telefone telefoneClick = dgvPrincipal.SelectedRows[0].DataBoundItem as Telefone;
                TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                string retorno2 = telefoneNegocios.ExcluiTelefone(telefoneClick);

                TipoTelefone tipoTelefoneClick = dgvPrincipal.SelectedRows[0].DataBoundItem as TipoTelefone;
                TipoTelefoneNegocios tipoTelefoneNegocios = new TipoTelefoneNegocios();
                string retorno3 = tipoTelefoneNegocios.ExcluiTipoTelefone(tipoTelefoneClick);

                try
                {
                    // retorno da exclusão se foi bem ou mal sucedida
                    int num = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro destruido com sucesso!"+retorno);
                    btnPesquisar.PerformClick();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao excluir o registro!"+retorno);
                    
                }

                
            }
           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // envia o tipo de ação ao formulario de cadastro e os objetos vazios
            frmClienteCadastro frmCadastro = new frmClienteCadastro("inserir", null/*, null,null*/);
            frmCadastro.ShowDialog();

            btnPesquisar.PerformClick();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verificação de linhas selecionadas para alteração
            if (dgvPrincipal.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionado!");
                return;

            }
            else
            {
                //pega as colunas correspondentes de cada classe para a alteração
                Cliente clienteClick = dgvPrincipal.SelectedRows[0].DataBoundItem as Cliente;
                /*Telefone telefoneClick = dgvPrincipal.SelectedRows[0].DataBoundItem as Telefone;
                TipoTelefone tipoTelefoneClick = dgvPrincipal.SelectedRows[0].DataBoundItem as TipoTelefone;*/

                frmClienteCadastro frmCadastro = new frmClienteCadastro("alterar", clienteClick/*, telefoneClick, tipoTelefoneClick*/);

                frmCadastro.ShowDialog();

                btnPesquisar.PerformClick();
            }
        }
    }
}
