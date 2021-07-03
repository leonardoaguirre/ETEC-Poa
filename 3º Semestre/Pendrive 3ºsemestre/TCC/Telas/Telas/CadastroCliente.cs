using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telas
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            String nome, sexo, cpf, rg, dataNascimento, rua, bairro, cidade, cep, uf, complemento, email, telefone, celular, observacoes;

            nome = txtNome.Text.Trim();
            sexo = txtSexo.Text.Trim();
            cpf = txtCPF.Text.Trim();
            rg = txtRG.Text.Trim();
            dataNascimento = txtDataNascimento.Text.Trim();
            rua = txtRua.Text.Trim();
            bairro = txtBairro.Text.Trim();
            cidade = txtCidade.Text.Trim();
            cep = txtCEP.Text.Trim();
            uf = txtUF.Text.Trim();
            complemento = txtComplemento.Text.Trim();
            email = txtEmail.Text.Trim();
            telefone = txtTelefone.Text.Trim();
            celular = txtCelular.Text.Trim();
            observacoes = txtObservacoes.Text.Trim();

            MessageBox.Show("" + nome + sexo + cpf + rg + dataNascimento + rua + bairro + cidade + cep + uf + complemento + email + telefone + celular + observacoes);
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSexo.SelectedIndex = -1;
            txtCPF.Clear();
            txtRG.Clear();
            txtDataNascimento.Text = Convert.ToString(DateTime.Now);
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtUF.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtObservacoes.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
               
            string Config = "server=127.0.0.1;userid=root;database=cep";
            string cep = txtCEP.Text.Trim();
            string UF = txtUF.Text.Trim();
                

        MySqlConnection conex = new MySqlConnection(Config);
        conex.Open();
        MySqlCommand Query = new MySqlCommand("SELECT * FROM "+UF+" WHERE cep = '"+cep+"';", conex);

                try

                {
                MySqlDataReader leitor = Query.ExecuteReader();
                if(leitor.HasRows)
                {
                    txtRua.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();

                    leitor.Read(); //lê a primeira row da pesquisa
                    txtRua.Text = leitor["logradouro"].ToString();
                    txtBairro.Text = leitor["bairro"].ToString();
                    txtCidade.Text = leitor["cidade"].ToString();

                }

                }

                 catch (Exception ex)
                                {
                                    ex.Message.ToString();
                                }

                finally{conex.Close();}

                }
            }
        


        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
