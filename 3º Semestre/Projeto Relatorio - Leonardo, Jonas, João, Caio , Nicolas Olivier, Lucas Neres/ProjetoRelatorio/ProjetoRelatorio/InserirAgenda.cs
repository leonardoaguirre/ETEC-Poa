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
    public partial class InserirAgenda : Form
    {
        public InserirAgenda()
        {
            InitializeComponent();
        }
       

        private void btnSair_Click(object sender, EventArgs e)
        {
            ConsultaAgenda cons = new ConsultaAgenda();
            cons.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            AgendaNegocios agendaNegocios = new AgendaNegocios();

            if ((txtLembrete.Text.Length <= 4) || (txtVendedor.Text.Length <=3))
            {
                MessageBox.Show("Por favor preencha os campos corretamente!");
            }
            else
            {
                string Importancia="";
                if (rbEu.Checked) { Importancia = rbEu.Text; }
                if (rbTodos.Checked) { Importancia = rbTodos.Text; }
                if (radioButton1.Checked) { Importancia = radioButton1.Text; }
                if (radioButton2.Checked) { Importancia = radioButton2.Text; }


                // preenchimento de informações dos campos de textos
                agenda.Nome = txtVendedor.Text.Trim();
                agenda.Lembrete = txtLembrete.Text;
                agenda.Data = txtData.Value;
                agenda.Hora = txtHora.Text.Trim();
                agenda.Importancia = Importancia;
                agenda.Observacoes = txtObs.Text;


                //metodo de inserção ao banco de dados
                string retorno = agendaNegocios.InserirAgenda(agenda);




                    try
                    {
                        //validação de operação bem ou mal sucedida

                        int num = Convert.ToInt32(retorno);
                        MessageBox.Show("Registro inserido com sucesso!\n" + "Registro: " + retorno);

                   
                    this.Close();
                    }
                    catch
                    {

                        MessageBox.Show("Erro ao inserir o cliente!\n" + retorno);
                    }
                }
            }
    }
}
