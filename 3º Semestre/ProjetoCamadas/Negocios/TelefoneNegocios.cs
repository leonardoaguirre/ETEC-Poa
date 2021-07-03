using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;


namespace Negocios
{
    public class TelefoneNegocios
    {
        


        AcessaSQLServer acessaSQLServer = new AcessaSQLServer();

        public string InserirTelefone(Telefone telefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                /*acessaSQLServer.AdicionarParametros("@CodTelefone", telefone.CodTelefone);*/
                acessaSQLServer.AdicionarParametros("@CodCliente", telefone.CodCliente);
                acessaSQLServer.AdicionarParametros("@CodTipoTelefone", telefone.CodTipoTelefone);
                acessaSQLServer.AdicionarParametros("@Numero", telefone.Numero);

                string codTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspInserirTelefone").ToString();

                return codTelefone;
                
            }
            catch (Exception ex)
            {

                return ex.Message;
               
            }


        }

        public string AlterarTelefone(Telefone telefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                /*acessaSQLServer.AdicionarParametros("@CodTelefone", telefone.CodTelefone);*/
                acessaSQLServer.AdicionarParametros("@CodCliente", telefone.CodCliente);
                acessaSQLServer.AdicionarParametros("@CodTipoTelefone", telefone.CodTipoTelefone);
                acessaSQLServer.AdicionarParametros("@Numero", telefone.Numero);

                string codTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspAlterarTelefone").ToString();

                return codTelefone;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string ExcluiTelefone(Telefone telefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@CodTelefone", telefone.CodTelefone);
                acessaSQLServer.AdicionarParametros("@CodCliente", telefone.CodCliente);
                acessaSQLServer.AdicionarParametros("@CodTipoTelefone", telefone.CodTipoTelefone);

                acessaSQLServer.AdicionarParametros("@Numero", telefone.Numero);

                string codTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspExcluirTelefone").ToString();

                return codTelefone;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public TelefoneColecao ConsutaTelefoneNumero(string numero)
        {
            try
            {
                //criar coleção de clientes
                TelefoneColecao telefonecolecao = new TelefoneColecao();

                //limpar e adicionar parametros
                acessaSQLServer.LimparParametros();
                acessaSQLServer.AdicionarParametros("@Numero", numero);

                //criar a tabela de dados que retornará do Banco de Dados
                DataTable dataTableTelefone = acessaSQLServer.ExecutaConsulta(CommandType.StoredProcedure, "uspConsultaNumeroTelefone");

                //Para cada item (linha) da tabela que torna deve-se criar um cliente

                foreach (DataRow linha in dataTableTelefone.Rows)
                {

                    Telefone telefone = new Telefone();

                    telefone.CodTelefone = Convert.ToInt32(linha["CodTelefone"]);
                    telefone.CodCliente = Convert.ToInt32(linha["CodCliente"]);
                    telefone.CodTipoTelefone = Convert.ToInt32(linha["CodTipoTelefone"]);
                    telefone.Numero = Convert.ToString(linha["Numero"]);

                    telefonecolecao.Add(telefone);


                }

                return telefonecolecao;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }





    }
}
