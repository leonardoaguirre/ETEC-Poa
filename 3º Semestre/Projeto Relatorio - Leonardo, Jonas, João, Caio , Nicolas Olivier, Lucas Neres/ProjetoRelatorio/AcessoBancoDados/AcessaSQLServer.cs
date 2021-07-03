using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;


namespace AcessoBancoDados
{
    public class AcessaSQLServer
    {
        private SqlConnection criarConexao()
        {
            return new SqlConnection(Settings.Default.conectaSQLServer);
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        private SqlCommand PreencheSqlCommand(CommandType commandType, string minhaUSP)
        {
            try
            {

                SqlConnection sqlConnection = criarConexao();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = minhaUSP;

                sqlCommand.CommandTimeout = 3600;


                foreach (SqlParameter SQLParam in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(SQLParam.ParameterName, SQLParam.Value));
                }
                return sqlCommand;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //inserir, alterar e excluir
        public object manipulaDados(CommandType commandType, string minhaUSP)
        {
            try
            {
                SqlCommand sqlCommand = PreencheSqlCommand(commandType, minhaUSP);

                return sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ExecutaConsulta(CommandType commandType, string minhaUSP)
        {
            try
            {
                SqlCommand sqlCommand = PreencheSqlCommand(commandType, minhaUSP);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
