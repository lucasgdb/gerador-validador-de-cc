namespace Gerador_e_Validador_de_CC
{
    partial class frmAtualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizar));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.lblPorcentagem = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBaixado = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVerifica = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Versão do programa:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(170, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Última versão: Aguardando";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 2;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(23, 117);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(135, 25);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "Verificar atualização";
            this.toolTip1.SetToolTip(this.btnAtualizar, "Clique para verificar uma nova Versão do programa");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 153);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(338, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar1.TabIndex = 37;
            this.metroProgressBar1.UseCustomBackColor = true;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(20, 181);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(93, 19);
            this.lblPorcentagem.TabIndex = 38;
            this.lblPorcentagem.Text = "Progresso: 0%";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Tamanho do arquivo: 0KB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 198);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblBaixado
            // 
            this.lblBaixado.AutoSize = true;
            this.lblBaixado.Location = new System.Drawing.Point(20, 219);
            this.lblBaixado.Name = "lblBaixado";
            this.lblBaixado.Size = new System.Drawing.Size(85, 19);
            this.lblBaixado.TabIndex = 42;
            this.lblBaixado.Text = "Baixado: 0KB";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblVerifica
            // 
            this.lblVerifica.AutoSize = true;
            this.lblVerifica.Location = new System.Drawing.Point(158, 120);
            this.lblVerifica.Name = "lblVerifica";
            this.lblVerifica.Size = new System.Drawing.Size(74, 19);
            this.lblVerifica.TabIndex = 44;
            this.lblVerifica.Text = "Verificando";
            this.lblVerifica.Visible = false;
            // 
            // frmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.lblVerifica);
            this.Controls.Add(this.lblBaixado);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtualizar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Atualizador";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAtualizar_FormClosing);
            this.Load += new System.EventHandler(this.frmAtualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnAtualizar;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel lblPorcentagem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblBaixado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblVerifica;
    }
}