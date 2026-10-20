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
            btnRegistrar = new Button();
            txtNome = new TextBox();
            txtNomeInstrumento = new TextBox();
            textBox1 = new TextBox();
            txtNomeInstrumento2 = new TextBox();
            textBox2 = new TextBox();
            btnTotal = new Button();
            lblLoja = new Label();
            lblVendas = new Label();
            lblNome = new Label();
            lblInstrumento = new Label();
            lblInstrumento2 = new Label();
            lblPreco1 = new Label();
            lblPreco2 = new Label();
            SuspendLayout();
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
            // txtNomeInstrumento
            // 
            txtNomeInstrumento.Location = new Point(158, 111);
            txtNomeInstrumento.Name = "txtNomeInstrumento";
            txtNomeInstrumento.Size = new Size(237, 23);
            txtNomeInstrumento.TabIndex = 6;
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
            // btnTotal
            // 
            btnTotal.Location = new Point(389, 278);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(174, 37);
            btnTotal.TabIndex = 13;
            btnTotal.Text = "Calcular Total";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // lblLoja
            // 
            lblLoja.AutoSize = true;
            lblLoja.Location = new Point(302, 9);
            lblLoja.Name = "lblLoja";
            lblLoja.Size = new Size(167, 15);
            lblLoja.TabIndex = 20;
            lblLoja.Text = "Loja de Instrumentos Musicais";
            // 
            // lblVendas
            // 
            lblVendas.AutoSize = true;
            lblVendas.Location = new Point(330, 40);
            lblVendas.Name = "lblVendas";
            lblVendas.Size = new Size(106, 15);
            lblVendas.TabIndex = 14;
            lblVendas.Text = "Registro de Vendas";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(166, 73);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 15);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome do Cliente";
            // 
            // lblInstrumento
            // 
            lblInstrumento.AutoSize = true;
            lblInstrumento.Location = new Point(80, 114);
            lblInstrumento.Name = "lblInstrumento";
            lblInstrumento.Size = new Size(72, 15);
            lblInstrumento.TabIndex = 22;
            lblInstrumento.Text = "Instrumento";
            // 
            // lblInstrumento2
            // 
            lblInstrumento2.AutoSize = true;
            lblInstrumento2.Location = new Point(453, 119);
            lblInstrumento2.Name = "lblInstrumento2";
            lblInstrumento2.Size = new Size(78, 15);
            lblInstrumento2.TabIndex = 23;
            lblInstrumento2.Text = "Instrumento2";
            // 
            // lblPreco1
            // 
            lblPreco1.AutoSize = true;
            lblPreco1.Location = new Point(97, 162);
            lblPreco1.Name = "lblPreco1";
            lblPreco1.Size = new Size(37, 15);
            lblPreco1.TabIndex = 24;
            lblPreco1.Text = "Preço";
            // 
            // lblPreco2
            // 
            lblPreco2.AutoSize = true;
            lblPreco2.Location = new Point(478, 167);
            lblPreco2.Name = "lblPreco2";
            lblPreco2.Size = new Size(37, 15);
            lblPreco2.TabIndex = 25;
            lblPreco2.Text = "Preço";
            // 
            // FormVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPreco2);
            Controls.Add(lblPreco1);
            Controls.Add(lblInstrumento2);
            Controls.Add(lblInstrumento);
            Controls.Add(lblNome);
            Controls.Add(lblVendas);
            Controls.Add(lblLoja);
            Controls.Add(btnTotal);
            Controls.Add(textBox2);
            Controls.Add(txtNomeInstrumento2);
            Controls.Add(textBox1);
            Controls.Add(txtNomeInstrumento);
            Controls.Add(txtNome);
            Controls.Add(btnRegistrar);
            Name = "FormVenda";
            Text = "FormVendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrar;
        private TextBox txtNome;
        private TextBox txtNomeInstrumento;
        private TextBox textBox1;
        private TextBox txtNomeInstrumento2;
        private TextBox textBox2;
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

        private Label lblLoja;
        private Label lblVendas;
        private Label lblNome;
        private Label lblInstrumento;
        private Label lblInstrumento2;
        private Label lblPreco1;
        private Label lblPreco2;
    }
}