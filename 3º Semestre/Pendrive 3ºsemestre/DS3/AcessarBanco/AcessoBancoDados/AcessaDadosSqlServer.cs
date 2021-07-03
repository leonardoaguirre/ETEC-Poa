using System;
using System.Data;
using System.Data.SqlClient;
//tirei o system
using AcessoBancoDados.Properties;


namespace AcessoBancoDados
{
    public class AcessaDadosSqlServer
    {

        private SqlConnection CriarConexao()
        {
            //Adicionou properties                               //nome da string de conexao
            return new SqlConnection(Properties.Settings.Default.StringConexao);
        }
        
                                                                //acrescentei o new
        private SqlParameterCollection SqlParameterCollection = new SqlCommand().Parameters;

        public object settings { get; private set; }

        public void LimparParametros()
        {
            SqlParameterCollection.Clear();
        }

        public void AdicionaParametros (String nomeParametro, object valorParam)
        {
            SqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParam));
        }


        private SqlCommand PreencheSqlCommand(CommandType commtype,String minhaUsp)
        {
            SqlConnection sqlconnection = CriarConexao();
            sqlconnection.Open();
            SqlCommand sqlcommand = sqlconnection.CreateCommand();
            //usou parametro do metodo
            sqlcommand.CommandType = commtype;
            sqlcommand.CommandText = minhaUsp;
            sqlcommand.CommandTimeout = 3600;

            foreach(SqlParameter sqlparam in SqlParameterCollection)
            {
                sqlcommand.Parameters.Add(new SqlParameter(SqlParameter.ParameterName, SqlParameter.value));
            }

            return sqlcommand;
        }

        public object ManipulaDados (CommandType commandtype, string minhaUsp)
        {
            try
            {
                SqlCommand sqlcommand = PreencheSqlCommand(commandtype, minhaUsp);
                return sqlcommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }





    }
}
