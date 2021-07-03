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
    public partial class InserirDespesa : Form
    {
        public InserirDespesa()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string nomeDespesa = txtDespesa.Text;
            string dataVencimento = txtDataVencimento.Text;
            decimal valorDespesa = Convert.ToDecimal(txtValorDespesa.Text);
            string observacoes = txtObservacoes.Text;

            string Config = "server=127.0.0.1;userid=root;database=bd_commaneger";

            MySqlConnection conex = new MySqlConnection(Config);
            conex.Open();
            MySqlCommand Query = new MySqlCommand("INSERT INTO despesas (DataVencimento, NomeDespesa, Observacoes, Valor)" + "VALUES('" + dataVencimento + "', '" + nomeDespesa + "', '" + observacoes + "', '" + valorDespesa + "');", conex);
            Query.ExecuteNonQuery();
            Query.Connection = conex;
            if (conex.State == ConnectionState.Open)
            {
                MessageBox.Show("Cadastrado com sucesso!");
                txtDespesa.Clear(); txtObservacoes.Clear(); txtValorDespesa.Clear();
                FinancasDespesas despesas = new FinancasDespesas();
                despesas.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
            conex.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtDespesa.Clear(); txtObservacoes.Clear(); txtValorDespesa.Clear(); txtDataVencimento.Text =Convert.ToString(DateTime.Now);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            FinancasDespesas despesa = new FinancasDespesas();
            despesa.Show();
            this.Close();
        }
    }
}

