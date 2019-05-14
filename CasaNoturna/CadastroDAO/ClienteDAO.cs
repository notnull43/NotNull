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
        private List<ClienteMODEL> repositorio;


        //Construtor
        public ClienteDAO(SqlConnection conexao)
        {
            this.conexao = conexao;
            repositorio = new List<ClienteMODEL>();
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
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Rg", cliente.Rg);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
            }
            return retorno;
        }

        public List<ClienteMODEL> Pesquisar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM Clients";

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    repositorio.Clear();
                    while(reader.Read())
                    {
                        repositorio.Add(new ClienteMODEL()
                        {
                            Id = Convert.ToInt32(reader["IdCli"].ToString()),
                            Nome = reader["NamCli"].ToString(),
                            Telefone = reader["CelCli"].ToString(),
                            Logradouro = reader["AdrCli"].ToString(),
                            Numero =reader["NumCli"].ToString(),
                            Bairro = reader["DisCli"].ToString(),
                            Municipio = reader["CitCli"].ToString(),
                            Estado = reader["StaCli"].ToString(),
                            DataNascimento = DateTime.Parse(reader["BirthCli"].ToString()),
                            Cpf = reader["CPFCli"].ToString(),
                            Rg = reader["RGCli"].ToString(),
                            Sexo = char.Parse(reader["SEXO"].ToString())                                                                                
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return repositorio;
        }

        public List<ClienteMODEL> Pesquisar(string nome)
        {
            var resultado = repositorio.Where(p => p.Nome.Contains(nome));
            return resultado.ToList();
        }

        public ClienteMODEL Consultar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM Clients WHERE IdCli = @IdCli";

            ClienteMODEL cliente = null;

            try
            {
                cmd.Parameters.AddWithValue(@"IdCli", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        cliente = new ClienteMODEL()
                        {
                            Id = Convert.ToInt32(reader["IdCli"].ToString()),
                            Nome = reader["NamCli"].ToString(),
                            Telefone = reader["CelCli"].ToString(),
                            Logradouro = reader["AdrCli"].ToString(),
                            Numero = reader["NumCli"].ToString(),
                            Bairro = reader["DisCli"].ToString(),
                            Municipio = reader["CitCli"].ToString(),
                            Estado = reader["StaCli"].ToString(),
                            DataNascimento = DateTime.Parse(reader["BirthCli"].ToString()),
                            Cpf = reader["CPFCli"].ToString(),
                            Rg = reader["RGCli"].ToString(),
                            Sexo = char.Parse(reader["SEXO"].ToString())
                        };

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            return cliente;
        }   

        public bool Alterar(ClienteMODEL cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"UPDATE Clients
                                    SET NamCli = @Nome,
                                        AdrCli = @Logradouro,
                                        NumCli = @Numero,
                                        DisCli = @Bairro,
                                        CitCli = @Municipio,
                                        StaCli = @Estado,
                                        BirthCli = @DataNascimento,
                                        CelCli = @Telefone,
                                        CPFCli = @Cpf,
                                        RGCli = @Rg,
                                        SEXO = @Sexo   
                                    WHERE IdCli = @Id";
            bool retorno;
            try
            {
                cmd.Parameters.AddWithValue("@Id", cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@Rg", cliente.Rg);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.ExecuteNonQuery();

                retorno =  true;
            }
            catch (Exception ex)
            { retorno = false; }

            return retorno;
        }


        public bool Deletar(ClienteMODEL cliente)
        {
            return Deletar(cliente.Id);
        }

        public bool Deletar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "DELETE FROM Clients WHERE IdCli = @IdCli";
            bool retorno;

            try
            {
                cmd.Parameters.AddWithValue("@IdCli", id);
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception)
            {retorno = false;}

            return retorno;
        }
    }
}
