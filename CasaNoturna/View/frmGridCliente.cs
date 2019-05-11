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
    public partial class frmGridCliente : Form
    {
        BindingSource binding;

        public frmGridCliente()
        {
            InitializeComponent();
            binding = new BindingSource();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastro = new frmCadastroCliente("MINHA TELA DE CADASTRO DE CLIENTE");
            cadastro.ShowDialog();
            AtualizaGrid();
        }

        private void AtualizaGrid(object data = null)
        {
            binding.DataSource = data ?? BancoDados.Pessoas.Pesquisar();
            binding.ResetBindings(true);
            dgvPessoas.DataSource = binding;
        }

        private void frmGridCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_pessoas_Load(object sender, EventArgs e)
        {
            dgvPessoas.AutoGenerateColumns = false;

            AtualizaGrid();
        }

        private void btnPesquisarCadastro_Click(object sender, EventArgs e)
        {
            AtualizaGrid(BancoDados.Pessoas.Pesquisar(txtPesquisarNome.Text));
        }

        private void btnPessoasCadastradas_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex = Posição da Linha clicada
            //(CAST)
            var pessoa = (Pessoa)dgvPessoas.Rows[e.RowIndex].DataBoundItem;
            frm_cadastroPessoa cadastro = new frm_cadastroPessoa("MINHA TELA DE ALTERAÇÃO DE PESSOA", pessoa.Codigo);
            cadastro.ShowDialog();
            AtualizaGrid();
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (dgvPessoas.SelectedRows.Count > 0)
            {
                Pessoa pessoa = (Pessoa)dgvPessoas.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Confirma a Exclusão da Pessoa: " + pessoa.Nome, "Exclusão de Pessoas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BancoDados.Pessoas.Excluir(pessoa);
                    AtualizaGrid();
                }
            }
        }
    }
}
