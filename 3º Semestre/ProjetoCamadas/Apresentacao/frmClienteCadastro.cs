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
    public partial class frmClienteCadastro : Form
    {
        
        string tipoDaAcaoGlobal;
        int codClienteGlobal, codTelefoneGlobal, codTipoTelefoneGlobal;

        //instancia das classes e objetos necessarios do projeto
        Cliente cliente = new Cliente();
        Telefone telefone = new Telefone();
        TipoTelefone tipoTelefone = new TipoTelefone();

        ClienteNegocios clienteNegocios = new ClienteNegocios();
        TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
        TipoTelefoneNegocios tipoTelefoneNegocios = new TipoTelefoneNegocios();


        public frmClienteCadastro(string tipoAcao, Cliente cliente, Telefone telefone, TipoTelefone tipoTelefone)
        {
            InitializeComponent();

            tipoDaAcaoGlobal = tipoAcao;

            if (cliente == null)
            {
                // se o cliente foi recebido vazio todos recebem o valor 0
                codClienteGlobal = 0;
                codTelefoneGlobal = 0;
                codTipoTelefoneGlobal = 0;
            }
            else
            {
                //pega os codigos correspondentes ao banco de dados
                codClienteGlobal = cliente.CodCliente;
                codTelefoneGlobal = telefone.CodTelefone;
                codTipoTelefoneGlobal = tipoTelefone.CodTipoTelefone;
            }

            if (tipoAcao == "inserir")
            {
                this.Text = "Cliente - Inserir";
            }
            else
            {
                this.Text = "Cliente - Alterar";
                //inserção dos valores digitados nos campos de textos para as classes de inserção ao banco de dados
                txtCodigo.Text = cliente.CodCliente.ToString();
                txtNome.Text = cliente.Nome;
                maskCPF.Text = cliente.CPF;
                dtpNascimento.Value = cliente.DataNascimento;

                maskTelefone.Text = telefone.Numero;
                txtTipoTelefone.Text = tipoTelefone.Descricao;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validação de campos incorretos
            if ((maskCPF.Text.Length <= 10) || (maskTelefone.Text.Length <= 11) || (txtTipoTelefone.Text.Length <= 2))
            {
                MessageBox.Show("Por favor preencha os campos corretamente!");
            }
            else
            {
                

                
                // preenchimento de informações dos campos de textos
               /* cliente.CodCliente = 0;*/
                cliente.Nome = txtNome.Text.Trim();
                cliente.CPF = maskCPF.Text;
                cliente.DataNascimento = dtpNascimento.Value;

                /*telefone.CodTelefone = codigo;*/
                
                
                telefone.Numero = maskTelefone.Text;

                /*tipoTelefone.CodTipoTelefone = codigo;*/
                tipoTelefone.Descricao = txtTipoTelefone.Text;


                if (tipoDaAcaoGlobal == "inserir")
                {
                    //metodo de inserção ao banco de dados
                    string retorno3 = tipoTelefoneNegocios.InserirTipoTelefone(tipoTelefone);

                    string retorno = clienteNegocios.InserirCliente(cliente);
                    // variaveis que recebem as chaves estrangeiras para a inserçãao na tabela telefones
                    int codiCliente = Convert.ToInt32(retorno);
                    telefone.CodCliente = codiCliente;
                    int codiTelefone = Convert.ToInt32(retorno3);
                    telefone.CodTipoTelefone = codiTelefone;
                    //metodo de inserção ao banco de dados
                    string retorno2 = telefoneNegocios.InserirTelefone(telefone);

                    
                    

                    try
                    {
                        //validação de operação bem ou mal sucedida

                        int num = Convert.ToInt32(retorno);
                        MessageBox.Show("Registro inserido com sucesso!\n" + "Registro: " + retorno + retorno2 + retorno3);

                        btnSalvar.Enabled = false;
                    }
                    catch
                    {

                        MessageBox.Show("Erro ao inserir o cliente!\n" + retorno + retorno2 + retorno3);
                    }
                }

                else
                {
                    //caso a operação for de alterar, pega o codigoGlobal de cada primary key para alteração
                    cliente.CodCliente = codClienteGlobal;
                    telefone.CodTelefone = codTelefoneGlobal;
                    tipoTelefone.CodTipoTelefone = codTipoTelefoneGlobal;
                }
                string retorno4 = clienteNegocios.AlterarCliente(cliente);
                string retorno5 = telefoneNegocios.AlterarTelefone(telefone);
                string retorno6 = tipoTelefoneNegocios.AlterarTipoTelefone(tipoTelefone);

                try
                    {
                        int num = Convert.ToInt32(retorno4);

                        MessageBox.Show("Registro alterado com sucesso!");
                    }
                    catch
                    {

                        MessageBox.Show("Erro ao registar!");
                    }
                }

            }
        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fecha o formulario
           this.Close();
        }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}

