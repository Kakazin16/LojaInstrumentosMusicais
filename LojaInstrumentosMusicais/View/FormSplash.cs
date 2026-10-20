using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace LojaInstrumentosMusicais.View
{
    public partial class FormSplash : Form
    {
        private readonly ProgressBar progressBar;
        private readonly Label lblStatus;
        private readonly Timer timer;

        public FormSplash()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(500, 300);
            BackColor = Color.FromArgb(30, 30, 40);

            var lblTitulo = new Label
            {
                Text = "Loja de Instrumentos Musicais",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 150
            };

            lblStatus = new Label
            {
                Text = "Carregando...",
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 180),
                Size = new Size(400, 25)
            };

            progressBar = new ProgressBar
            {
                Location = new Point(50, 215),
                Size = new Size(400, 20),
                Maximum = 100
            };

            Controls.Add(lblTitulo);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);

            timer = new Timer { Interval = 30 };
            timer.Tick += Timer_Tick;
            Load += (s, e) => timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = Math.Min(progressBar.Value + 1, 100);

            if (progressBar.Value < 40) lblStatus.Text = "Carregando...";
            else if (progressBar.Value < 80) lblStatus.Text = "Carregando instrumentos...";
            else lblStatus.Text = "Abrindo o menu...";

            if (progressBar.Value >= 100)
            {
                timer.Stop();
            }
        }
    }
}