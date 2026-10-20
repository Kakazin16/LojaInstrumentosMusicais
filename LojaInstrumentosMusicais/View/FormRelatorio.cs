using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LojaInstrumentosMusicais.Services;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormRelatorio : Form
    {
        private readonly DataGridView dgvVendas;
        private readonly Label lblResumo;

        public FormRelatorio()
        {
            Text = "Relatório de Vendas";
            Size = new Size(800, 480);
            StartPosition = FormStartPosition.CenterScreen;

            var painelTopo = new Panel { Dock = DockStyle.Top, Height = 45 };

            var btnAtualizar = new Button { Text = "Atualizar", Location = new Point(10, 8), Width = 100 };
            btnAtualizar.Click += (s, e) => CarregarVendas();

            var btnVoltar = new Button { Text = "Voltar", Location = new Point(120, 8), Width = 100 };
            btnVoltar.Click += (s, e) => Close();

            lblResumo = new Label { Location = new Point(240, 13), AutoSize = true };

            painelTopo.Controls.Add(btnAtualizar);
            painelTopo.Controls.Add(btnVoltar);
            painelTopo.Controls.Add(lblResumo);

            dgvVendas = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            Controls.Add(dgvVendas);
            Controls.Add(painelTopo);

            Load += (s, e) => CarregarVendas();
        }

        private void CarregarVendas()
        {
            var gerenciador = GerenciadorVendas.Instancia;
            var vendas = gerenciador.ListarVendas();

            dgvVendas.DataSource = vendas
                .Select(v => new
                {
                    v.Cliente,
                    v.Instrumento,
                    Preco = v.Preco.ToString("C"),
                    OutroPreco = v.OutroPreco.ToString("C"),
                    Total = v.Total.ToString("C")
                })
                .ToList();

            lblResumo.Text = $"{gerenciador.QuantidadeVendas()} venda(s) — Faturamento: {gerenciador.CalcularFaturamento():C}";
        }
    }
}