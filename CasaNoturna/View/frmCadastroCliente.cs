using CadastroDAO;
using CadastroMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFORM
{
    public partial class frmCadastroCliente : Form
    {
        private int? codigo;

        public frmCadastroCliente(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

        public frmCadastroCliente(string titulo, int codigo) : this(titulo)
        {
            this.codigo = codigo;
            var cliente = BancoDados.Clientes.Consultar(codigo);
            txtNome.Text = cliente.Nome;
            txtSexo.Text = cliente.Sexo;
            txtDataNascimento.Text = cliente.DataNascimento.ToString();
            txtCpf.Text = cliente.Cpf.ToString();
            txtRg.Text = cliente.Rg.ToString();
            txtTelefone.Text = cliente.ToString();
            txtLogradouro.Text = cliente.Logradouro;
            txtNumero.Text = cliente.Numero.ToString();
            txtBairro.Text = cliente.Bairro;
            txtMunicipio.Text = cliente.Municipio;
            cbxEstado.Text = cliente.Estado;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string msgErro = "";

            msgErro += string.IsNullOrWhiteSpace(txtNome.Text) ? "* Nome precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtSexo.Text) ? "* Sexo precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtDataNascimento.Text) ? "* Data de nascimento precisa ser informada.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtCpf.Text) ? "* CPF precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtRg.Text) ? "* RG precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtTelefone.Text) ? "* Telefone precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtLogradouro.Text) ? "* Logradouro precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtNumero.Text) ? "* Número da casa precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtBairro.Text) ? "* Bairro precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(txtMunicipio.Text) ? "* Município precisa ser informado.\n" : "";
            msgErro += string.IsNullOrWhiteSpace(cbxEstado.Text) ? "* Estado precisa ser informado.\n" : "";

            if (msgErro != "")
                MessageBox.Show($"{msgErro}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ClienteMODEL cliente = new ClienteMODEL();
                cliente.Nome = txtNome.Text;
                cliente.Sexo = txtSexo.Text;
                cliente.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                cliente.Cpf = Convert.ToInt32(txtCpf.Text);
                cliente.Rg = Convert.ToInt32(txtRg.Text);
                cliente.Telefone = Convert.ToInt32(txtTelefone.Text);
                cliente.Logradouro = txtLogradouro.Text;
                cliente.Numero = Convert.ToInt32(txtNumero.Text);
                cliente.Bairro = txtBairro.Text;
                cliente.Municipio = txtMunicipio.Text;
                cliente.Estado = cbxEstado.Text;

                if (!codigo.HasValue)
                {
                    BancoDados.Clientes.Inserir(cliente);
                    MessageBox.Show($"Cadastro de cliente realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    cliente.Id = codigo.Value;
                    //Invoco o Método Alterar da DAO para alterar uma Pessoa
                    BancoDados.Clientes.Alterar(cliente);
                    MessageBox.Show($"Dados Alterados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
