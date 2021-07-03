using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {

        AcessaSQLServer acessaSQLServer = new AcessaSQLServer();

        public string InserirCliente(Cliente cliente)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                /*acessaSQLServer.AdicionarParametros("@CodCliente", cliente.CodCliente);*/
                acessaSQLServer.AdicionarParametros("@Nome", cliente.Nome);
                acessaSQLServer.AdicionarParametros("@CPF", cliente.CPF);
                acessaSQLServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
             

                string codCliente = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspInserirCliente").ToString();

                return codCliente;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string AlterarCliente(Cliente cliente)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@CodCliente", cliente.CodCliente);
                acessaSQLServer.AdicionarParametros("@Nome", cliente.Nome);
                acessaSQLServer.AdicionarParametros("@CPF", cliente.CPF);
                acessaSQLServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);

                string codCliente = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspAlterarCliente").ToString();

                return codCliente;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public string ExcluiCliente(Cliente cliente)
        {
            try
            {
                acessaSQLServer.LimparParametros();

                acessaSQLServer.AdicionarParametros("@CodCliente", cliente.CodCliente);


                string codCliente = acessaSQLServer.manipulaDados
                (CommandType.StoredProcedure, "uspExcluirCliente").ToString();

                return codCliente;

            }
            catch (Exception ex)
            {

                return ex.Message;

            }


        }

        public ClienteColecao ConsutaClienteNome(string nome)
        {
            try
            {
                //criar coleção de clientes
                ClienteColecao clientecolecao = new ClienteColecao();

                //limpar e adicionar parametros
                acessaSQLServer.LimparParametros();
                acessaSQLServer.AdicionarParametros("@Nome" , nome);

                //criar a tabela de dados que retornará do Banco de Dados
                DataTable dataTableCliente = acessaSQLServer.ExecutaConsulta( CommandType.StoredProcedure, "uspConsultaClienteNome");

                //Para cada item (linha) da tabela que torna deve-se criar um cliente

                foreach (DataRow linha in dataTableCliente.Rows) 
                {

                    Cliente cliente = new Cliente();

                    cliente.CodCliente = Convert.ToInt32(linha["CodCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);

                    clientecolecao.Add(cliente);
                
                
                }

                return clientecolecao;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


 


    }
}
