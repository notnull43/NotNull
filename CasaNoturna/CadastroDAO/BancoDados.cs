using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CadastroDAO
{
    public static class BancoDados
    {
        private static ClienteDAO clienteDAO;
        private static SqlConnection conexao;

        public static SqlConnection Conexao
        {
            get
            {
                conexao = conexao ?? new SqlConnection(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString);

                if (conexao.State == System.Data.ConnectionState.Closed)
                    conexao.Open();

                return conexao;
            }
        }


        public static ClienteDAO Clientes
        {
            get
            {
                clienteDAO = clienteDAO ?? new ClienteDAO(conexao);
                return clienteDAO;
            }
            set { clienteDAO = value; }
        }
    }
}
