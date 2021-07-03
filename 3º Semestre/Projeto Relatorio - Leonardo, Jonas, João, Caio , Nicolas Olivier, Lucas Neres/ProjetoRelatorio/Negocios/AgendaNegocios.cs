using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class AgendaNegocios
    {
        AcessaSQLServer acessaSQLServer = new AcessaSQLServer();

        public string InserirAgenda(Agenda agenda)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@Lembrete", agenda.Lembrete);
                acessaSQLServer.AdicionarParametros("@Nome", agenda.Nome);
                acessaSQLServer.AdicionarParametros("@Importancia", agenda.Importancia);
                acessaSQLServer.AdicionarParametros("@Data", agenda.Data);
                acessaSQLServer.AdicionarParametros("@Hora", agenda.Hora);
                acessaSQLServer.AdicionarParametros("@Observacoes", agenda.Observacoes);


                string codAgenda = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspInserirAgenda").ToString();

                return codAgenda;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string AlterarAgenda(Agenda agenda)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@Id", agenda.Id);
                acessaSQLServer.AdicionarParametros("@Lembrete", agenda.Lembrete);
                acessaSQLServer.AdicionarParametros("@Nome", agenda.Nome);
                acessaSQLServer.AdicionarParametros("@Importancia", agenda.Importancia);
                acessaSQLServer.AdicionarParametros("@Data", agenda.Data);
                acessaSQLServer.AdicionarParametros("@Hora", agenda.Hora);
                acessaSQLServer.AdicionarParametros("@Observacoes", agenda.Observacoes);

                string codAgenda = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspAlterarAgenda").ToString();

                return codAgenda;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string ExcluiAgenda(Agenda agenda)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@Id", agenda.Id);


                string codAgenda = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspExcluirAgenda").ToString();

                return codAgenda;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public AgendaColecao ConsutaAgendaNome(string nome)
        {
            try
            {
                //criar coleção de clientes
                AgendaColecao agendacolecao = new AgendaColecao();

                //limpar e adicionar parametros
                acessaSQLServer.LimparParametros();
                acessaSQLServer.AdicionarParametros("@Nome", nome);

                //criar a tabela de dados que retornará do Banco de Dados
                DataTable dataTableAgenda = acessaSQLServer.ExecutaConsulta(CommandType.StoredProcedure, "uspConsultaAgenda");

                //Para cada item (linha) da tabela que torna deve-se criar um cliente

                foreach (DataRow linha in dataTableAgenda.Rows)
                {

                    Agenda agenda = new Agenda();

                    agenda.Id = Convert.ToInt32(linha["Id"]);
                    agenda.Lembrete = Convert.ToString(linha["Lembrete"]);
                    agenda.Nome = Convert.ToString(linha["Nome"]);
                    agenda.Importancia = Convert.ToString(linha["Importancia"]);
                    agenda.Data = Convert.ToDateTime(linha["Data"]);
                    agenda.Hora = Convert.ToString(linha["Hora"]);
                    agenda.Observacoes = Convert.ToString(linha["Observacoes"]);




                    agendacolecao.Add(agenda);


                }

                return agendacolecao;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
