using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroMODEL;
using System.Data.SqlClient;

namespace CadastroDAO
{
    class ProdutoDAO
    {
		private SqlConnection conexao;
		private List<ProdutoMODEL> repositorio;


		//Construtor
		public ProdutoDAO(SqlConnection conexao)
		{
			this.conexao = conexao;
			repositorio = new List<ProdutoMODEL>();
		}

		public bool Inserir(ProdutoMODEL produto)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conexao;
			cmd.CommandText = @"INSERT INTO Products
                                    (NamProd, CatProd, PriceCost, PriceSale, StockProd)
                                    VALUES (@Nome, @Categoria, @PrecoCusto, @PrecoVenda, @Estoque)";
			bool retorno;
			try
			{
				cmd.Parameters.AddWithValue("@Nome", produto.Nome);
				cmd.Parameters.AddWithValue("@Categoria", produto.Categoria);
				cmd.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
				cmd.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
				cmd.Parameters.AddWithValue("@Estoque", produto.Estoque);
				
				cmd.ExecuteNonQuery();
				retorno = true;
			}
			catch (Exception)
			{
				retorno = false;
			}
			return retorno;
		}

		public List<ProdutoMODEL> Pesquisar()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conexao;
			cmd.CommandText = @"SELECT * FROM Products";

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					repositorio.Clear();
					while (reader.Read())
					{
						repositorio.Add(new ProdutoMODEL()
						{
							Id = Convert.ToInt32(reader["IdProd"].ToString()),
							Nome = reader["NamProd"].ToString(),
							Categoria = reader["CatCli"].ToString(),
							PrecoCusto = Convert.ToDouble(reader["PriceCost"].ToString()),
							PrecoVenda = Convert.ToDouble(reader["PriceSale"].ToString()),
							Estoque = Convert.ToInt32(reader["StockProd"].ToString())							
						});
					}
				}
			}
			catch (Exception)
			{throw;}

			return repositorio;
		}

		public List<ProdutoMODEL> Pesquisar(string nome)
		{
			var resultado = repositorio.Where(p => p.Nome.Contains(nome));
			return resultado.ToList();
		}

		public ProdutoMODEL Consultar(int id)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conexao;
			cmd.CommandText = @"SELECT * FROM Clients WHERE IdCli = @IdCli";

			ProdutoMODEL produto = null;

			try
			{
				cmd.Parameters.AddWithValue(@"IdProd", id);
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						reader.Read();
						produto = new ProdutoMODEL()
						{
							Id = Convert.ToInt32(reader["IdProd"].ToString()),
							Nome = reader["NamProd"].ToString(),
							Categoria = reader["CatCli"].ToString(),
							PrecoCusto = Convert.ToDouble(reader["PriceCost"].ToString()),
							PrecoVenda = Convert.ToDouble(reader["PriceSale"].ToString()),
							Estoque = Convert.ToInt32(reader["StockProd"].ToString())
						};

					}

				}
			}
			catch (Exception)
			{throw;}

			return produto;
		}

		public bool Alterar(ProdutoMODEL produto)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conexao;
			cmd.CommandText = @"UPDATE Products
                                    SET NamProd = @Nome,
                                        CatProd = @Categoria,
										PriceCost = @PrecoCusto,
										PriceSale = @PrecoVenda
										StockProd = @Estoque,
                                    WHERE IdProd = @Id";
			bool retorno;
			try
			{
				cmd.Parameters.AddWithValue("@Id", produto.Id);
				cmd.Parameters.AddWithValue("@Nome", produto.Nome);
				cmd.Parameters.AddWithValue("@Categoria", produto.Categoria);
				cmd.Parameters.AddWithValue("@PrecoCusto", produto.PrecoCusto);
				cmd.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
				cmd.Parameters.AddWithValue("@Estoque", produto.Estoque);
				cmd.ExecuteNonQuery();

				retorno = true;
			}
			catch (Exception)
			{ retorno = false; }

			return retorno;
		}


		public bool Deletar(ProdutoMODEL produto)
		{
			return Deletar(produto.Id);
		}

		public bool Deletar(int id)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conexao;
			cmd.CommandText = "DELETE FROM Clients WHERE IdCli = @Id";
			bool retorno;

			try
			{
				cmd.Parameters.AddWithValue("@IdProd", id);
				cmd.ExecuteNonQuery();
				retorno = true;
			}
			catch (Exception)
			{ retorno = false; }

			return retorno;
		}
	}
}
