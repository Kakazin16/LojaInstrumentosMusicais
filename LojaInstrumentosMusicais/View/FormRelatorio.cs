using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormRelatorio : Form
    {
        private readonly DataGridView dgvVendas;

        public FormRelatorio()
        {
            Text = "Relatório de Vendas";
            Size = new Size(800, 480);
            StartPosition = FormStartPosition.CenterScreen;

            var painelTopo = new Panel { Dock = DockStyle.Top, Height = 45 };
            var btnVoltar = new Button { Text = "Voltar", Location = new Point(120, 8), Width = 100 };
            btnVoltar.Click += (s, e) => Close();
            painelTopo.Controls.Add(btnVoltar);

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
        }
    }
}