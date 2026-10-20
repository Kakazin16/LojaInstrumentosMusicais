namespace LojaInstrumentosMusicais.View
{
    partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();

            btnRegistrar.Click += (sender, e) => RegistrarVenda();
            btnTotal.Click += (sender, e) => CalcularTotal();
        }
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
            txtTitulo = new TextBox();
            btnRegistrar = new Button();
            txtNome = new TextBox();
            txtCliente = new TextBox();
            txtVendas = new TextBox();
            txtInstrumento = new TextBox();
            txtNomeInstrumento = new TextBox();
            txtPreco = new TextBox();
            txtInstrumento2 = new TextBox();
            textBox1 = new TextBox();
            txtNomeInstrumento2 = new TextBox();
            textBox2 = new TextBox();
            txtOutroPreco = new TextBox();
            btnTotal = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.Window;
            txtTitulo.ForeColor = SystemColors.MenuText;
            txtTitulo.Location = new Point(287, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(175, 23);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Loja de Instrumentos Musicais";
            txtTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(183, 278);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(174, 37);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(278, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(158, 70);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(99, 23);
            txtCliente.TabIndex = 3;
            txtCliente.Text = "Nome do Cliente";
            // 
            // txtVendas
            // 
            txtVendas.Location = new Point(278, 32);
            txtVendas.Name = "txtVendas";
            txtVendas.Size = new Size(193, 23);
            txtVendas.TabIndex = 4;
            txtVendas.Text = "Registro de Vendas";
            txtVendas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtInstrumento
            // 
            txtInstrumento.Location = new Point(34, 111);
            txtInstrumento.Name = "txtInstrumento";
            txtInstrumento.Size = new Size(99, 23);
            txtInstrumento.TabIndex = 5;
            txtInstrumento.Text = "Instrumento";
            // 
            // txtNomeInstrumento
            // 
            txtNomeInstrumento.Location = new Point(158, 111);
            txtNomeInstrumento.Name = "txtNomeInstrumento";
            txtNomeInstrumento.Size = new Size(237, 23);
            txtNomeInstrumento.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(34, 159);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(99, 23);
            txtPreco.TabIndex = 7;
            txtPreco.Text = "Preço";
            // 
            // txtInstrumento2
            // 
            txtInstrumento2.Location = new Point(416, 111);
            txtInstrumento2.Name = "txtInstrumento2";
            txtInstrumento2.Size = new Size(99, 23);
            txtInstrumento2.TabIndex = 8;
            txtInstrumento2.Text = "Instrumento2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 9;
            // 
            // txtNomeInstrumento2
            // 
            txtNomeInstrumento2.Location = new Point(541, 111);
            txtNomeInstrumento2.Name = "txtNomeInstrumento2";
            txtNomeInstrumento2.Size = new Size(237, 23);
            txtNomeInstrumento2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(541, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 11;
            // 
            // txtOutroPreco
            // 
            txtOutroPreco.Location = new Point(416, 159);
            txtOutroPreco.Name = "txtOutroPreco";
            txtOutroPreco.Size = new Size(99, 23);
            txtOutroPreco.TabIndex = 12;
            txtOutroPreco.Text = "Preço";
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(389, 278);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(174, 37);
            btnTotal.TabIndex = 13;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTotal);
            Controls.Add(txtOutroPreco);
            Controls.Add(textBox2);
            Controls.Add(txtNomeInstrumento2);
            Controls.Add(textBox1);
            Controls.Add(txtInstrumento2);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeInstrumento);
            Controls.Add(txtInstrumento);
            Controls.Add(txtVendas);
            Controls.Add(txtCliente);
            Controls.Add(txtNome);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTitulo);
            Name = "FormVenda";
            Text = "FormVendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Button btnRegistrar;
        private TextBox txtNome;
        private TextBox txtCliente;
        private TextBox txtVendas;
        private TextBox txtInstrumento;
        private TextBox txtNomeInstrumento;
        private TextBox txtPreco;
        private TextBox txtInstrumento2;
        private TextBox textBox1;
        private TextBox txtNomeInstrumento2;
        private TextBox textBox2;
        private TextBox txtOutroPreco;
        private Button btnTotal;
        private decimal totalVendas = 0;

        private void RegistrarVenda()
        {
            string cliente = txtNome.Text.Trim();
            string instrumento1 = txtNomeInstrumento.Text.Trim();
            string instrumento2 = txtNomeInstrumento2.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("Digite o nome do cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(instrumento1) &&
                string.IsNullOrWhiteSpace(instrumento2))
            {
                MessageBox.Show("Digite pelo menos um instrumento.");
                return;
            }

            decimal preco1 = 0;
            decimal preco2 = 0;

            if (!string.IsNullOrWhiteSpace(instrumento1) &&
                !decimal.TryParse(textBox1.Text, out preco1))
            {
                MessageBox.Show("Digite um preço válido para o primeiro instrumento.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(instrumento2) &&
                !decimal.TryParse(textBox2.Text, out preco2))
            {
                MessageBox.Show("Digite um preço válido para o segundo instrumento.");
                return;
            }

            if (preco1 < 0 || preco2 < 0)
            {
                MessageBox.Show("Os preços não podem ser negativos.");
                return;
            }

            decimal total = preco1 + preco2;
            totalVendas += total;

            MessageBox.Show(
                $"Venda registrada!\n" +
                $"Cliente: {cliente}\n" +
                $"Instrumento 1: {instrumento1} - {preco1:C}\n" +
                $"Instrumento 2: {instrumento2} - {preco2:C}\n" +
                $"Total da venda: {total:C}\n" +
                $"Total acumulado: {totalVendas:C}"
            );
        }

        private void CalcularTotal()
        {
            decimal preco1 = 0;
            decimal preco2 = 0;

            if (!decimal.TryParse(textBox1.Text, out preco1) ||
                !decimal.TryParse(textBox2.Text, out preco2))
            {
                MessageBox.Show("Preencha os dois preços corretamente.");
                return;
            }

            if (preco1 < 0 || preco2 < 0)
            {
                MessageBox.Show("Os preços não podem ser negativos.");
                return;
            }

            decimal total = preco1 + preco2;

            MessageBox.Show($"Total da venda: {total:C}");
        }
    }
}