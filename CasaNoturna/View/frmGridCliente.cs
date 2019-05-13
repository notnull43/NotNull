using CadastroDAO;
using CadastroMODEL;
using System;
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
            binding.DataSource = data ?? BancoDados.Clientes.Pesquisar();
            binding.ResetBindings(true);
            dgvClientes.DataSource = binding;
        }

        private void frmGridCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dgvClientes.AutoGenerateColumns = false;
            AtualizaGrid();
        }

        private void btnPesquisarCadastro_Click(object sender, EventArgs e)
        {
            AtualizaGrid(BancoDados.Clientes.Pesquisar(txtPesquisarNome.Text));
        }

        private void btnClientesCadastrados_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cliente = (ClienteMODEL)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            frmCadastroCliente cadastro = new frmCadastroCliente("MINHA TELA DE ALTERAÇÃO DE CLIENTE", cliente.Id);
            cadastro.ShowDialog();
            AtualizaGrid();
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                ClienteMODEL cliente = (ClienteMODEL)dgvClientes.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Confirma a Exclusão da Cliente: " + cliente.Nome, "Exclusão de Clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BancoDados.Clientes.Deletar(cliente);
                    AtualizaGrid();
                }
            }
        }
    }
}
