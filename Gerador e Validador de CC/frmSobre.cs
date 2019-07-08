using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gerador_de_CC
{
    public partial class FrmSobre : MetroFramework.Forms.MetroForm
    {
        public FrmSobre()
        {
            InitializeComponent();
            pictureBox1.MouseEnter += (s, e) =>
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y - 1);
                pictureBox1.Size = new Size(pictureBox1.Size.Width + 2, pictureBox1.Size.Height + 2);
            };
            pictureBox1.MouseLeave += (s, e) =>
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y + 1);
                pictureBox1.Size = new Size(pictureBox1.Size.Width - 2, pictureBox1.Size.Height - 2);
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/lucasnaja?sub_confirmation=1");
        }

        string txt = "Programa criado e desenvolvido por Lucas Naja." + Environment.NewLine +
"Programa simples com intuito de ajudar no" + Environment.NewLine +
"desenvolvimento de sites e teste de softwares" + Environment.NewLine +
"que usam as informações dos Cartões de Crédito." + Environment.NewLine +
            "Foi usado o Algoritmo de Luhn para Gerar e Validar" + Environment.NewLine +
            "os Cartões de Crédito. Faça um bom uso!";
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text += txt[i];
            i++;
            if (i == txt.Length)
            {
                timer1.Stop();
                i = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/lucasnaja?sub_confirmation=1");
        }
    }
}
