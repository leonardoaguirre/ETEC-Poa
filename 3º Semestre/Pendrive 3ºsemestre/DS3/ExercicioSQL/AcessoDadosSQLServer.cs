using System;
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
      

        private SqlConnection CriarConexao()
        {
            return new SqlConnection(settings default ConectaSqlServer);
        }
        private SqlParameterCollection SqlParameterCollection = SqlCommand().Parameters;

        public void LimparParametros()
        {
            SqlParameterCollection.Clear();
        }
        public void AdicionaParametros(string NomeParametro, object ValorParam)
        {
            SqlParameterCollection.add(new SqlParameter(NomeParametro, ValorParam));
        }
        private SqlCommand PreencheSqlCommand(CommandType Commtype, string minhaUSP)
        {
            SqlConnection SqlConnection = CriarConexao();
            SqlConnection.open();
            SqlCommand SqlCommand = SqlConnection.creatCommand();
            SqlCommand.CommandType = CommandType;
            SqlCommand.CommandText = minhaUSP;
            SqlCommand.CommandTimeOut = 3600;
            foreach (SqlParameter SqlParam in SqlParameterCollection)
            {
                SqlCommand.Parameters.add(new SqlParameter(SqlParameterCollection.PameterName, SqlParameterCollection.value));
            }
            return SqlCommand;
        }

        //inserir, alterar e excluir
        public object manipulaDados(CommandType, CommandType, string minhaUSP)
        {
            try
            {
                SqlCommand SqlCommand = PreencheSqlCommand (CommandType, minhaUSP);
                return SqlCommand.ExecuteScalar();

            }
            catch(Exception ex)
            {
                throw new Exception(ex: message);
            }
        }
    } 
}
