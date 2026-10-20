using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormVenda"]?.Show();
            this.Close();

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda telaVenda = new FormVenda();
            telaVenda.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio telaRelatorio= new FormRelatorio();
            telaRelatorio.ShowDialog();
        }
    }
}
