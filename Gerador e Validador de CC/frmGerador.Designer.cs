namespace Gerador_de_CC_com_Bin
{
    partial class FrmGerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerador));
            this.txtBIN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkData = new MetroFramework.Controls.MetroCheckBox();
            this.checkCVV = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.QuantidadeCC = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboxChecker = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCVV = new MetroFramework.Controls.MetroTextBox();
            this.cboxMes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboxAno = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkTipobanco = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCCGerado = new MetroFramework.Controls.MetroTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboxBins = new MetroFramework.Controls.MetroComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnValidador = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAtualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirGeradorDeCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBIN
            // 
            this.txtBIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtBIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBIN.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBIN.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBIN.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtBIN.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.txtBIN.CustomButton.Name = "";
            this.txtBIN.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtBIN.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtBIN.CustomButton.TabIndex = 1;
            this.txtBIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBIN.CustomButton.UseCompatibleTextRendering = true;
            this.txtBIN.CustomButton.UseCustomBackColor = true;
            this.txtBIN.CustomButton.UseCustomForeColor = true;
            this.txtBIN.CustomButton.UseMnemonic = false;
            this.txtBIN.CustomButton.UseSelectable = true;
            this.txtBIN.CustomButton.UseStyleColors = true;
            this.txtBIN.CustomButton.UseVisualStyleBackColor = true;
            this.txtBIN.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.txtBIN.Lines = new string[] {
        "6666 66XX XXXX XXXX"};
            this.txtBIN.Location = new System.Drawing.Point(115, 14);
            this.txtBIN.MaxLength = 25;
            this.txtBIN.Name = "txtBIN";
            this.txtBIN.PasswordChar = '\0';
            this.txtBIN.WaterMark = "XXXX XXXX XXXX XXXX";
            this.txtBIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBIN.SelectedText = "";
            this.txtBIN.SelectionLength = 0;
            this.txtBIN.SelectionStart = 0;
            this.txtBIN.ShortcutsEnabled = true;
            this.txtBIN.ShowButton = true;
            this.txtBIN.Size = new System.Drawing.Size(238, 22);
            this.txtBIN.Style = MetroFramework.MetroColorStyle.Red;
            this.txtBIN.TabIndex = 9;
            this.txtBIN.Text = "6666 66XX XXXX XXXX";
            this.txtBIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBIN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBIN.UseCustomBackColor = true;
            this.txtBIN.UseCustomForeColor = true;
            this.txtBIN.UseSelectable = true;
            this.txtBIN.UseStyleColors = true;
            this.txtBIN.WaterMark = "XXXX XXXX XXXX XXXX";
            this.txtBIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBIN.TextChanged += new System.EventHandler(this.txtBIN_TextChanged);
            this.txtBIN.Enter += new System.EventHandler(this.txtBIN_Enter);
            this.txtBIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBIN_KeyPress);
            this.txtBIN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBIN_KeyUp);
            this.txtBIN.Leave += new System.EventHandler(this.txtBIN_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Insira sua BIN:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(2, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Incluir:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkData.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkData.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkData.Location = new System.Drawing.Point(173, 15);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(56, 19);
            this.checkData.Style = MetroFramework.MetroColorStyle.Red;
            this.checkData.TabIndex = 11;
            this.checkData.Text = "Data";
            this.checkData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkData.UseCustomBackColor = true;
            this.checkData.UseCustomForeColor = true;
            this.checkData.UseSelectable = true;
            this.checkData.UseStyleColors = true;
            // 
            // checkCVV
            // 
            this.checkCVV.AutoSize = true;
            this.checkCVV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCVV.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkCVV.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkCVV.Location = new System.Drawing.Point(115, 15);
            this.checkCVV.Name = "checkCVV";
            this.checkCVV.Size = new System.Drawing.Size(52, 19);
            this.checkCVV.Style = MetroFramework.MetroColorStyle.Red;
            this.checkCVV.TabIndex = 10;
            this.checkCVV.Text = "CVV";
            this.checkCVV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkCVV.UseCustomBackColor = true;
            this.checkCVV.UseCustomForeColor = true;
            this.checkCVV.UseSelectable = true;
            this.checkCVV.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(2, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Quantidade:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuantidadeCC
            // 
            this.QuantidadeCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.QuantidadeCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuantidadeCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.QuantidadeCC.Location = new System.Drawing.Point(93, 14);
            this.QuantidadeCC.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.QuantidadeCC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantidadeCC.Name = "QuantidadeCC";
            this.QuantidadeCC.Size = new System.Drawing.Size(63, 22);
            this.QuantidadeCC.TabIndex = 13;
            this.QuantidadeCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip1.SetToolTip(this.QuantidadeCC, "Selecionar quantidade de CCs a serem gerado");
            this.QuantidadeCC.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.QuantidadeCC.ValueChanged += new System.EventHandler(this.QuantidadeCC_ValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(5, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Formato:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboxChecker
            // 
            this.cboxChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cboxChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxChecker.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboxChecker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.cboxChecker.FormattingEnabled = true;
            this.cboxChecker.ItemHeight = 23;
            this.cboxChecker.Items.AddRange(new object[] {
            "CHECKER",
            "CSV",
            "XML",
            "JSON"});
            this.cboxChecker.Location = new System.Drawing.Point(79, 13);
            this.cboxChecker.Name = "cboxChecker";
            this.cboxChecker.Size = new System.Drawing.Size(105, 29);
            this.cboxChecker.Style = MetroFramework.MetroColorStyle.Red;
            this.cboxChecker.TabIndex = 14;
            this.cboxChecker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.cboxChecker, "Selecionar formato");
            this.cboxChecker.UseCustomBackColor = true;
            this.cboxChecker.UseCustomForeColor = true;
            this.cboxChecker.UseSelectable = true;
            this.cboxChecker.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(4, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "CVV:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.txtCVV.CustomButton.Image = null;
            this.txtCVV.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtCVV.CustomButton.Name = "";
            this.txtCVV.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCVV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCVV.CustomButton.TabIndex = 1;
            this.txtCVV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCVV.CustomButton.UseSelectable = true;
            this.txtCVV.CustomButton.Visible = false;
            this.txtCVV.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCVV.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.txtCVV.Lines = new string[] {
        "RND"};
            this.txtCVV.Location = new System.Drawing.Point(50, 12);
            this.txtCVV.MaxLength = 32767;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '\0';
            this.txtCVV.WaterMark = "rnd";
            this.txtCVV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCVV.SelectedText = "";
            this.txtCVV.SelectionLength = 0;
            this.txtCVV.SelectionStart = 0;
            this.txtCVV.ShortcutsEnabled = true;
            this.txtCVV.Size = new System.Drawing.Size(63, 25);
            this.txtCVV.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCVV.TabIndex = 15;
            this.txtCVV.Text = "RND";
            this.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCVV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCVV.UseCustomBackColor = true;
            this.txtCVV.UseCustomForeColor = true;
            this.txtCVV.UseSelectable = true;
            this.txtCVV.UseStyleColors = true;
            this.txtCVV.WaterMark = "rnd";
            this.txtCVV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCVV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCVV.Leave += new System.EventHandler(this.txtCVV_Leave);
            // 
            // cboxMes
            // 
            this.cboxMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cboxMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxMes.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboxMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.ItemHeight = 23;
            this.cboxMes.Items.AddRange(new object[] {
            "RND",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboxMes.Location = new System.Drawing.Point(48, 12);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(60, 29);
            this.cboxMes.Style = MetroFramework.MetroColorStyle.Red;
            this.cboxMes.TabIndex = 16;
            this.cboxMes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.cboxMes, "Selecionar mês");
            this.cboxMes.UseCustomBackColor = true;
            this.cboxMes.UseCustomForeColor = true;
            this.cboxMes.UseSelectable = true;
            this.cboxMes.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(6, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Mês:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            this.metroLabel6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(6, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Ano:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboxAno
            // 
            this.cboxAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cboxAno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxAno.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboxAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.cboxAno.FormattingEnabled = true;
            this.cboxAno.ItemHeight = 23;
            this.cboxAno.Items.AddRange(new object[] {
            "RND",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cboxAno.Location = new System.Drawing.Point(48, 13);
            this.cboxAno.Name = "cboxAno";
            this.cboxAno.Size = new System.Drawing.Size(60, 29);
            this.cboxAno.Style = MetroFramework.MetroColorStyle.Red;
            this.cboxAno.TabIndex = 17;
            this.cboxAno.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.cboxAno, "Selecionar ano");
            this.cboxAno.UseCustomBackColor = true;
            this.cboxAno.UseCustomForeColor = true;
            this.cboxAno.UseSelectable = true;
            this.cboxAno.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtBIN);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkTipobanco);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.checkData);
            this.groupBox2.Controls.Add(this.checkCVV);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // checkTipobanco
            // 
            this.checkTipobanco.AutoSize = true;
            this.checkTipobanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTipobanco.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkTipobanco.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkTipobanco.Location = new System.Drawing.Point(235, 15);
            this.checkTipobanco.Name = "checkTipobanco";
            this.checkTipobanco.Size = new System.Drawing.Size(110, 19);
            this.checkTipobanco.Style = MetroFramework.MetroColorStyle.Red;
            this.checkTipobanco.TabIndex = 12;
            this.checkTipobanco.Text = "Tipo - Banco";
            this.checkTipobanco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkTipobanco.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkTipobanco.UseCustomBackColor = true;
            this.checkTipobanco.UseCustomForeColor = true;
            this.checkTipobanco.UseSelectable = true;
            this.checkTipobanco.UseStyleColors = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.QuantidadeCC);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.cboxChecker);
            this.groupBox4.Location = new System.Drawing.Point(181, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 50);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroLabel5);
            this.groupBox5.Controls.Add(this.txtCVV);
            this.groupBox5.Location = new System.Drawing.Point(12, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 44);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.metroLabel6);
            this.groupBox6.Controls.Add(this.cboxMes);
            this.groupBox6.Location = new System.Drawing.Point(137, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 49);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.metroLabel7);
            this.groupBox7.Controls.Add(this.cboxAno);
            this.groupBox7.Location = new System.Drawing.Point(257, 256);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 50);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // txtCCGerado
            // 
            this.txtCCGerado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtCCGerado.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCCGerado.CustomButton.Image = null;
            this.txtCCGerado.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtCCGerado.CustomButton.Name = "";
            this.txtCCGerado.CustomButton.Size = new System.Drawing.Size(255, 255);
            this.txtCCGerado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCCGerado.CustomButton.TabIndex = 1;
            this.txtCCGerado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCCGerado.CustomButton.UseCompatibleTextRendering = true;
            this.txtCCGerado.CustomButton.UseCustomBackColor = true;
            this.txtCCGerado.CustomButton.UseCustomForeColor = true;
            this.txtCCGerado.CustomButton.UseSelectable = true;
            this.txtCCGerado.CustomButton.Visible = false;
            this.txtCCGerado.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCCGerado.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCCGerado.Lines = new string[0];
            this.txtCCGerado.Location = new System.Drawing.Point(377, 63);
            this.txtCCGerado.MaxLength = 999999999;
            this.txtCCGerado.Multiline = true;
            this.txtCCGerado.Name = "txtCCGerado";
            this.txtCCGerado.PasswordChar = '\0';
            this.txtCCGerado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCCGerado.SelectedText = "";
            this.txtCCGerado.SelectionLength = 0;
            this.txtCCGerado.SelectionStart = 0;
            this.txtCCGerado.ShortcutsEnabled = false;
            this.txtCCGerado.Size = new System.Drawing.Size(402, 257);
            this.txtCCGerado.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCCGerado.TabIndex = 24;
            this.txtCCGerado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCCGerado.UseCustomBackColor = true;
            this.txtCCGerado.UseCustomForeColor = true;
            this.txtCCGerado.UseSelectable = true;
            this.txtCCGerado.UseStyleColors = true;
            this.txtCCGerado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCCGerado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCCGerado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCCGerado_KeyUp);
            this.txtCCGerado.Leave += new System.EventHandler(this.metroTextBox1_Leave);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.metroLabel8);
            this.groupBox8.Controls.Add(this.cboxBins);
            this.groupBox8.Location = new System.Drawing.Point(12, 58);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(359, 50);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(6, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(129, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Bins predefinidos:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            this.metroLabel8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboxBins
            // 
            this.cboxBins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cboxBins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxBins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxBins.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboxBins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.cboxBins.FormattingEnabled = true;
            this.cboxBins.ItemHeight = 23;
            this.cboxBins.Items.AddRange(new object[] {
            "Insira sua BIN",
            "Maestro - WIRECARD BANK AG",
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
            "Amex - CITIBANK",
            "Visa",
            "Mastercard",
            "Discover",
            "American Express",
            "Diners Club",
            "JCB",
            "Hipercard"});
            this.cboxBins.Location = new System.Drawing.Point(135, 13);
            this.cboxBins.Name = "cboxBins";
            this.cboxBins.Size = new System.Drawing.Size(218, 29);
            this.cboxBins.Style = MetroFramework.MetroColorStyle.Red;
            this.cboxBins.TabIndex = 8;
            this.cboxBins.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.cboxBins, "Selecionar uma Bin predefinida");
            this.cboxBins.UseCustomBackColor = true;
            this.cboxBins.UseCustomForeColor = true;
            this.cboxBins.UseSelectable = true;
            this.cboxBins.UseStyleColors = true;
            this.cboxBins.SelectedIndexChanged += new System.EventHandler(this.cboxBins_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 19);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<> SITE DE BINS <>";
            this.metroToolTip1.SetToolTip(this.linkLabel1, "Clique para abrir o site de BINS");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(9, 305);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(60, 25);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox1.TabIndex = 23;
            this.metroCheckBox1.Text = "OFF";
            this.metroCheckBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroCheckBox1, "Marque esta opção para gerar aleatoriamente até ser desmarcada.");
            this.metroCheckBox1.UseCustomBackColor = true;
            this.metroCheckBox1.UseCustomForeColor = true;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            this.metroCheckBox1.Click += new System.EventHandler(this.metroCheckBox1_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnGerar.FlatAppearance.BorderSize = 2;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(78, 313);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(293, 44);
            this.btnGerar.TabIndex = 18;
            this.btnGerar.Text = "Gerar Cartões c/ BIN";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.btnGerar, "Clique para Gerar Cartões de Créditos aleatórios de acordo com as configurações");
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(545, 326);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 31);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.metroToolTip1.SetToolTip(this.btnLimpar, "Clique para Limpar o conteúdo da Caixa de Cartões de Crédito Gerados");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnValidador
            // 
            this.btnValidador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnValidador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnValidador.FlatAppearance.BorderSize = 2;
            this.btnValidador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnValidador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnValidador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidador.Location = new System.Drawing.Point(377, 326);
            this.btnValidador.Name = "btnValidador";
            this.btnValidador.Size = new System.Drawing.Size(162, 31);
            this.btnValidador.TabIndex = 19;
            this.btnValidador.Text = "Validador de CC";
            this.metroToolTip1.SetToolTip(this.btnValidador, "Clique para abrir o Validador de Cartão de Crédito");
            this.btnValidador.UseVisualStyleBackColor = false;
            this.btnValidador.Visible = false;
            this.btnValidador.Click += new System.EventHandler(this.BtnValidador_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnCopiar.FlatAppearance.BorderSize = 2;
            this.btnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(628, 326);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(74, 31);
            this.btnCopiar.TabIndex = 21;
            this.btnCopiar.Text = "Copiar";
            this.metroToolTip1.SetToolTip(this.btnCopiar, "Clique para Copiar o conteúdo da Caixa de Cartões de Créditos Gerados");
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(708, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 31);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.metroToolTip1.SetToolTip(this.btnSalvar, "Clique para Salvar o conteúdo da Caixa de Cartões de Créditos Gerados");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnDefault.FlatAppearance.BorderSize = 2;
            this.btnDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(9, 332);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(66, 25);
            this.btnDefault.TabIndex = 35;
            this.btnDefault.Text = "Default";
            this.metroToolTip1.SetToolTip(this.btnDefault, "Clique para deixar as configurações padrão");
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 45;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(68, 24);
            this.menuStrip1.TabIndex = 34;
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
            this.verificarAtualizaçãoToolStripMenuItem,
            this.abrirPastaToolStripMenuItem,
            this.toolStripMenuItem2,
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
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // códigoFonteToolStripMenuItem
            // 
            this.códigoFonteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.códigoFonteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("códigoFonteToolStripMenuItem.Image")));
            this.códigoFonteToolStripMenuItem.Name = "códigoFonteToolStripMenuItem";
            this.códigoFonteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.códigoFonteToolStripMenuItem.Text = "Código Fonte";
            this.códigoFonteToolStripMenuItem.Click += new System.EventHandler(this.códigoFonteToolStripMenuItem_Click);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youTubeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youTubeToolStripMenuItem.Image")));
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // verificarAtualizaçãoToolStripMenuItem
            // 
            this.verificarAtualizaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarAtualizaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verificarAtualizaçãoToolStripMenuItem.Image")));
            this.verificarAtualizaçãoToolStripMenuItem.Name = "verificarAtualizaçãoToolStripMenuItem";
            this.verificarAtualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.verificarAtualizaçãoToolStripMenuItem.Text = "Verificar atualização";
            this.verificarAtualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.verificarAtualizaçãoToolStripMenuItem_Click);
            // 
            // abrirPastaToolStripMenuItem
            // 
            this.abrirPastaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirPastaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirPastaToolStripMenuItem.Image")));
            this.abrirPastaToolStripMenuItem.Name = "abrirPastaToolStripMenuItem";
            this.abrirPastaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirPastaToolStripMenuItem.Text = "Abrir pasta";
            this.abrirPastaToolStripMenuItem.Click += new System.EventHandler(this.abrirPastaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // abrirGeradorDeCCToolStripMenuItem
            // 
            this.abrirGeradorDeCCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirGeradorDeCCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirGeradorDeCCToolStripMenuItem.Image")));
            this.abrirGeradorDeCCToolStripMenuItem.Name = "abrirGeradorDeCCToolStripMenuItem";
            this.abrirGeradorDeCCToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.abrirGeradorDeCCToolStripMenuItem.Text = "Abrir pelo Validador de CC";
            this.abrirGeradorDeCCToolStripMenuItem.Click += new System.EventHandler(this.abrirGeradorDeCCToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 286);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // FrmGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnValidador);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.txtCCGerado);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(790, 366);
            this.Name = "FrmGerador";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = ".:: Gerador de CC ::.";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGerador_FormClosing);
            this.Load += new System.EventHandler(this.frmGerar_Load);
            this.SizeChanged += new System.EventHandler(this.FrmGerador_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBIN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox checkData;
        private MetroFramework.Controls.MetroCheckBox checkCVV;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown QuantidadeCC;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboxChecker;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCVV;
        private MetroFramework.Controls.MetroComboBox cboxMes;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboxAno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroTextBox txtCCGerado;
        private System.Windows.Forms.GroupBox groupBox8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cboxBins;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip metroToolTip1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox checkTipobanco;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnValidador;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirGeradorDeCCToolStripMenuItem;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verificarAtualizaçãoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

