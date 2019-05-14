using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMODEL
{
    public class ProdutoMODEL
    {
        #region ATRIBUTOS DO PRODUTO
        private int id;
        private string categoria;
        private string nome;
        private string fornecedor;
        private double precoCusto;
        private double precoVenda;
        private int estoque;
        #endregion

        #region PROPRIEDADES DO PRODUTO
        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public double PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        #endregion
    }
}
