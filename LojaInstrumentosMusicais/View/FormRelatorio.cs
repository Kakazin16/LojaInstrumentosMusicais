using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LojaInstrumentosMusicais.Models;
using LojaInstrumentosMusicais.Services;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormRelatorio : Form
    {
        private readonly GerenciadorVendas gerenciador;
        private static readonly CultureInfo ptBR = new CultureInfo("pt-BR");

        public FormRelatorio() : this(new GerenciadorVendas())
        {
        }

        public FormRelatorio(GerenciadorVendas gerenciador)
        {
            InitializeComponent();
            this.gerenciador = gerenciador ?? new GerenciadorVendas();

            Load += (sender, e) => CarregarVendas(this.gerenciador.ListarVendas());
            btnBuscar.Click += (sender, e) => Buscar();
            btnLimpar.Click += (sender, e) => Limpar();
            btnFechar.Click += (sender, e) => Close();
            txtBuscaCliente.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    Buscar();
                }
            };
        }

        private void CarregarVendas(IEnumerable<Venda> lista)
        {
            dgvVendas.Rows.Clear();

            foreach (Venda venda in lista)
            {
                dgvVendas.Rows.Add(
                    venda.Cliente,
                    venda.Instrumento,
                    venda.Preco.ToString("C", ptBR),
                    venda.OutroPreco.ToString("C", ptBR),
                    venda.Total.ToString("C", ptBR)
                );
            }

            AtualizarResumo(lista);
        }

        private void AtualizarResumo(IEnumerable<Venda> exibidas)
        {
            int qtdExibidas = exibidas.Count();
            decimal totalExibido = exibidas.Sum(v => v.Total);

            lblQuantidade.Text =
                $"Vendas exibidas: {qtdExibidas} de {gerenciador.QuantidadeVendas()}";
            lblFaturamento.Text =
                $"Faturamento exibido: {totalExibido.ToString("C", ptBR)}   |   " +
                $"Faturamento total: {gerenciador.CalcularFaturamento().ToString("C", ptBR)}";
        }

        private void Buscar()
        {
            string termo = txtBuscaCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(termo))
            {
                CarregarVendas(gerenciador.ListarVendas());
                return;
            }

            List<Venda> encontradas = gerenciador.ListarVendas()
                .Where(v => !string.IsNullOrEmpty(v.Cliente) &&
                            v.Cliente.IndexOf(termo, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (encontradas.Count == 0)
            {
                MessageBox.Show("Nenhuma venda encontrada para esse cliente.",
                    "Relatório de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CarregarVendas(encontradas);
        }

        private void Limpar()
        {
            txtBuscaCliente.Clear();
            CarregarVendas(gerenciador.ListarVendas());
            txtBuscaCliente.Focus();
        }
    }
}