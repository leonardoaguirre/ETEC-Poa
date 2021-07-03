using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class TipoTelefoneNegocios
    {

        AcessaSQLServer acessaSQLServer = new AcessaSQLServer();

        public string InserirTipoTelefone(TipoTelefone tipotelefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                /*acessaSQLServer.AdicionarParametros("@CodTipoTelefone", tipotelefone.CodTipoTelefone);*/
                acessaSQLServer.AdicionarParametros("@Descricao", tipotelefone.Descricao);
   

                string codTipoTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspInserirTipoTelefone").ToString();

                return codTipoTelefone;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string AlterarTipoTelefone(TipoTelefone tipotelefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                /*acessaSQLServer.AdicionarParametros("@CodTipoTelefone", tipotelefone.CodTipoTelefone);*/
                acessaSQLServer.AdicionarParametros("@Descricao", tipotelefone.Descricao);


                string codTipoTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspAlterarTipoTelefone").ToString();

                return codTipoTelefone;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string ExcluiTipoTelefone(TipoTelefone tipotelefone)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@CodTipoTelefone", tipotelefone.CodTipoTelefone);
                acessaSQLServer.AdicionarParametros("@Descricao", tipotelefone.Descricao);


                string codTipoTelefone = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspExcluirTipoTelefone").ToString();

                return codTipoTelefone;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public TipoTelefoneColecao ConsutaTipoTelefoneNumero(string tiponumero)
        {
            try
            {
                //criar coleção de clientes
                TipoTelefoneColecao tipotelefonecolecao = new TipoTelefoneColecao();

                //limpar e adicionar parametros
                acessaSQLServer.LimparParametros();
                acessaSQLServer.AdicionarParametros("@Descricao", tiponumero);

                //criar a tabela de dados que retornará do Banco de Dados
                DataTable dataTableTipoTelefone = acessaSQLServer.ExecutaConsulta(CommandType.StoredProcedure, "uspConsultaNumeroTipoTelefone");

                //Para cada item (linha) da tabela que torna deve-se criar um cliente

                foreach (DataRow linha in dataTableTipoTelefone.Rows)
                {

                    TipoTelefone tipotelefone = new TipoTelefone();

                    tipotelefone.CodTipoTelefone = Convert.ToInt32(linha["CodTipoTelefone"]);
                    tipotelefone.Descricao = Convert.ToString(linha["Descricao"]);

                    tipotelefonecolecao.Add(tipotelefone);


                }

                return tipotelefonecolecao;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }





    }
}
