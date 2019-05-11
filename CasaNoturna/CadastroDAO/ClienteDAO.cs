using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CadastroMODEL;

namespace CadastroDAO
{
    public class ClienteDAO
    {
        private SqlConnection conexao;
        private List<ClienteMODEL> repositório;


        //Construtor
        public ClienteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
            repositório = new List<ClienteMODEL>();
        }

        public bool Inserir(ClienteMODEL cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT INTO Clients
                                    (NamCli, AdrCli, NumCli, DisCli, CitCli, StaCli, BirthCli, CelCli, CPFCli, RGCli, SEXO)
                                    VALUES (@Nome, @Logradouro, @Numero, @Bairro, @Municipio, @Estado, @DataNascimento, @Telefone, @Cpf, @Rg, @Sexo)";
            bool retorno;
            try
            {
                cmd.Parameters.AddWithValue("@NamCli", cliente.Nome);
                cmd.Parameters.AddWithValue("@AdrCli", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@NumCli", cliente.Numero);
                cmd.Parameters.AddWithValue("@NumCli", cliente.Bairro);
                cmd.Parameters.AddWithValue("@CitCli", cliente.Municipio);
                cmd.Parameters.AddWithValue("@StaCli", cliente.Estado);
                cmd.Parameters.AddWithValue("@BirthCli", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@CelCli", cliente.Telefone);
                cmd.Parameters.AddWithValue("@CPFCli", cliente.Cpf);
                cmd.Parameters.AddWithValue("@RGCli", cliente.Rg);
                cmd.Parameters.AddWithValue("@SEXO", cliente.Sexo);
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }

        public void Pesquisar()
        {

        }

        public void Consultar()
        {

        }

        public void Alterar()
        {

        }

        public void Deletar()
        {

        }
    }
}
