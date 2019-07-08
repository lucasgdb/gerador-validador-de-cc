namespace Gerador_de_CC
{
    partial class frmValidador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidador));
            this.txtCC = new MetroFramework.Controls.MetroTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.YouTube = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerSelecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCCsVerdadeirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCCsFalsosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarCartãoDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDeCCSelecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAtualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirGeradorDeCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.YouTube)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCC
            // 
            // 
            // 
            // 
            this.txtCC.CustomButton.Image = null;
            this.txtCC.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtCC.CustomButton.Name = "";
            this.txtCC.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCC.CustomButton.TabIndex = 1;
            this.txtCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCC.CustomButton.UseSelectable = true;
            this.txtCC.CustomButton.Visible = false;
            this.txtCC.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.txtCC.Lines = new string[0];
            this.txtCC.Location = new System.Drawing.Point(106, 66);
            this.txtCC.MaxLength = 30;
            this.txtCC.Name = "txtCC";
            this.txtCC.PasswordChar = '\0';
            this.txtCC.WaterMark = "Cartão de Crédito (Ex: 4342067723236137)";
            this.txtCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCC.SelectedText = "";
            this.txtCC.SelectionLength = 0;
            this.txtCC.SelectionStart = 0;
            this.txtCC.ShortcutsEnabled = false;
            this.txtCC.Size = new System.Drawing.Size(244, 22);
            this.txtCC.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCC.TabIndex = 0;
            this.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCC.UseCustomBackColor = true;
            this.txtCC.UseCustomForeColor = true;
            this.txtCC.UseSelectable = true;
            this.txtCC.UseStyleColors = true;
            this.txtCC.WaterMark = "Cartão de Crédito (Ex: 4342067723236137)";
            this.txtCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCC.Enter += new System.EventHandler(this.txtCC_Enter);
            this.txtCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCC_KeyPress);
            this.txtCC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCC_KeyUp);
            this.txtCC.Leave += new System.EventHandler(this.txtCC_Leave);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnImportar.FlatAppearance.BorderSize = 2;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(10, 63);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(90, 30);
            this.btnImportar.TabIndex = 38;
            this.btnImportar.Text = "Importar";
            this.toolTip1.SetToolTip(this.btnImportar, "Clique para Importar os Cartões de Crédito de um Arquivo de Texto");
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnColar
            // 
            this.btnColar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnColar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnColar.FlatAppearance.BorderSize = 2;
            this.btnColar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnColar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnColar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColar.Location = new System.Drawing.Point(10, 97);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(76, 30);
            this.btnColar.TabIndex = 39;
            this.btnColar.Text = "Colar";
            this.toolTip1.SetToolTip(this.btnColar, "Clique para Validar os Cartões de Crédito da Área de Transferência");
            this.btnColar.UseVisualStyleBackColor = false;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnValidar.FlatAppearance.BorderSize = 2;
            this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(252, 93);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(98, 34);
            this.btnValidar.TabIndex = 40;
            this.btnValidar.Text = "Validar";
            this.toolTip1.SetToolTip(this.btnValidar, "Clique para Validar o Cartão de Crédito da Caixa de Texto");
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(279, 416);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 30);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnSalvar, "Clique para Salvar os Cartões de Crédito Validados em um Arquivo de Texto");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // YouTube
            // 
            this.YouTube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YouTube.Image = ((System.Drawing.Image)(resources.GetObject("YouTube.Image")));
            this.YouTube.Location = new System.Drawing.Point(10, 30);
            this.YouTube.Name = "YouTube";
            this.YouTube.Size = new System.Drawing.Size(34, 31);
            this.YouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YouTube.TabIndex = 5;
            this.YouTube.TabStop = false;
            this.toolTip1.SetToolTip(this.YouTube, "YouTube");
            this.YouTube.Click += new System.EventHandler(this.YouTube_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(198, 416);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Clique para limpar os Cartões de Crédito Validados");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGerador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnGerador.FlatAppearance.BorderSize = 2;
            this.btnGerador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGerador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerador.Location = new System.Drawing.Point(10, 416);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(141, 30);
            this.btnGerador.TabIndex = 47;
            this.btnGerador.Text = "Gerador de CC";
            this.toolTip1.SetToolTip(this.btnGerador, "Clique para abrir o Gerador de Cartão de Crédito");
            this.btnGerador.UseVisualStyleBackColor = false;
            this.btnGerador.Visible = false;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRegras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnRegras.FlatAppearance.BorderSize = 2;
            this.btnRegras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRegras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.Location = new System.Drawing.Point(10, 415);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(79, 33);
            this.btnRegras.TabIndex = 48;
            this.btnRegras.Text = "Regras";
            this.toolTip1.SetToolTip(this.btnRegras, "Clique para ver as Regras de um Cartão de Crédito Verdadeiro");
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Visible = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.Black;
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.metroListView1.ContextMenuStrip = this.contextMenuStrip1;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(10, 132);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.ShowGroups = false;
            this.metroListView1.Size = new System.Drawing.Size(340, 278);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroListView1.TabIndex = 6;
            this.metroListView1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.UseStyleColors = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroListView1_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cartão de Crédito";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Validade";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerSelecionadoToolStripMenuItem,
            this.removerCCsVerdadeirosToolStripMenuItem,
            this.removerCCsFalsosToolStripMenuItem,
            this.removerTodosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copiarCartãoDeCréditoToolStripMenuItem,
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem,
            this.informaçõesDeCCSelecionadoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 164);
            // 
            // removerSelecionadoToolStripMenuItem
            // 
            this.removerSelecionadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerSelecionadoToolStripMenuItem.Image")));
            this.removerSelecionadoToolStripMenuItem.Name = "removerSelecionadoToolStripMenuItem";
            this.removerSelecionadoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.removerSelecionadoToolStripMenuItem.Text = "Remover selecionado";
            this.removerSelecionadoToolStripMenuItem.Click += new System.EventHandler(this.removerSelecionadoToolStripMenuItem_Click);
            // 
            // removerCCsVerdadeirosToolStripMenuItem
            // 
            this.removerCCsVerdadeirosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerCCsVerdadeirosToolStripMenuItem.Image")));
            this.removerCCsVerdadeirosToolStripMenuItem.Name = "removerCCsVerdadeirosToolStripMenuItem";
            this.removerCCsVerdadeirosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.removerCCsVerdadeirosToolStripMenuItem.Text = "Remover CCs Verdadeiros";
            this.removerCCsVerdadeirosToolStripMenuItem.Click += new System.EventHandler(this.removerCCsVerdadeirosToolStripMenuItem_Click);
            // 
            // removerCCsFalsosToolStripMenuItem
            // 
            this.removerCCsFalsosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerCCsFalsosToolStripMenuItem.Image")));
            this.removerCCsFalsosToolStripMenuItem.Name = "removerCCsFalsosToolStripMenuItem";
            this.removerCCsFalsosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.removerCCsFalsosToolStripMenuItem.Text = "Remover CCs Falsos";
            this.removerCCsFalsosToolStripMenuItem.Click += new System.EventHandler(this.removerCCsFalsosToolStripMenuItem_Click);
            // 
            // removerTodosToolStripMenuItem
            // 
            this.removerTodosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerTodosToolStripMenuItem.Image")));
            this.removerTodosToolStripMenuItem.Name = "removerTodosToolStripMenuItem";
            this.removerTodosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.removerTodosToolStripMenuItem.Text = "Remover todos";
            this.removerTodosToolStripMenuItem.Click += new System.EventHandler(this.removerTodosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(250, 6);
            // 
            // copiarCartãoDeCréditoToolStripMenuItem
            // 
            this.copiarCartãoDeCréditoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarCartãoDeCréditoToolStripMenuItem.Image")));
            this.copiarCartãoDeCréditoToolStripMenuItem.Name = "copiarCartãoDeCréditoToolStripMenuItem";
            this.copiarCartãoDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.copiarCartãoDeCréditoToolStripMenuItem.Text = "Copiar Cartão de Crédito";
            this.copiarCartãoDeCréditoToolStripMenuItem.Click += new System.EventHandler(this.copiarCartãoDeCréditoToolStripMenuItem_Click);
            // 
            // quantidadeDeCartõesDeCréditoToolStripMenuItem
            // 
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quantidadeDeCartõesDeCréditoToolStripMenuItem.Image")));
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem.Name = "quantidadeDeCartõesDeCréditoToolStripMenuItem";
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem.Text = "Quantidade de Cartões de Crédito";
            this.quantidadeDeCartõesDeCréditoToolStripMenuItem.Click += new System.EventHandler(this.quantidadeDeCartõesDeCréditoToolStripMenuItem_Click);
            // 
            // informaçõesDeCCSelecionadoToolStripMenuItem
            // 
            this.informaçõesDeCCSelecionadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaçõesDeCCSelecionadoToolStripMenuItem.Image")));
            this.informaçõesDeCCSelecionadoToolStripMenuItem.Name = "informaçõesDeCCSelecionadoToolStripMenuItem";
            this.informaçõesDeCCSelecionadoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.informaçõesDeCCSelecionadoToolStripMenuItem.Text = "Informações do CC selecionado";
            this.informaçõesDeCCSelecionadoToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDeCCSelecionadoToolStripMenuItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lblStatus.Location = new System.Drawing.Point(7, 449);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 19);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Red;
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Status: OK";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStatus.UseCustomBackColor = true;
            this.lblStatus.UseCustomForeColor = true;
            this.lblStatus.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 393);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(68, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem,
            this.códigoFonteToolStripMenuItem,
            this.youTubeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.abrirPastaToolStripMenuItem,
            this.verificarAtualizaçãoToolStripMenuItem,
            this.regrasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.abrirGeradorDeCCToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.créditosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("créditosToolStripMenuItem.Image")));
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // códigoFonteToolStripMenuItem
            // 
            this.códigoFonteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.códigoFonteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("códigoFonteToolStripMenuItem.Image")));
            this.códigoFonteToolStripMenuItem.Name = "códigoFonteToolStripMenuItem";
            this.códigoFonteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.códigoFonteToolStripMenuItem.Text = "Código Fonte";
            this.códigoFonteToolStripMenuItem.Click += new System.EventHandler(this.códigoFonteToolStripMenuItem_Click);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youTubeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youTubeToolStripMenuItem.Image")));
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // abrirPastaToolStripMenuItem
            // 
            this.abrirPastaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirPastaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirPastaToolStripMenuItem.Image")));
            this.abrirPastaToolStripMenuItem.Name = "abrirPastaToolStripMenuItem";
            this.abrirPastaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abrirPastaToolStripMenuItem.Text = "Abrir pasta";
            this.abrirPastaToolStripMenuItem.Click += new System.EventHandler(this.abrirPastaToolStripMenuItem_Click);
            // 
            // verificarAtualizaçãoToolStripMenuItem
            // 
            this.verificarAtualizaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarAtualizaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verificarAtualizaçãoToolStripMenuItem.Image")));
            this.verificarAtualizaçãoToolStripMenuItem.Name = "verificarAtualizaçãoToolStripMenuItem";
            this.verificarAtualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.verificarAtualizaçãoToolStripMenuItem.Text = "Verificar atualização";
            this.verificarAtualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.verificarAtualizaçãoToolStripMenuItem_Click);
            // 
            // regrasToolStripMenuItem
            // 
            this.regrasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regrasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regrasToolStripMenuItem.Image")));
            this.regrasToolStripMenuItem.Name = "regrasToolStripMenuItem";
            this.regrasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.regrasToolStripMenuItem.Text = "Regras";
            this.regrasToolStripMenuItem.Click += new System.EventHandler(this.regrasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 6);
            // 
            // abrirGeradorDeCCToolStripMenuItem
            // 
            this.abrirGeradorDeCCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirGeradorDeCCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirGeradorDeCCToolStripMenuItem.Image")));
            this.abrirGeradorDeCCToolStripMenuItem.Name = "abrirGeradorDeCCToolStripMenuItem";
            this.abrirGeradorDeCCToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abrirGeradorDeCCToolStripMenuItem.Text = "Abrir pelo Gerador de CC";
            this.abrirGeradorDeCCToolStripMenuItem.Click += new System.EventHandler(this.abrirGeradorDeCCToolStripMenuItem_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.metroLabel1.Location = new System.Drawing.Point(90, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Separadores -> | , ; : -";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmValidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 473);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnGerador);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnColar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.YouTube);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmValidador";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = ".:: Validador de CC ::.";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmValidador_FormClosing);
            this.Load += new System.EventHandler(this.frmValidador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YouTube)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtCC;
        private System.Windows.Forms.PictureBox YouTube;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnSalvar;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerSelecionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerCCsVerdadeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerCCsFalsosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarCartãoDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeDeCartõesDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDeCCSelecionadoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirGeradorDeCCToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolStripMenuItem regrasToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem verificarAtualizaçãoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}