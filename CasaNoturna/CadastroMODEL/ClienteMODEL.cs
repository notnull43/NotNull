using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMODEL
{
    public class ClienteMODEL
    {
       
        private int id;
        private string nome;
        private int telefone;
        private string logradouro;
        private int numero;
        private string bairro;
        private string municipio;
        private string estado;
        private DateTime dataNascimento;
        private int cpf;
        private int rg;
        private string sexo;
    

       
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        
    }
}
