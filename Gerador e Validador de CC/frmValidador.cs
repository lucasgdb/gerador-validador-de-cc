using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Gerador_e_Validador_de_CC;
using Gerador_de_CC_com_Bin;
using System.Drawing;
using System.Linq;
using System.Net;

namespace Gerador_de_CC
{
    public partial class frmValidador : MetroFramework.Forms.MetroForm
    {
        public frmValidador()
        {
            InitializeComponent();
            YouTube.MouseEnter += (s, e) =>
            {
                YouTube.Location = new Point(YouTube.Location.X - 1, YouTube.Location.Y - 1);
                YouTube.Size = new Size(YouTube.Size.Width + 2, YouTube.Size.Height + 2);
            };
            YouTube.MouseLeave += (s, e) =>
            {
                YouTube.Location = new Point(YouTube.Location.X + 1, YouTube.Location.Y + 1);
                YouTube.Size = new Size(YouTube.Size.Width - 2, YouTube.Size.Height - 2);
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
        int LocalX;
        int LocalY;
        private void frmValidador_Load(object sender, EventArgs e)
        {
            if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Validador")
            {
                WebClient Web = new WebClient();
                Web.DownloadStringAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1bpVdsyUj3oOn1gLbcVRE7uZjIczI5Yc_&export=download"));
                Web.DownloadStringCompleted += (s, ee) =>
                {
                    try
                    {
                        string Info = ee.Result;
                        string VAtual = Application.ProductVersion;
                        string VDisponivel = Info.Split('\n')[0];
                        if (Convert.ToDouble(VAtual) < Convert.ToDouble(VDisponivel))
                        {
                            notifyIcon1.Icon = Icon;
                            notifyIcon1.Text = "Atualização disponível";
                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                            notifyIcon1.BalloonTipText = "Nova versão de programa disponível!";
                            notifyIcon1.BalloonTipTitle = "Gerador & Validador de CC";
                            notifyIcon1.Visible = true;
                            notifyIcon1.ShowBalloonTip(300);
                            notifyIcon1.BalloonTipClicked += (ss, eee) =>
                            {
                                notifyIcon1.Visible = false;
                                Form frmAtualizar = new frmAtualizar();
                                frmAtualizar.ShowDialog();
                            };
                            notifyIcon1.BalloonTipClosed += (ss, eee) => { notifyIcon1.Visible = false; };
                        }
                    }
                    catch { }
                };
            }

            try
            {
                string[] Versoes = { "110", "111", "112", "113" };
                for (int i = 0; i < Versoes.Length; i++)
                {
                    if (File.Exists(Application.StartupPath + @"\Gerador & Validador de CC V" + Versoes[i] + ".exe"))
                    {
                        File.Delete(Application.StartupPath + @"\Gerador & Validador de CC V" + Versoes[i] + ".exe");
                    }
                }
                if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Validador")
                {
                    menuStrip1.Visible = true;
                    btnGerador.Visible = true;
                }
                else
                {
                    btnRegras.Visible = true;
                }
                columnHeader1.Width = metroListView1.Width / 3 + 23;
                columnHeader2.Width = metroListView1.Width / 3 - 23;
                columnHeader3.Width = metroListView1.Width / 3;
                LocalX = Location.X;
                LocalY = Location.Y;
            }
            catch { }
            pictureBox1.Select();
        }

        void ValidarCC(string CC)
        {
            // Tirar o Dígito Verificador
            // Inverter o CC
            // Multiplicar as casas pares por 2
            // Tirar os 9 fora
            try
            {
                if (CC.Contains("|"))
                {
                    CC = CC.Split('|')[0].Trim().Replace(" ", "").Trim();
                }
                else if (CC.Contains(","))
                {
                    CC = CC.Split(',')[0].Trim().Replace(" ", "").Trim();
                }
                else if (CC.Contains(";"))
                {
                    CC = CC.Split(';')[0].Trim().Replace(" ", "").Trim();
                }
                else if (CC.Contains(":"))
                {
                    CC = CC.Split(':')[0].Trim().Replace(" ", "").Trim();
                }
                else if (CC.Contains("-"))
                {
                    CC = CC.Split('-')[0].Trim().Replace(" ", "").Trim();
                }
                else
                {
                    CC = CC.Split(' ')[0].Trim().Replace(" ", "").Trim();
                }

                for (int i = 0; i < metroListView1.Items.Count; i++)
                {
                    if (CC == metroListView1.Items[i].SubItems[0].Text)
                    {
                        i = metroListView1.Items.Count;
                        lblStatus.Text = "Status: Recebendo Cartão de Crédito já validado";
                        return;
                    }
                }
                if (CC == "")
                {
                    lblStatus.Text = "Status: Recebendo Cartão de Crédito vazio";
                }
                else if (CC.Length < 12)
                {
                    lblStatus.Text = "Status: Recebendo CC muito pequeno";
                }
                else if (CC.Length > 19)
                {
                    lblStatus.Text = "Status: Recebendo CC muito grande";
                }
                else
                {
                    string tipo = "";
                    for (int j = 0; j < BinsPreDefinidos.Length; j++)
                    {
                        if (CC.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                        {
                            tipo = CCBins[j].ToString();
                            j = BinsPreDefinidos.Length;
                        }
                    }
                    if (tipo == "")
                    {
                        if (CC.Substring(0, 1) == "4" && (CC.Length == 13 || CC.Length == 16))
                        {
                            tipo = "Visa";
                        }
                        else if ((CC.Substring(0, 2) == "51" || CC.Substring(0, 2) == "52" || CC.Substring(0, 2) == "53" || CC.Substring(0, 2) == "54" || CC.Substring(0, 2) == "55") && CC.Length == 16)
                        {
                            tipo = "Mastercard";
                        }
                        else if ((CC.Substring(0, 2) == "34" || CC.Substring(0, 2) == "37") && CC.Length == 15)
                        {
                            tipo = "American Express";
                        }
                        else if (CC.Substring(0, 4) == "6011" && CC.Length == 16)
                        {
                            tipo = "Discover";
                        }
                        else if ((CC.Substring(0, 4) == "3528" || CC.Substring(0, 4) == "3088" || CC.Substring(0, 4) == "3096" || CC.Substring(0, 4) == "3112" || CC.Substring(0, 4) == "3158" || CC.Substring(0, 4) == "3096" || CC.Substring(0, 4) == "3337") && CC.Length == 16)
                        {
                            tipo = "JCB";
                        }
                        else if ((CC.Substring(0, 2) == "30" || CC.Substring(0, 2) == "36" || CC.Substring(0, 2) == "38") && (CC.Length == 14 || CC.Length == 16))
                        {
                            tipo = "Diners Club";
                        }
                        else if ((CC.Substring(0, 4) == "2014" || CC.Substring(0, 4) == "2149") && CC.Length == 15)
                        {
                            tipo = "enRoute";
                        }
                        else if (CC.Substring(0, 6) == "606282" && (CC.Length == 13 || CC.Length == 16 || CC.Length == 19))
                        {
                            tipo = "Hipercard";
                        }
                        else if ((CC.Substring(0, 6) == "636368" || CC.Substring(0, 6) == "636369" || CC.Substring(0, 6) == "438935" || CC.Substring(0, 6) == "504175" || CC.Substring(0, 6) == "451416" || CC.Substring(0, 6) == "636297" || CC.Substring(0, 4) == "5067" || CC.Substring(0, 4) == "4576" || CC.Substring(0, 4) == "4011" || CC.Substring(0, 6) == "506699") && CC.Length == 16)
                        {
                            tipo = "Elo";
                        }
                        else if (CC.Substring(0, 2) == "50" && CC.Length == 16)
                        {
                            tipo = "Aura";
                        }
                        else if ((CC.Substring(0, 4) == "4903" || CC.Substring(0, 4) == "4911" || CC.Substring(0, 4) == "4936" || CC.Substring(0, 4) == "5641" || CC.Substring(0, 4) == "6333" || CC.Substring(0, 4) == "6759" || CC.Substring(0, 4) == "6334" || CC.Substring(0, 4) == "6767") && CC.Length == 13)
                        {
                            tipo = "Switch";
                        }
                        else
                        {
                            tipo = "Desconhecido";
                        }
                    }

                    if (CC == "211111111111" || CC == "2111111111111" || CC.Length == 17)
                    {
                        metroListView1.Items.Add(new ListViewItem(new string[] { CC, "Falso", "Desconhecido" }));
                    }
                    else
                    {
                        string DV = CC.Substring(CC.Length - 1, 1);
                        CC = CC.Remove(CC.Length - 1, 1);
                        int Soma = 0, a = 0, d;
                        for (int i = CC.Length; i > 0; i--)
                        {
                            d = int.Parse(CC.Substring(i - 1, 1));
                            if (a % 2 == 0)
                            {
                                d *= 2;
                            }
                            if (d > 9)
                            {
                                d -= 9;
                            }
                            Soma += d;
                            a++;
                        }

                        int DigitoVerificador = 10 - (Soma % 10);
                        if (DigitoVerificador == 10)
                        {
                            DigitoVerificador = 0;
                        }

                        if (DV == DigitoVerificador.ToString())
                        {
                            metroListView1.Items.Add(new ListViewItem(new string[] { CC + DigitoVerificador, "Verdadeiro", tipo }));
                        }
                        else
                        {
                            metroListView1.Items.Add(new ListViewItem(new string[] { CC + DV, "Falso", "Desconhecido" }));
                        }
                    }

                }
            }
            catch { lblStatus.Text = "Status: Recebendo Cartão de Crédito inválido"; }
        }

        private void TxtCC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)
            {
                txtCC.Text = Clipboard.GetText();
            }
            else if (e.KeyCode == Keys.A)
            {
                txtCC.SelectAll();
            }
            else if (e.KeyCode == Keys.C)
            {
                if (txtCC.SelectedText != "")
                {
                    Clipboard.SetText(txtCC.SelectedText);
                }
            }
        }

        private void txtCC_Enter(object sender, EventArgs e)
        {
            txtCC.WaterMark = "";
        }

        private void txtCC_Leave(object sender, EventArgs e)
        {
            txtCC.WaterMark = "Cartão de Crédito (Ex: 4342067723236137)";
            txtCC.UseStyleColors = true;
        }

        private void txtCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (char)8 != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void metroListView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem i in metroListView1.SelectedItems)
                    metroListView1.Items.Remove(i);
            }
        }

        private void removerSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (ListViewItem i in metroListView1.SelectedItems)
            {
                txt = i.SubItems[0].Text;
                metroListView1.Items.Remove(i);
            }
            if (txt != "")
            {
                lblStatus.Text = "Status: Foi removido o CC '" + txt + "'";
            }
            else
            {
                lblStatus.Text = "Status: Nenhum Cartão de Crédito selecionado";
            }
            pictureBox1.Select();
        }

        private void removerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroListView1.Items.Count >= 1)
            {
                metroListView1.Items.Clear(); lblStatus.Text = "Status: Foram removidos todos os CCs";
            }
            else
            {
                lblStatus.Text = "Status: A área de Cartões de Crédito já está limpa";
            }
            pictureBox1.Select();
        }

        private void YouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/lucasnaja?sub_confirmation=1");
        }

        private void removerCCsVerdadeirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < metroListView1.Items.Count; i++)
            {
                if (metroListView1.Items[i].SubItems[1].Text == "Verdadeiro")
                {
                    metroListView1.Items[i].Remove();
                    i--;
                    tr = true;
                }
            }
            if (tr == false)
            {
                lblStatus.Text = "Status: Não há Cartões de Crédito Verdadeiros";
            }
            else
            {
                lblStatus.Text = "Status: Foram removidos os CCs Verdadeiros";
            }
            pictureBox1.Select();
        }

        private void removerCCsFalsosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < metroListView1.Items.Count; i++)
            {
                if (metroListView1.Items[i].SubItems[1].Text == "Falso")
                {
                    metroListView1.Items[i].Remove();
                    i--;
                    tr = true;
                }
            }
            if (tr == false)
            {
                lblStatus.Text = "Status: Não há Cartões de Crédito Falsos";
            }
            else
            {
                lblStatus.Text = "Status: Foram removidos os CCs Falsos";
            }
            pictureBox1.Select();
        }

        private void frmValidador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Comunicacao.Comunica = true;
            try
            {
                if (abrirGeradorDeCCToolStripMenuItem.Text.Contains("Gerador") && menuStrip1.Visible == true)
                {
                    Gerador_e_Validador_de_CC.Properties.Settings.Default.Run = "Validador";
                    Gerador_e_Validador_de_CC.Properties.Settings.Default.Save();
                }
                else if (abrirGeradorDeCCToolStripMenuItem.Text.Contains("Validador") && menuStrip1.Visible == true)
                {
                    Gerador_e_Validador_de_CC.Properties.Settings.Default.Run = "Gerador";
                    Gerador_e_Validador_de_CC.Properties.Settings.Default.Save();
                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Select(); txtCC.UseStyleColors = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (metroListView1.Items.Count >= 1)
            {
                metroListView1.Items.Clear(); lblStatus.Text = "Status: Foram removidos todos os CCs";
            }
            else
            {
                lblStatus.Text = "Status: A área de Cartões de Crédito já está limpa";
            }
            pictureBox1.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (metroListView1.Items.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < metroListView1.Items.Count; i++)
                {
                    if (i == metroListView1.Items.Count - 1)
                    {
                        sb.Append(metroListView1.Items[i].SubItems[0].Text + "|" + metroListView1.Items[i].SubItems[1].Text);
                    }
                    else
                    {
                        sb.Append(metroListView1.Items[i].SubItems[0].Text + "|" + metroListView1.Items[i].SubItems[1].Text + Environment.NewLine);
                    }
                }
                string local = Application.StartupPath + @"\Validação de Cartões de Crédito.txt";
                int j = 1;
                while (File.Exists(local))
                {
                    local = Application.StartupPath + @"\Validação de Cartões de Crédito" + j + ".txt";
                    j++;
                }

                StreamWriter sw = new StreamWriter(local);
                sw.Write(sb.ToString());
                sw.Close();
                lblStatus.Text = "Status: Cartões de Crédito salvos com sucesso";
                MessageBox.Show("Validação salva com sucesso. " + Environment.NewLine + local, "Validador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você precisa Validar pelo menos 1 Cartão de Crédito", "Validador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            pictureBox1.Select();
        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            string conteudo = Clipboard.GetText();
            if (conteudo != "")
            {
                lblStatus.Text = "Status: OK";
                string[] CCs = conteudo.Split('\n');
                for (int i = 0; i < CCs.Length; i++)
                {
                    ValidarCC(CCs[i]);
                }
            }
            else
            {
                lblStatus.Text = "Status: Recebendo Cartão de Crédito vazio";
            }
            pictureBox1.Select();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCC.Text != "")
            {
                lblStatus.Text = "Status: OK";
                ValidarCC(txtCC.Text);
                pictureBox1.Select();
            }
            else
            {
                txtCC.Focus();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Arquivos de Texto (*.txt)|*.txt", FileName = "Cartões de Crédito.txt", Title = "Importar Cartões de Crédito", Multiselect = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] Arquivos = ofd.FileNames;
                for (int j = 0; j < Arquivos.Length; j++)
                {
                    string[] CCs = File.ReadAllLines(Arquivos[j]);
                    for (int i = 0; i < CCs.Length; i++)
                    {
                        ValidarCC(CCs[i]);
                    }
                }
                lblStatus.Text = "Status: OK";
            }
            pictureBox1.Select();
        }
        string[] BinsPreDefinidos = { "6395 97", "5592 31", "4999 04", "5584 19", "4892 04", "4924 60", "4745 12", "5480 87", "4152 75", "5303 69", "4349 39", "5453 66", "6062 63", "4258 23", "5583 03", "4260 55", "4233 39", "5530 07", "4289 78", "5547 67", "5583 06", "4745 12", "3766 23", "3764 74" };
        string[] CCBins = {"Maestro - WIRECARD BANK AG",
"Mastercard - WIRECARD BANK AG",
"Visa - WIRECARD BANK AG",
"Mastercard - UNIBANCO-UNIAO DE BANCOS BRASILEIROS, S.A",
"Visa - UNIBANCO - UNIAO DE BANCOS BRASILEIROS, S.A",
"Visa - SANTANDER (BANCO ABN AMRO REAL S.A.)",
"Visa - SANTANDER",
"Mastercard - REDECARD, S.A",
"Visa - PORTOSEG S.A. CREDITO FINANCIAMENTO E INVESTIMENTO",
"Mastercard - PARANA BANCO S.A",
"Visa - PANAMERICANO ADMINISTRADORA DE CARTOES DE CREDITO LTDA",
"Mastercard - NATIONAL BANK OF COMMERCE OF BIRMINGHAM",
"Maestro - MONEYTECH, INC",
"Visa - M AND T BANK",
"Mastercard - ITAU UNIBANCO, S.A",
"Visa - LA CAIXA",
"Visa - IMPERIAL BANK",
"Mastercard - HSBC BANK BRASIL S.A. - BANCO MULTIPLO",
"Visa - INTERPAYMENT SERVICES, LTD",
"Mastercard - GE CAPITAL DO BRASIL LTDA",
"Mastercard - CREDICARD, S.A",
"Visa - SANTANDER",
"Amex - CAIXA FERDERAL",
"Amex - CITIBANK",};
        private void informaçõesDeCCSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string cc = "", validacao = "", tamanho = "", tipo = "";
                string CC = "";
                foreach (ListViewItem i in metroListView1.SelectedItems)
                {
                    CC = i.Text;
                    cc = "Cartão de Crédito: " + i.Text; validacao = "Validação: " + i.SubItems[1].Text;
                    tamanho = "Tamanho do CC: " + i.Text.Length;
                }

                if (CC != "")
                {
                    for (int j = 0; j < BinsPreDefinidos.Length; j++)
                    {
                        if (CC.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                        {
                            tipo = "Tipo - Banco: " + CCBins[j].ToString();
                            j = BinsPreDefinidos.Length;
                        }
                    }
                    if (tipo == "")
                    {
                        if (CC.Substring(0, 1) == "4" && (CC.Length == 13 || CC.Length == 16))
                        {
                            tipo = "Tipo - Banco: Visa";
                        }
                        else if ((CC.Substring(0, 2) == "51" || CC.Substring(0, 2) == "52" || CC.Substring(0, 2) == "53" || CC.Substring(0, 2) == "54" || CC.Substring(0, 2) == "55") && CC.Length == 16)
                        {
                            tipo = "Tipo - Banco: Mastercard";
                        }
                        else if ((CC.Substring(0, 2) == "34" || CC.Substring(0, 2) == "37") && CC.Length == 15)
                        {
                            tipo = "Tipo - Banco: American Express";
                        }
                        else if (CC.Substring(0, 4) == "6011" && CC.Length == 16)
                        {
                            tipo = "Tipo - Banco: Discover";
                        }
                        else if ((CC.Substring(0, 4) == "3528" || CC.Substring(0, 4) == "3088" || CC.Substring(0, 4) == "3096" || CC.Substring(0, 4) == "3112" || CC.Substring(0, 4) == "3158" || CC.Substring(0, 4) == "3096" || CC.Substring(0, 4) == "3337") && CC.Length == 16)
                        {
                            tipo = "Tipo - Banco: JCB";
                        }
                        else if ((CC.Substring(0, 2) == "30" || CC.Substring(0, 2) == "36" || CC.Substring(0, 2) == "38") && (CC.Length == 14 || CC.Length == 16))
                        {
                            tipo = "Tipo - Banco: Diners Club";
                        }
                        else if ((CC.Substring(0, 4) == "2014" || CC.Substring(0, 4) == "2149") && CC.Length == 15)
                        {
                            tipo = "Tipo - Banco: enRoute";
                        }
                        else if (CC.Substring(0, 6) == "606282" && (CC.Length == 13 || CC.Length == 16 || CC.Length == 19))
                        {
                            tipo = "Tipo - Banco: Hipercard";
                        }
                        else if ((CC.Substring(0, 6) == "636368" || CC.Substring(0, 6) == "636369" || CC.Substring(0, 6) == "438935" || CC.Substring(0, 6) == "504175" || CC.Substring(0, 6) == "451416" || CC.Substring(0, 6) == "636297" || CC.Substring(0, 4) == "5067" || CC.Substring(0, 4) == "4576" || CC.Substring(0, 4) == "4011" || CC.Substring(0, 6) == "506699") && CC.Length == 16)
                        {
                            tipo = "Tipo - Banco: Elo";
                        }
                        else if (CC.Substring(0, 2) == "50" && CC.Length == 16)
                        {
                            tipo = "Tipo - Banco: Aura";
                        }
                        else if ((CC.Substring(0, 4) == "4903" || CC.Substring(0, 4) == "4911" || CC.Substring(0, 4) == "4936" || CC.Substring(0, 4) == "5641" || CC.Substring(0, 4) == "6333" || CC.Substring(0, 4) == "6759" || CC.Substring(0, 4) == "6334" || CC.Substring(0, 4) == "6767") && CC.Length == 13)
                        {
                            tipo = "Tipo - Banco: Switch";
                        }
                        else
                        {
                            tipo = "Tipo - Banco: Desconhecido";
                        }
                    }
                    MessageBox.Show(cc + '\n' + validacao + '\n' + tamanho + '\n' + tipo, "Informações do Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblStatus.Text = "Status: Nenhum Cartão de Crédito selecionado";
                }
            }
            catch { }
            pictureBox1.Select();
        }

        private void copiarCartãoDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string inn = "";
                foreach (ListViewItem i in metroListView1.SelectedItems)
                {
                    inn = i.SubItems[0].Text;
                }
                if (inn == "")
                {
                    lblStatus.Text = "Status: Nenhum Cartão de Crédito selecionado";
                }
                else
                {
                    Clipboard.SetText(inn);
                    lblStatus.Text = "Status: Foi copiado o CC '" + inn + "'";
                }
            }
            catch { }
            pictureBox1.Select();
        }

        private void quantidadeDeCartõesDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroListView1.Items.Count == 0)
            {
                lblStatus.Text = "Status: Não possui nenhum Cartão de Crédito";
            }
            else if (metroListView1.Items.Count == 1)
            {
                lblStatus.Text = "Status: Possui 1 Cartão de Crédito";
            }
            else
            {
                lblStatus.Text = "Status: Possui " + metroListView1.Items.Count + " Cartões de Crédito";
            }
            pictureBox1.Select();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por Lucas Naja", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void códigoFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/0B4_hqByHqmaueXBLNzZwaUEtaFk?usp=sharing");
        }
        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/lucasnaja");
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
            pictureBox1.Select();
        }
        private void abrirPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
        private void abrirGeradorDeCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abrirGeradorDeCCToolStripMenuItem.Text == "Abrir pelo Validador de CC")
            {
                abrirGeradorDeCCToolStripMenuItem.Text = "Abrir pelo Gerador de CC";
            }
            else
            {
                abrirGeradorDeCCToolStripMenuItem.Text = "Abrir pelo Validador de CC";
            }
        }

        private void regrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Possuir somente números." + Environment.NewLine +
    "- Ter entre 12 e 19 dígitos. (Não há CCs com 17 dígitos)" + Environment.NewLine +
    "- Os 6 primeiros dígitos devem indicar um IIN válido. (BIN)" + Environment.NewLine +
    "- Passar na validação do Algoritmo de Luhn." + Environment.NewLine +
    "- Visa => Tamanhos: 13, 16" + Environment.NewLine +
     "- Mastercard => Tamanho: 16" + Environment.NewLine +
     "- American Express => Tamanho: 15" + Environment.NewLine +
     "- Discover => Tamanho: 16" + Environment.NewLine +
     "- JCB => Tamanho: 16" + Environment.NewLine +
     "- Diners Club => Tamanhos: 14, 16" + Environment.NewLine +
     "- enRoute => Tamanho: 15" + Environment.NewLine +
     "- Hipercard => Tamanhos: 13, 16, 19" + Environment.NewLine +
     "- Elo => Tamanho: 16" + Environment.NewLine +
     "- Aura => Tamanho: 16" + Environment.NewLine +
     "- Switch => Tamanho: 13", "Regras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox1.Select();
        }
        private void btnGerador_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms.OfType<FrmGerador>().Count() > 0))
            {
                Form frmGerador = new FrmGerador();
                frmGerador.Show();
                frmGerador.Location = new Point(frmGerador.Location.X - 170, frmGerador.Location.Y);
                Location = new Point(frmGerador.Location.X + frmGerador.Size.Width + 1, frmGerador.Location.Y);
                pictureBox1.Select();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Comunicacao.Comunica == true)
            {
                timer1.Stop();
                Focus();
                Location = new Point(LocalX, LocalY);
                Comunicacao.Comunica = false;
                timer1.Start();
            }
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Possuir somente números." + Environment.NewLine +
    "- Ter entre 12 e 19 dígitos. (Não há CCs com 17 dígitos)" + Environment.NewLine +
    "- Os 6 primeiros dígitos devem indicar um IIN válido. (BIN)" + Environment.NewLine +
    "- Passar na validação do Algoritmo de Luhn." + Environment.NewLine +
    "- Visa => Tamanhos: 13, 16" + Environment.NewLine +
     "- Mastercard => Tamanho: 16" + Environment.NewLine +
     "- American Express => Tamanho: 15" + Environment.NewLine +
     "- Discover => Tamanho: 16" + Environment.NewLine +
     "- JCB => Tamanho: 16" + Environment.NewLine +
     "- Diners Club => Tamanhos: 14, 16" + Environment.NewLine +
     "- enRoute => Tamanho: 15" + Environment.NewLine +
     "- Hipercard => Tamanhos: 13, 16, 19" + Environment.NewLine +
     "- Elo => Tamanho: 16" + Environment.NewLine +
     "- Aura => Tamanho: 16" + Environment.NewLine +
     "- Switch => Tamanho: 13", "Regras", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox1.Select();
        }

        private void verificarAtualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAtualizar = new frmAtualizar();
            frmAtualizar.ShowDialog();
        }
    }
}