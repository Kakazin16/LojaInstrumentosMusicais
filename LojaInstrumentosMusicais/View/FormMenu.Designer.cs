namespace LojaInstrumentosMusicais.View
{
    partial class FormMenu
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
            lblTitulo = new Label();
            btnVendas = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(202, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bem Vindo ao Menu da Loja";
            // 
            // btnVendas
            // 
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVendas.Location = new Point(59, 218);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(157, 72);
            btnVendas.TabIndex = 1;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(319, 218);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(157, 72);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatorios";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(577, 218);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(157, 72);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += lblSair_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnVendas);
            Controls.Add(lblTitulo);
            Name = "FormMenu";
            Text = "Menu da Loja de Instrumentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVendas;
        private Button btnRelatorio;
        private Button btnSair;
    }
}