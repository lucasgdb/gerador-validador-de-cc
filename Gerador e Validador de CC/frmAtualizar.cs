using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
namespace Gerador_e_Validador_de_CC
{
    public partial class frmAtualizar : MetroFramework.Forms.MetroForm
    {
        public frmAtualizar()
        {
            InitializeComponent();
        }

        private void frmAtualizar_Load(object sender, EventArgs e)
        {
            pictureBox1.Select();
            string VersaoDoPrograma = Application.ProductVersion;
            metroLabel1.Text = "Versão do Programa: V" + VersaoDoPrograma;
            metroLabel2.Text = "Última versão: Aguardando";
        }

        bool Atualizando = false;

        int V1, V2, V3;

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();

            try
            {
                btnAtualizar.Enabled = false;
                lblVerifica.Visible = true;
                WebClient Web = new WebClient();
                Web.DownloadStringAsync(new Uri("https://drive.google.com/uc?authuser=0&id=1bpVdsyUj3oOn1gLbcVRE7uZjIczI5Yc_&export=download"));
                Web.DownloadStringCompleted += (ss, ee) =>
                {
                    try
                    {
                        string Info = ee.Result;
                        string VersaoAtual = Info.Split('\n')[0];
                        string VersaoDoPrograma = Application.ProductVersion;
                        metroLabel1.Text = "Versão do Programa: V" + VersaoDoPrograma;
                        metroLabel2.Text = "Última versão: V" + VersaoAtual;
                        if (Convert.ToDecimal(VersaoDoPrograma) < Convert.ToDecimal(VersaoAtual))
                        {
                            if (MessageBox.Show("Há uma nova versão disponível." + Environment.NewLine + "Deseja atualizar?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    Atualizando = true;
                                    lblVerifica.Text = "Atualizando";
                                    V1 = int.Parse(VersaoAtual.Split('.')[0]);
                                    V2 = int.Parse(VersaoAtual.Split('.')[1]);
                                    V3 = int.Parse(VersaoAtual.Split('.')[2]);
                                    Web.DownloadFileAsync(new Uri(Info.Split('\n')[1]), Application.StartupPath + @"\Gerador & Validador de CC V" + V1 + "." + V2 + "." + V3 + "." + "exe");
                                    Web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Web_DownloadProgress);
                                    Web.DownloadFileCompleted += new AsyncCompletedEventHandler(Web_DownloadCompleted);
                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else
                            {
                                btnAtualizar.Enabled = true;
                                lblVerifica.Visible = false;
                            }
                        }
                        else
                        {
                            btnAtualizar.Enabled = true;
                            lblVerifica.Visible = false;
                            MessageBox.Show("Não há nova versão disponível.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        btnAtualizar.Enabled = true;
                        lblVerifica.Visible = false;
                        MessageBox.Show("Erro. Verifique sua conexão com a internet!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

            }
            catch (Exception ex)
            {
                btnAtualizar.Enabled = true;
                lblVerifica.Visible = false;
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Web_DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Maximum = Convert.ToInt32(e.TotalBytesToReceive);
            metroLabel3.Text = "Tamanho do arquivo: " + e.TotalBytesToReceive / 1024 + "KB";
            metroProgressBar1.Value = Convert.ToInt32(e.BytesReceived);
            lblPorcentagem.Text = "Progresso: " + (e.ProgressPercentage) + "%";
            lblBaixado.Text = "Baixado: " + e.BytesReceived / 1024 + "KB";
        }

        void Web_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lblVerifica.Text = "Programa atualizado.";
            Atualizando = false;
            MessageBox.Show("A nova versão foi baixada com sucesso! Reiniciando o programa...", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Gerador & Validador de CC V" + V1 + "." + V2 + "." + V3 + ".exe");
            Application.Exit();
        }

        private void frmAtualizar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Atualizando)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblVerifica.Text == "Verificando")
            {
                lblVerifica.Text = "Verificando.";
            }
            else if (lblVerifica.Text == "Verificando.")
            {
                lblVerifica.Text = "Verificando..";
            }
            else if (lblVerifica.Text == "Verificando..")
            {
                lblVerifica.Text = "Verificando...";
            }
            else if (lblVerifica.Text == "Verificando...")
            {
                lblVerifica.Text = "Verificando";
            }

            if (lblVerifica.Text == "Atualizando")
            {
                lblVerifica.Text = "Atualizando.";
            }
            else if (lblVerifica.Text == "Atualizando.")
            {
                lblVerifica.Text = "Atualizando..";
            }
            else if (lblVerifica.Text == "Atualizando..")
            {
                lblVerifica.Text = "Atualizando...";
            }
            else if (lblVerifica.Text == "Atualizando...")
            {
                lblVerifica.Text = "Atualizando";
            }

            if (metroLabel2.Text == "Última versão: Aguardando")
            {
                metroLabel2.Text = "Última versão: Aguardando.";
            }
            else if (metroLabel2.Text == "Última versão: Aguardando.")
            {
                metroLabel2.Text = "Última versão: Aguardando..";
            }
            else if (metroLabel2.Text == "Última versão: Aguardando..")
            {
                metroLabel2.Text = "Última versão: Aguardando...";
            }
            else if (metroLabel2.Text == "Última versão: Aguardando...")
            {
                metroLabel2.Text = "Última versão: Aguardando";
            }
        }
    }
}
