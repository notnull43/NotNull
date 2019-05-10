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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();  
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGridProduto frm = new frmGridProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGridCliente frm = new frmGridCliente();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
