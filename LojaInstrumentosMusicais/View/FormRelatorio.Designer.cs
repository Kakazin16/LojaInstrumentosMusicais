namespace LojaInstrumentosMusicais.View
{
    partial class FormRelatorio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutroPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Relatório de Vendas";
            //
            // lblBusca
            //
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(20, 63);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Text = "Cliente:";
            //
            // txtBuscaCliente
            //
            this.txtBuscaCliente.Location = new System.Drawing.Point(80, 59);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(250, 23);
            this.txtBuscaCliente.TabIndex = 0;
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(340, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 27);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            //
            // btnLimpar
            //
            this.btnLimpar.Location = new System.Drawing.Point(436, 57);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 27);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            //
            // dgvVendas
            //
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCliente,
                this.colInstrumento,
                this.colPreco,
                this.colOutroPreco,
                this.colTotal});
            this.dgvVendas.Location = new System.Drawing.Point(20, 97);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(705, 270);
            this.dgvVendas.TabIndex = 3;
            //
            // colCliente
            //
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.FillWeight = 130F;
            //
            // colInstrumento
            //
            this.colInstrumento.HeaderText = "Instrumento";
            this.colInstrumento.Name = "colInstrumento";
            this.colInstrumento.ReadOnly = true;
            this.colInstrumento.FillWeight = 130F;
            //
            // colPreco
            //
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            //
            // colOutroPreco
            //
            this.colOutroPreco.HeaderText = "Outro Preço";
            this.colOutroPreco.Name = "colOutroPreco";
            this.colOutroPreco.ReadOnly = true;
            //
            // colTotal
            //
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            //
            // lblQuantidade
            //
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 380);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Text = "Vendas exibidas: 0 de 0";
            //
            // lblFaturamento
            //
            this.lblFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFaturamento.Location = new System.Drawing.Point(20, 405);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Text = "Faturamento total: R$ 0,00";
            //
            // btnFechar
            //
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(625, 390);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            //
            // FormRelatorio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 440);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.txtBuscaCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutroPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.Button btnFechar;
    }
}