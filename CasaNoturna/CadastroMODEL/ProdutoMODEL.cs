using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroMODEL
{
    class ProdutoMODEL
    {
        #region ATRIBUTOS DOS PRODUTOS
        private int codigo;
        private string categoria;
        private string nome;
        private string fornecedor;
        private decimal precoCusto;
        private decimal precoVenda;
        private int estoque;
        #endregion

        #region PROPRIEDADES DOS PRODUTOS
        public int Codigo { get => codigo; set => codigo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public decimal PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public decimal PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Estoque { get => estoque; set => estoque = value; } 
        #endregion
    }

}
