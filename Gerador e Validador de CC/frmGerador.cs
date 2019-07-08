using Gerador_de_CC;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Gerador_e_Validador_de_CC;
using System.Net;
using System.IO;

namespace Gerador_de_CC_com_Bin
{
    public partial class FrmGerador : MetroFramework.Forms.MetroForm
    {
        public FrmGerador()
        {
            InitializeComponent();
            txtBIN.CustomButton.Click += (s, e) => { System.Diagnostics.Process.Start("https://www.cardbinlist.com/bin-list-brazil.html?page=0"); pictureBox1.Select(); };
            txtBIN.CustomButton.MouseLeave += (s, e) => { txtBIN.UseStyleColors = true; };
            GroupBox[] grpBox = { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8 };
            for (int i = 0; i < grpBox.Length; i++)
            {
                int copiadei = i;
                grpBox[copiadei].Click += (s, e) => { pictureBox1_Click(s, e); };
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Application.Exit(); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public int LocalX = 0;
        public int LocalY = 0;

        private void frmGerar_Load(object sender, EventArgs e)
        {
            if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Gerador")
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
                if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Gerador")
                {
                    menuStrip1.Visible = true;
                    btnValidador.Visible = true;
                }

                metroToolTip1.SetToolTip(txtBIN.CustomButton, "Copiar");
                LocalX = Location.X;
                LocalY = Location.Y;
                cboxBins.SelectedIndex = Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxbins;
                checkCVV.Checked = Gerador_e_Validador_de_CC.Properties.Settings.Default.checkCVV;
                checkData.Checked = Gerador_e_Validador_de_CC.Properties.Settings.Default.checkData;
                checkTipobanco.Checked = Gerador_e_Validador_de_CC.Properties.Settings.Default.checkTipoBanco;
                QuantidadeCC.Value = Gerador_e_Validador_de_CC.Properties.Settings.Default.QuantidadeCC;
                cboxChecker.SelectedIndex = Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxChecker;
                txtCVV.Text = Gerador_e_Validador_de_CC.Properties.Settings.Default.txtCVV;
                cboxMes.SelectedIndex = Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxMes;
                cboxAno.SelectedIndex = Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxAno;
            }
            catch
            {
                cboxBins.SelectedIndex = 0;
                checkCVV.Checked = false;
                checkData.Checked = false;
                checkTipobanco.Checked = false;
                QuantidadeCC.Value = 15;
                cboxChecker.SelectedIndex = 0;
                txtCVV.Text = "RND";
                cboxMes.SelectedIndex = 0;
                cboxAno.SelectedIndex = 0;
            }
            pictureBox1.Select();
        }

        string[] BinsPreDefinidos = { "6395 97", "5592 31", "4999 04", "5584 19", "4892 04", "4924 60", "4745 12", "5480 87", "4152 75", "5303 69", "4349 39", "5453 66", "6062 63", "4258 23", "5583 03", "4260 55", "4233 39", "5530 07", "4289 78", "5547 67", "5583 06", "4745 12", "3766 23", "3764 74", "4XXX XX", "5MXX XX", "6011 XX", "3AXX X", "36XX ", "3528 XX", "6062 82" };

        void GerarCC()
        {
            int LengthEspaco = txtBIN.Text.Length - txtBIN.Text.Replace(" ", "").Length;
            if (txtBIN.Text == "")
            {
                txtBIN.Text = "XXXXXXXXXXXXXXXX";
            }
            else if (!((txtBIN.Text.Length - LengthEspaco) >= 12))
            {
                while ((txtBIN.Text.Length - LengthEspaco) < 12)
                {
                    txtBIN.Text += "x";
                }
            }

            string CCBIN = txtBIN.Text.Trim().Replace(" ", "");
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            txtCCGerado.Clear();
            string CCBin = txtBIN.Text.Trim().Replace(" ", "");

            if (cboxChecker.SelectedIndex == 0)
            {
                for (int i = 0; i < QuantidadeCC.Value; i++)
                {
                    string CC = "";
                    int CCBinLength = CCBin.Length - 1;
                    for (int j = 0; j < CCBinLength; j++)
                    {
                        if (CCBin[j].ToString().ToUpper() == "X")
                        {
                            CC += (rnd.Next(0, 10));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "M")
                        {
                            CC += (rnd.Next(1, 6));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "A")
                        {
                            if (rnd.Next(1, 3) == 1)
                            {
                                CC += 4;
                            }
                            else
                            {
                                CC += 7;
                            }
                        }
                        else
                        {
                            CC += (CCBin[j]);
                        }
                    }

                    int Soma = 0, a = 0, d;
                    for (int j = CC.Length; j > 0; j--)
                    {
                        d = int.Parse(CC.Substring(j - 1, 1));
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

                    int DV = 10 - (Soma % 10);
                    if (DV == 10)
                    {
                        DV = 0;
                    }

                    sb.Append(CC + DV);

                    if (checkData.Checked)
                    {
                        string Mes;
                        if (cboxMes.SelectedIndex == 0)
                        {
                            Mes = rnd.Next(1, 13).ToString();
                        }
                        else
                        {
                            Mes = cboxMes.Text;
                        }

                        if (Mes.Length == 1)
                        {
                            Mes = "0" + Mes;
                        }

                        Mes = Mes + "|";

                        string Ano;
                        if (cboxAno.SelectedIndex == 0)
                        {
                            Ano = rnd.Next(2018, 2026).ToString();
                        }
                        else
                        {
                            Ano = cboxAno.Text;
                        }

                        if (Ano.Length == 2)
                        {
                            Ano = "20" + Ano;
                        }

                        sb.Append("|" + Mes + Ano);
                    }
                    if (checkCVV.Checked)
                    {
                        string CVV;
                        if (txtCVV.Text.ToLower() == "rnd")
                        {
                            if ((CC.Substring(0, 2) == "37" || CC.Substring(0, 2) == "34") && CC.Length + 1 == 15)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else if (CC.Substring(0, 4) == "6011" && CC.Length + 1 == 16)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else
                            {
                                CVV = rnd.Next(101, 999).ToString();
                            }
                        }
                        else
                        {
                            CVV = txtCVV.Text;
                        }

                        sb.Append("|" + CVV);
                    }
                    if (checkTipobanco.Checked)
                    {
                        string TipoBanco = "";
                        string CCDV = CC + DV;
                        for (int j = 0; j < BinsPreDefinidos.Length; j++)
                        {
                            if (CCBIN.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                            {
                                TipoBanco = "|" + cboxBins.Items[j + 1].ToString();
                                j = BinsPreDefinidos.Length;
                            }
                        }

                        if (TipoBanco == "")
                        {
                            if (CCDV.Substring(0, 1) == "4" && (CCDV.Length == 13 || CCDV.Length == 16))
                            {
                                TipoBanco = "|Visa";
                            }
                            else if ((CCDV.Substring(0, 2) == "51" || CCDV.Substring(0, 2) == "52" || CCDV.Substring(0, 2) == "53" || CCDV.Substring(0, 2) == "54" || CCDV.Substring(0, 2) == "55") && CCDV.Length == 16)
                            {
                                TipoBanco = "|Mastercard";
                            }
                            else if ((CCDV.Substring(0, 2) == "34" || CCDV.Substring(0, 2) == "37") && CCDV.Length == 15)
                            {
                                TipoBanco = "|American Express";
                            }
                            else if (CCDV.Substring(0, 4) == "6011" && CCDV.Length == 16)
                            {
                                TipoBanco = "|Discover";
                            }
                            else if ((CCDV.Substring(0, 4) == "3528" || CCDV.Substring(0, 4) == "3088" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3112" || CCDV.Substring(0, 4) == "3158" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3337") && CCDV.Length == 16)
                            {
                                TipoBanco = "|JCB";
                            }
                            else if ((CCDV.Substring(0, 2) == "30" || CCDV.Substring(0, 2) == "36" || CCDV.Substring(0, 2) == "38") && (CCDV.Length == 14 || CCDV.Length == 16))
                            {
                                TipoBanco = "|Diners Club";
                            }
                            else if ((CCDV.Substring(0, 4) == "2014" || CCDV.Substring(0, 4) == "2149") && CCDV.Length == 15)
                            {
                                TipoBanco = "|enRoute";
                            }
                            else if (CCDV.Substring(0, 6) == "606282" && (CCDV.Length == 13 || CCDV.Length == 16 || CCDV.Length == 19))
                            {
                                TipoBanco = "|Hipercard";
                            }
                            else if ((CCDV.Substring(0, 6) == "636368" || CCDV.Substring(0, 6) == "636369" || CCDV.Substring(0, 6) == "438935" || CCDV.Substring(0, 6) == "504175" || CCDV.Substring(0, 6) == "451416" || CCDV.Substring(0, 6) == "636297" || CCDV.Substring(0, 4) == "5067" || CCDV.Substring(0, 4) == "4576" || CCDV.Substring(0, 4) == "4011" || CCDV.Substring(0, 6) == "506699") && CCDV.Length == 16)
                            {
                                TipoBanco = "|Elo";
                            }
                            else if (CCDV.Substring(0, 2) == "50" && CCDV.Length == 16)
                            {
                                TipoBanco = "|Aura";
                            }
                            else if ((CCDV.Substring(0, 4) == "4903" || CCDV.Substring(0, 4) == "4911" || CCDV.Substring(0, 4) == "4936" || CCDV.Substring(0, 4) == "5641" || CCDV.Substring(0, 4) == "6333" || CCDV.Substring(0, 4) == "6759" || CCDV.Substring(0, 4) == "6334" || CCDV.Substring(0, 4) == "6767") && CCDV.Length == 13)
                            {
                                TipoBanco = "|Switch";
                            }
                            else
                            {
                                TipoBanco = "|Desconhecido";
                            }
                        }

                        sb.Append(TipoBanco);
                    }

                    sb.Append(Environment.NewLine);
                }

                txtCCGerado.Text = sb.ToString();
                txtCCGerado.Text = txtCCGerado.Text.Trim();
            }
            else if (cboxChecker.SelectedIndex == 1)
            {
                for (int i = 0; i < QuantidadeCC.Value; i++)
                {
                    string CC = "";
                    int CCBinLength = CCBin.Length - 1;
                    for (int j = 0; j < CCBinLength; j++)
                    {
                        if (CCBin[j].ToString().ToUpper() == "X")
                        {
                            CC += (rnd.Next(0, 10));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "M")
                        {
                            CC += (rnd.Next(1, 6));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "A")
                        {
                            if (rnd.Next(1, 3) == 1)
                            {
                                CC += 4;
                            }
                            else
                            {
                                CC += 7;
                            }
                        }
                        else
                        {
                            CC += (CCBin[j]);
                        }
                    }

                    int Soma = 0, a = 0, d;
                    for (int j = CC.Length; j > 0; j--)
                    {
                        d = int.Parse(CC.Substring(j - 1, 1));
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

                    int DV = 10 - (Soma % 10);
                    if (DV == 10)
                    {
                        DV = 0;
                    }

                    sb.Append(CC + DV);

                    if (checkCVV.Checked)
                    {
                        string CVV;
                        if (txtCVV.Text.ToLower() == "rnd")
                        {
                            if ((CC.Substring(0, 2) == "37" || CC.Substring(0, 2) == "34") && CC.Length + 1 == 15)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else if (CC.Substring(0, 4) == "6011" && CC.Length + 1 == 16)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else
                            {
                                CVV = rnd.Next(101, 999).ToString();
                            }
                        }
                        else
                        {
                            CVV = txtCVV.Text;
                        }

                        sb.Append(", " + CVV);
                    }
                    if (checkData.Checked)
                    {
                        string Mes;
                        if (cboxMes.SelectedIndex == 0)
                        {
                            Mes = rnd.Next(1, 13).ToString();
                        }
                        else
                        {
                            Mes = cboxMes.Text;
                        }

                        if (Mes.Length == 1)
                        {
                            Mes = "0" + Mes;
                        }

                        Mes = Mes + "/";

                        string Ano;
                        if (cboxAno.SelectedIndex == 0)
                        {
                            Ano = rnd.Next(2018, 2026).ToString();
                        }
                        else
                        {
                            Ano = cboxAno.Text;
                        }

                        if (Ano.Length == 2)
                        {
                            Ano = "20" + Ano;
                        }

                        sb.Append(", " + Mes + Ano);
                    }
                    if (checkTipobanco.Checked)
                    {
                        string TipoBanco = "";
                        string CCDV = CC + DV;
                        for (int j = 0; j < BinsPreDefinidos.Length; j++)
                        {
                            if (CCBIN.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                            {
                                TipoBanco = ", " + cboxBins.Items[j + 1].ToString();
                                j = BinsPreDefinidos.Length;
                            }
                        }
                        if (TipoBanco == "")
                        {
                            if (CCDV.Substring(0, 1) == "4" && (CCDV.Length == 13 || CCDV.Length == 16))
                            {
                                TipoBanco = ", Visa";
                            }
                            else if ((CCDV.Substring(0, 2) == "51" || CCDV.Substring(0, 2) == "52" || CCDV.Substring(0, 2) == "53" || CCDV.Substring(0, 2) == "54" || CCDV.Substring(0, 2) == "55") && CCDV.Length == 16)
                            {
                                TipoBanco = ", Mastercard";
                            }
                            else if ((CCDV.Substring(0, 2) == "34" || CCDV.Substring(0, 2) == "37") && CCDV.Length == 15)
                            {
                                TipoBanco = ", American Express";
                            }
                            else if (CCDV.Substring(0, 4) == "6011" && CCDV.Length == 16)
                            {
                                TipoBanco = ", Discover";
                            }
                            else if ((CCDV.Substring(0, 4) == "3528" || CCDV.Substring(0, 4) == "3088" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3112" || CCDV.Substring(0, 4) == "3158" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3337") && CCDV.Length == 16)
                            {
                                TipoBanco = ", JCB";
                            }
                            else if ((CCDV.Substring(0, 2) == "30" || CCDV.Substring(0, 2) == "36" || CCDV.Substring(0, 2) == "38") && (CCDV.Length == 14 || CCDV.Length == 16))
                            {
                                TipoBanco = ", Diners Club";
                            }
                            else if ((CCDV.Substring(0, 4) == "2014" || CCDV.Substring(0, 4) == "2149") && CCDV.Length == 15)
                            {
                                TipoBanco = ", enRoute";
                            }
                            else if ((CCDV.Substring(0, 6) == "606282") && (CCDV.Length == 13 || CCDV.Length == 16 || CCDV.Length == 19))
                            {
                                TipoBanco = ", Hipercard";
                            }
                            else if ((CCDV.Substring(0, 6) == "636368" || CCDV.Substring(0, 6) == "636369" || CCDV.Substring(0, 6) == "438935" || CCDV.Substring(0, 6) == "504175" || CCDV.Substring(0, 6) == "451416" || CCDV.Substring(0, 6) == "636297" || CCDV.Substring(0, 4) == "5067" || CCDV.Substring(0, 4) == "4576" || CCDV.Substring(0, 4) == "4011" || CCDV.Substring(0, 6) == "506699") && CCDV.Length == 16)
                            {
                                TipoBanco = ", Elo";
                            }
                            else if (CCDV.Substring(0, 2) == "50" && CCDV.Length == 16)
                            {
                                TipoBanco = ", Aura";
                            }
                            else if ((CCDV.Substring(0, 4) == "4903" || CCDV.Substring(0, 4) == "4911" || CCDV.Substring(0, 4) == "4936" || CCDV.Substring(0, 4) == "5641" || CCDV.Substring(0, 4) == "6333" || CCDV.Substring(0, 4) == "6759" || CCDV.Substring(0, 4) == "6334" || CCDV.Substring(0, 4) == "6767") && CCDV.Length == 13)
                            {
                                TipoBanco = ", Switch";
                            }
                            else
                            {
                                TipoBanco = ", Desconhecido";
                            }
                        }
                        sb.Append(TipoBanco);
                    }

                    sb.Append(Environment.NewLine);
                }
                txtCCGerado.Text = sb.ToString();
                txtCCGerado.Text = txtCCGerado.Text.Trim();
            }
            else if (cboxChecker.SelectedIndex == 2)
            {
                sb.Append("<xml>" + Environment.NewLine);
                for (int i = 0; i < QuantidadeCC.Value; i++)
                {
                    string CC = "";

                    int CCBinLength = CCBin.Length - 1;
                    for (int j = 0; j < CCBinLength; j++)
                    {
                        if (CCBin[j].ToString().ToUpper() == "X")
                        {
                            CC += (rnd.Next(0, 10));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "M")
                        {
                            CC += (rnd.Next(1, 6));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "A")
                        {
                            if (rnd.Next(1, 3) == 1)
                            {
                                CC += 4;
                            }
                            else
                            {
                                CC += 7;
                            }
                        }
                        else
                        {
                            CC += (CCBin[j]);
                        }
                    }

                    int Soma = 0, a = 0, d;
                    for (int j = CC.Length; j > 0; j--)
                    {
                        d = int.Parse(CC.Substring(j - 1, 1));
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

                    int DV = 10 - (Soma % 10);
                    if (DV == 10)
                    {
                        DV = 0;
                    }

                    sb.Append("<CreditCard>" + Environment.NewLine);
                    if (checkTipobanco.Checked)
                    {
                        sb.Append("<CardNetwork>");
                        string TipoBanco = "";
                        string CCDV = CC + DV;
                        for (int j = 0; j < BinsPreDefinidos.Length; j++)
                        {
                            if (CCBIN.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                            {
                                TipoBanco = cboxBins.Items[j + 1].ToString();
                                j = BinsPreDefinidos.Length;
                            }
                        }
                        if (TipoBanco == "")
                        {
                            if (CCDV.Substring(0, 1) == "4" && (CCDV.Length == 13 || CCDV.Length == 16))
                            {
                                TipoBanco = "Visa";
                            }
                            else if ((CCDV.Substring(0, 2) == "51" || CCDV.Substring(0, 2) == "52" || CCDV.Substring(0, 2) == "53" || CCDV.Substring(0, 2) == "54" || CCDV.Substring(0, 2) == "55") && CCDV.Length == 16)
                            {
                                TipoBanco = "Mastercard";
                            }
                            else if ((CCDV.Substring(0, 2) == "34" || CCDV.Substring(0, 2) == "37") && CCDV.Length == 15)
                            {
                                TipoBanco = "American Express";
                            }
                            else if (CCDV.Substring(0, 4) == "6011" && CCDV.Length == 16)
                            {
                                TipoBanco = "Discover";
                            }
                            else if ((CCDV.Substring(0, 4) == "3528" || CCDV.Substring(0, 4) == "3088" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3112" || CCDV.Substring(0, 4) == "3158" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3337") && CCDV.Length == 16)
                            {
                                TipoBanco = "JCB";
                            }
                            else if ((CCDV.Substring(0, 2) == "30" || CCDV.Substring(0, 2) == "36" || CCDV.Substring(0, 2) == "38") && (CCDV.Length == 14 || CCDV.Length == 16))
                            {
                                TipoBanco = "Diners Club";
                            }
                            else if ((CCDV.Substring(0, 4) == "2014" || CCDV.Substring(0, 4) == "2149") && CCDV.Length == 15)
                            {
                                TipoBanco = "enRoute";
                            }
                            else if (CCDV.Substring(0, 6) == "606282" && (CCDV.Length == 13 || CCDV.Length == 16 || CCDV.Length == 19))
                            {
                                TipoBanco = "Hipercard";
                            }
                            else if ((CCDV.Substring(0, 6) == "636368" || CCDV.Substring(0, 6) == "636369" || CCDV.Substring(0, 6) == "438935" || CCDV.Substring(0, 6) == "504175" || CCDV.Substring(0, 6) == "451416" || CCDV.Substring(0, 6) == "636297" || CCDV.Substring(0, 4) == "5067" || CCDV.Substring(0, 4) == "4576" || CCDV.Substring(0, 4) == "4011" || CCDV.Substring(0, 6) == "506699") && CCDV.Length == 16)
                            {
                                TipoBanco = "Elo";
                            }
                            else if (CCDV.Substring(0, 2) == "50" && CCDV.Length == 16)
                            {
                                TipoBanco = "Aura";
                            }
                            else if ((CCDV.Substring(0, 4) == "4903" || CCDV.Substring(0, 4) == "4911" || CCDV.Substring(0, 4) == "4936" || CCDV.Substring(0, 4) == "5641" || CCDV.Substring(0, 4) == "6333" || CCDV.Substring(0, 4) == "6759" || CCDV.Substring(0, 4) == "6334" || CCDV.Substring(0, 4) == "6767") && CCDV.Length == 13)
                            {
                                TipoBanco = "Switch";
                            }
                            else
                            {
                                TipoBanco = "Desconhecido";
                            }
                        }
                        sb.Append(TipoBanco + "</CardNetwork>" + Environment.NewLine);
                    }

                    sb.Append("<CardNumber>");

                    sb.Append(CC + DV);

                    sb.Append("</CardNumber>");


                    if (checkCVV.Checked)
                    {
                        string CVV;
                        if (txtCVV.Text.ToLower() == "rnd")
                        {
                            if ((CC.Substring(0, 2) == "37" || CC.Substring(0, 2) == "34") && CC.Length + 1 == 15)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else if (CC.Substring(0, 4) == "6011" && CC.Length + 1 == 16)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else
                            {
                                CVV = rnd.Next(101, 999).ToString();
                            }
                        }
                        else
                        {
                            CVV = txtCVV.Text;
                        }

                        sb.Append(Environment.NewLine + "<CardCVV>" + CVV + "</CardCVV>");
                    }
                    if (checkData.Checked)
                    {
                        string Mes;
                        if (cboxMes.SelectedIndex == 0)
                        {
                            Mes = rnd.Next(1, 13).ToString();
                        }
                        else
                        {
                            Mes = cboxMes.Text;
                        }

                        if (Mes.Length == 1)
                        {
                            Mes = "0" + Mes;
                        }

                        Mes = Mes + "/";

                        string Ano;
                        if (cboxAno.SelectedIndex == 0)
                        {
                            Ano = rnd.Next(2018, 2026).ToString();
                        }
                        else
                        {
                            Ano = cboxAno.Text;
                        }

                        if (Ano.Length == 2)
                        {
                            Ano = "20" + Ano;
                        }



                        sb.Append(Environment.NewLine + "<CardExpDate>" + Mes + Ano + "</CardExpDate>");
                    }
                    sb.Append(Environment.NewLine + "</CreditCard>" + Environment.NewLine);
                }
                sb.Append("</xml>");
                txtCCGerado.Text = sb.ToString();
                txtCCGerado.Text = txtCCGerado.Text.Trim();
            }
            else
            {
                sb.Append("{" + Environment.NewLine);
                for (int i = 0; i < QuantidadeCC.Value; i++)
                {
                    string CC = "";

                    int CCBinLength = CCBin.Length - 1;
                    for (int j = 0; j < CCBinLength; j++)
                    {
                        if (CCBin[j].ToString().ToUpper() == "X")
                        {
                            CC += (rnd.Next(0, 10));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "M")
                        {
                            CC += (rnd.Next(1, 6));
                        }
                        else if (CCBin[j].ToString().ToUpper() == "A")
                        {
                            if (rnd.Next(1, 3) == 1)
                            {
                                CC += 4;
                            }
                            else
                            {
                                CC += 7;
                            }
                        }
                        else
                        {
                            CC += (CCBin[j]);
                        }
                    }

                    int Soma = 0, a = 0, d;
                    for (int j = CC.Length; j > 0; j--)
                    {
                        d = int.Parse(CC.Substring(j - 1, 1));
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

                    int DV = 10 - (Soma % 10);
                    if (DV == 10)
                    {
                        DV = 0;
                    }

                    sb.Append("{" + Environment.NewLine + "\"CreditCard\":{" + Environment.NewLine);

                    if (checkTipobanco.Checked)
                    {
                        string CCDV = CC + DV;
                        sb.Append("\"CardNetwork\": ");
                        string TipoBanco = "";
                        for (int j = 0; j < BinsPreDefinidos.Length; j++)
                        {
                            if (CCBIN.Substring(0, 6) == BinsPreDefinidos[j].Trim().Replace(" ", "").Replace("X", ""))
                            {
                                TipoBanco = "\"" + cboxBins.Items[j + 1].ToString() + "\"";
                                j = BinsPreDefinidos.Length;
                            }
                        }
                        if (TipoBanco == "")
                        {
                            if (CCDV.Substring(0, 1) == "4" && (CCDV.Length == 13 || CCDV.Length == 16))
                            {
                                TipoBanco = "\"Visa\"";
                            }
                            else if ((CCDV.Substring(0, 2) == "51" || CCDV.Substring(0, 2) == "52" || CCDV.Substring(0, 2) == "53" || CCDV.Substring(0, 2) == "54" || CCDV.Substring(0, 2) == "55") && CCDV.Length == 16)
                            {
                                TipoBanco = "\"Mastercard\"";
                            }
                            else if ((CCDV.Substring(0, 2) == "34" || CCDV.Substring(0, 2) == "37") && CCDV.Length == 15)
                            {
                                TipoBanco = "\"American Express\"";
                            }
                            else if (CCDV.Substring(0, 4) == "6011" && CCDV.Length == 16)
                            {
                                TipoBanco = "\"Discover\"";
                            }
                            else if ((CCDV.Substring(0, 4) == "3528" || CCDV.Substring(0, 4) == "3088" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3112" || CCDV.Substring(0, 4) == "3158" || CCDV.Substring(0, 4) == "3096" || CCDV.Substring(0, 4) == "3337") && CCDV.Length == 16)
                            {
                                TipoBanco = "\"JCB\"";
                            }
                            else if ((CCDV.Substring(0, 2) == "30" || CCDV.Substring(0, 2) == "36" || CCDV.Substring(0, 2) == "38") && (CCDV.Length == 14 || CCDV.Length == 16))
                            {
                                TipoBanco = "\"Diners Club\"";
                            }
                            else if ((CCDV.Substring(0, 4) == "2014" || CCDV.Substring(0, 4) == "2149") && CCDV.Length == 15)
                            {
                                TipoBanco = "\"enRoute\"";
                            }
                            else if (CCDV.Substring(0, 6) == "606282" && (CCDV.Length == 13 || CCDV.Length == 16 || CCDV.Length == 19))
                            {
                                TipoBanco = "\"Hipercard\"";
                            }
                            else if ((CCDV.Substring(0, 6) == "636368" || CCDV.Substring(0, 6) == "636369" || CCDV.Substring(0, 6) == "438935" || CCDV.Substring(0, 6) == "504175" || CCDV.Substring(0, 6) == "451416" || CCDV.Substring(0, 6) == "636297" || CCDV.Substring(0, 4) == "5067" || CCDV.Substring(0, 4) == "4576" || CCDV.Substring(0, 4) == "4011" || CCDV.Substring(0, 6) == "506699") && CCDV.Length == 16)
                            {
                                TipoBanco = "\"Elo\"";
                            }
                            else if (CCDV.Substring(0, 2) == "50" && CCDV.Length == 16)
                            {
                                TipoBanco = "\"Aura\"";
                            }
                            else if ((CCDV.Substring(0, 4) == "4903" || CCDV.Substring(0, 4) == "4911" || CCDV.Substring(0, 4) == "4936" || CCDV.Substring(0, 4) == "5641" || CCDV.Substring(0, 4) == "6333" || CCDV.Substring(0, 4) == "6759" || CCDV.Substring(0, 4) == "6334" || CCDV.Substring(0, 4) == "6767") && CCDV.Length == 13)
                            {
                                TipoBanco = "\"Switch\"";
                            }
                            else
                            {
                                TipoBanco = "Desconhecido";
                            }
                        }
                        sb.Append(TipoBanco + Environment.NewLine);
                    }
                    sb.Append("\"CardNumber\": ");

                    sb.Append("\"" + CC + DV + "\"");

                    if (checkCVV.Checked)
                    {
                        string CVV;
                        if (txtCVV.Text.ToLower() == "rnd")
                        {
                            if ((CC.Substring(0, 2) == "37" || CC.Substring(0, 2) == "34") && CC.Length + 1 == 15)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else if (CC.Substring(0, 4) == "6011" && CC.Length + 1 == 16)
                            {
                                CVV = rnd.Next(1000, 9999).ToString();
                            }
                            else
                            {
                                CVV = rnd.Next(101, 999).ToString();
                            }
                        }
                        else
                        {
                            CVV = txtCVV.Text;
                        }

                        sb.Append(Environment.NewLine + "\"CardCVV\": \"" + CVV + "\"");
                    }
                    if (checkData.Checked)
                    {
                        string Mes;
                        if (cboxMes.SelectedIndex == 0)
                        {
                            Mes = rnd.Next(1, 13).ToString();
                        }
                        else
                        {
                            Mes = cboxMes.Text;
                        }

                        if (Mes.Length == 1)
                        {
                            Mes = "0" + Mes;
                        }

                        Mes = Mes + "/";

                        string Ano;
                        if (cboxAno.SelectedIndex == 0)
                        {
                            Ano = rnd.Next(2018, 2026).ToString();
                        }
                        else
                        {
                            Ano = cboxAno.Text;
                        }

                        if (Ano.Length == 2)
                        {
                            Ano = "20" + Ano;
                        }

                        sb.Append(Environment.NewLine + "\"CardExpDate\": \"" + Mes + Ano + "\"");
                    }
                    sb.Append(Environment.NewLine + "}");
                    if (i == QuantidadeCC.Value - 1)
                    {
                        sb.Append(Environment.NewLine + "}");
                    }
                    else
                    {
                        sb.Append(Environment.NewLine + "}," + Environment.NewLine);
                    }
                }
                sb.Append(Environment.NewLine + "}");
                txtCCGerado.Text = sb.ToString();
                txtCCGerado.Text = txtCCGerado.Text.Trim();
            }

        }

        private void txtBIN_Leave(object sender, EventArgs e)
        {
            txtBIN.WaterMark = "XXXX XXXX XXXX XXXX";
            txtBIN.UseStyleColors = true;
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            txtCCGerado.UseStyleColors = true;
        }

        private void txtCVV_Leave(object sender, EventArgs e)
        {
            txtCVV.UseStyleColors = true;
        }

        private void txtBIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ('a' != e.KeyChar && 'A' != e.KeyChar && 'M' != e.KeyChar && 'm' != e.KeyChar && !char.IsNumber(e.KeyChar) && 'X' != e.KeyChar && 'x' != e.KeyChar && (char)8 != e.KeyChar && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBIN_Enter(object sender, EventArgs e)
        {
            txtBIN.WaterMark = "";
        }

        private void cboxBins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBins.SelectedIndex != 0)
            {
                if (BinsPreDefinidos[cboxBins.SelectedIndex - 1] == "3766 23" || BinsPreDefinidos[cboxBins.SelectedIndex - 1] == "3764 74")
                {
                    txtBIN.Text = BinsPreDefinidos[cboxBins.SelectedIndex - 1] + "XX XXXX XXX";
                }
                else
                {
                    txtBIN.Text = BinsPreDefinidos[cboxBins.SelectedIndex - 1] + "XX XXXX XXXX";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cardbinlist.com/bin-list-brazil.html?page=0");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();
            txtBIN.UseStyleColors = true;
            txtCCGerado.UseStyleColors = true;
            txtCVV.UseStyleColors = true;
        }

        private void QuantidadeCC_ValueChanged(object sender, EventArgs e)
        {
            if (QuantidadeCC.Value == 1)
            {
                btnGerar.Text = "Gerar Cartão c/ BIN";
            }
            else
            {
                btnGerar.Text = "Gerar Cartões c/ BIN";
            }
        }

        private void txtCCGerado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                if (txtCCGerado.SelectedText != "")
                {
                    Clipboard.SetText(txtCCGerado.SelectedText);
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                txtCCGerado.SelectAll();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(QuantidadeCC.Value > 1000))
            {
                GerarCC();
            }
            else
            {
                timer1.Stop();
                metroCheckBox1.Checked = false;
                metroCheckBox1.Text = "OFF";
                MessageBox.Show("Diminua o número de Cartões de Crédito a serem gerados para um melhor performance.", "Gerador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBIN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V)
            {
                if (Clipboard.GetText() != "" && Clipboard.GetText().Trim().Replace(" ", "").Length <= 16)
                {
                    int Length = 16 - Clipboard.GetText().Trim().Replace(" ", "").Length;
                    string Xs = "";
                    for (int i = 0; i < Length; i++)
                    {
                        Xs += "X";
                    }
                    txtBIN.Text = Clipboard.GetText().Trim().Replace(" ", "") + Xs;
                }
            }
            else if (e.KeyCode == Keys.C)
            {
                if (txtBIN.SelectedText != "")
                {
                    Clipboard.SetText(txtBIN.SelectedText);
                }
            }
        }

        private void txtBIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBIN.Text == "")
                {
                    cboxBins.SelectedIndex = 0;
                }
                for (int i = 0; i < BinsPreDefinidos.Length; i++)
                {
                    if (txtBIN.Text.Substring(0, 6) == BinsPreDefinidos[i].Replace(" ", "")
                        || txtBIN.Text.Substring(0, 5) == BinsPreDefinidos[i].Replace(" ", ""))
                    {
                        cboxBins.SelectedIndex = i + 1;
                        i = BinsPreDefinidos.Length;
                    }
                }
            }
            catch { }
        }

        private void metroCheckBox1_Click(object sender, EventArgs e)
        {
            if (!(QuantidadeCC.Value > 1000))
            {
                if (metroCheckBox1.Checked)
                {
                    metroCheckBox1.Text = "ON";
                    timer1.Start();
                }
                else { metroCheckBox1.Text = "OFF"; timer1.Stop(); }
            }
            else
            {
                metroCheckBox1.Checked = false;
                MessageBox.Show("Diminua o número de Cartões de Crédito a serem gerados para um melhor performance.", "Gerador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmGerador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Comunicacao.Comunica = true;
            try
            {
                if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Gerador")
                {
                    if (abrirGeradorDeCCToolStripMenuItem.Text.Contains("Gerador"))
                    {
                        Gerador_e_Validador_de_CC.Properties.Settings.Default.Run = "Validador";
                    }
                    else if (abrirGeradorDeCCToolStripMenuItem.Text.Contains("Validador"))
                    {
                        Gerador_e_Validador_de_CC.Properties.Settings.Default.Run = "Gerador";
                    }
                }
                Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxbins = cboxBins.SelectedIndex;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.checkCVV = checkCVV.Checked;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.checkData = checkData.Checked;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.checkTipoBanco = checkTipobanco.Checked;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.QuantidadeCC = (int)QuantidadeCC.Value;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxChecker = cboxChecker.SelectedIndex;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.txtCVV = txtCVV.Text;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxMes = cboxMes.SelectedIndex;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.cboxAno = cboxAno.SelectedIndex;
                Gerador_e_Validador_de_CC.Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por Lucas Naja", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/lucasnaja");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Comunicacao.Comunica == true)
            {
                timer2.Stop();
                Location = new Point(LocalX, LocalY);
                Focus();
                Comunicacao.Comunica = false;
                timer2.Start();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarCC();
            pictureBox1.Select();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (txtCCGerado.Text != "") { Clipboard.SetText(txtCCGerado.Text); }
            pictureBox1.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCCGerado.Clear(); pictureBox1.Select();
        }

        private void BtnValidador_Click(object sender, EventArgs e)
        {
            Form frmValidador = new frmValidador();
            if (!(Application.OpenForms.OfType<frmValidador>().Count() > 0))
            {
                WindowState = FormWindowState.Normal;
                Size = new Size(790, 366);
                Location = new Point(LocalX - 170, LocalY);
                frmValidador.Show();
                frmValidador.Location = new System.Drawing.Point(1 + this.Width + this.Location.X, this.Location.Y);
            }
            pictureBox1.Select();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string local = Application.StartupPath + @"\Cartões de Crédito.txt";
            int j = 1;
            while (System.IO.File.Exists(local))
            {
                local = Application.StartupPath + @"\Cartões de Crédito" + j + ".txt";
                j++;
            }
            if (txtCCGerado.Text != "")
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(local);
                sw.Write(txtCCGerado.Text);
                sw.Close();
                MessageBox.Show("Cartões de Crédito salvo com sucesso. " + Environment.NewLine + local, "Gerador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você precisa Gerar pelo menos 1 Cartão de Crédito", "Gerador de Cartão de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pictureBox1.Select();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
            pictureBox1.Select();
        }
        Size tamanhoForm = new Size(790, 366);
        private void FrmGerador_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                txtCCGerado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                groupBox8.Width = 1340;
                cboxBins.Width = groupBox8.Width - 141;
                txtCCGerado.Height = Size.Height - 163;
                txtCCGerado.Location = new Point(377, 116);
            }
            else if (Size == tamanhoForm)
            {
                txtCCGerado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                groupBox8.Width = 359;
                cboxBins.Width = groupBox8.Width - 141;
                txtCCGerado.Height = 257;
                txtCCGerado.Location = new Point(377, 63);
            }
        }

        private void códigoFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/0B4_hqByHqmaueXBLNzZwaUEtaFk?usp=sharing");
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

        private void btnDefault_Click(object sender, EventArgs e)
        {
            cboxBins.SelectedIndex = 0;
            checkCVV.Checked = false;
            checkData.Checked = false;
            checkTipobanco.Checked = false;
            QuantidadeCC.Value = 15;
            cboxChecker.SelectedIndex = 0;
            txtCVV.Text = "RND";
            cboxMes.SelectedIndex = 0;
            cboxAno.SelectedIndex = 0;
            pictureBox1.Select();
        }

        private void verificarAtualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAtualizar = new frmAtualizar();
            frmAtualizar.ShowDialog();
        }
    }
}