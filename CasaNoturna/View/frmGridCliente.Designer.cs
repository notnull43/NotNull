namespace CadastroFORM
{
    partial class frmGridCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClientesCadastrados = new System.Windows.Forms.Button();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientesCadastrados
            // 
            this.btnClientesCadastrados.Location = new System.Drawing.Point(152, 270);
            this.btnClientesCadastrados.Name = "btnClientesCadastrados";
            this.btnClientesCadastrados.Size = new System.Drawing.Size(130, 32);
            this.btnClientesCadastrados.TabIndex = 17;
            this.btnClientesCadastrados.Text = "Clientes Cadastrados";
            this.btnClientesCadastrados.UseVisualStyleBackColor = true;
            this.btnClientesCadastrados.Click += new System.EventHandler(this.btnClientesCadastrados_Click);
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(57, 12);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(458, 20);
            this.txtPesquisarNome.TabIndex = 16;
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.Location = new System.Drawing.Point(16, 16);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(35, 13);
            this.lblPesquisaNome.TabIndex = 15;
            this.lblPesquisaNome.Text = "Nome";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcId,
            this.tbcNome,
            this.tbcTelefone});
            this.dgvClientes.Location = new System.Drawing.Point(16, 38);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(682, 226);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // tbcId
            // 
            this.tbcId.DataPropertyName = "Id";
            this.tbcId.HeaderText = "Id";
            this.tbcId.Name = "tbcId";
            this.tbcId.ReadOnly = true;
            this.tbcId.Visible = false;
            // 
            // tbcNome
            // 
            this.tbcNome.DataPropertyName = "Nome";
            this.tbcNome.HeaderText = "Nome";
            this.tbcNome.Name = "tbcNome";
            this.tbcNome.ReadOnly = true;
            this.tbcNome.Width = 450;
            // 
            // tbcTelefone
            // 
            this.tbcTelefone.DataPropertyName = "Telefone";
            this.tbcTelefone.HeaderText = "Telefone";
            this.tbcTelefone.Name = "tbcTelefone";
            this.tbcTelefone.ReadOnly = true;
            this.tbcTelefone.Width = 180;
            // 
            // btnPesquisarCadastro
            // 
            this.btnPesquisarCadastro.Location = new System.Drawing.Point(521, 11);
            this.btnPesquisarCadastro.Name = "btnPesquisarCadastro";
            this.btnPesquisarCadastro.Size = new System.Drawing.Size(177, 22);
            this.btnPesquisarCadastro.TabIndex = 13;
            this.btnPesquisarCadastro.TabStop = false;
            this.btnPesquisarCadastro.Text = "Pesquisar";
            this.btnPesquisarCadastro.UseVisualStyleBackColor = true;
            this.btnPesquisarCadastro.Click += new System.EventHandler(this.btnPesquisarCadastro_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Location = new System.Drawing.Point(518, 270);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(177, 32);
            this.btnExcluirCadastro.TabIndex = 12;
            this.btnExcluirCadastro.TabStop = false;
            this.btnExcluirCadastro.Text = "Excluir";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Location = new System.Drawing.Point(16, 270);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(130, 32);
            this.btnNovoCadastro.TabIndex = 11;
            this.btnNovoCadastro.TabStop = false;
            this.btnNovoCadastro.Text = "Novo";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // frmGridCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 446);
            this.Controls.Add(this.btnClientesCadastrados);
            this.Controls.Add(this.txtPesquisarNome);
            this.Controls.Add(this.lblPesquisaNome);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnPesquisarCadastro);
            this.Controls.Add(this.btnExcluirCadastro);
            this.Controls.Add(this.btnNovoCadastro);
            this.Name = "frmGridCliente";
            this.Text = "Controle de clientes";
            this.Load += new System.EventHandler(this.frmGridCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClientesCadastrados;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnPesquisarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTelefone;
    }
}