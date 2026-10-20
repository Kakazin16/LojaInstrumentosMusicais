using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormVenda : Form
    {
       public FormVenda()
        {
            InitializeComponent();

            btnRegistrar.Click += (sender, e) => RegistrarVenda();
            btnTotal.Click += (sender, e) => CalcularTotal();
        }
        private System.ComponentModel.IContainer components = null;
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
                !decimal.TryParse(txtPreco1.Text, out preco1))
            {
                MessageBox.Show("Digite um preço válido para o primeiro instrumento.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(instrumento2) &&
                !decimal.TryParse(txtPreco2.Text, out preco2))
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

            if (!decimal.TryParse(txtPreco1.Text, out preco1) ||
                !decimal.TryParse(txtPreco2.Text, out preco2))
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
