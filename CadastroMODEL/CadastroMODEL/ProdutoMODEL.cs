using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMODEL
{
    class ProdutoMODEL
    {
        #region ATRIBUTOS DO PRODUTO
        private int codigo;
        private string categoria;
        private string nome;
        private string fornecedor;
        private int precoCusto;
        private int precoVenda;
        private int estoque;
        #endregion

        #region PROPRIEDADES DO PRODUTO
        public int Codigo { get => codigo; set => codigo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public int PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Estoque { get => estoque; set => estoque = value; } 
        #endregion
    }

}
