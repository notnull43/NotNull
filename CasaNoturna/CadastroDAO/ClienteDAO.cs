using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CadastroMODEL;

namespace CadastroDAO
{
    class ClienteDAO
    {
        private SqlConnection conexao;
        private List<ClienteMODEL> repositório;


        //Construtor
        public ClienteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
            repositório = new List<ClienteMODEL>();
        }



    }
}
