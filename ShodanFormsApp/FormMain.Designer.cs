namespace ShodanDesktop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPISettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCreditValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripEmail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtURLip = new System.Windows.Forms.TextBox();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.buttonResolve = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuery = new System.Windows.Forms.Label();
            this.checkQuery = new System.Windows.Forms.CheckBox();
            this.comboQuery = new System.Windows.Forms.ComboBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.labelFacets = new System.Windows.Forms.Label();
            this.checkFacets = new System.Windows.Forms.CheckBox();
            this.comboFacet = new System.Windows.Forms.ComboBox();
            this.txtFacet = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelURLexample = new System.Windows.Forms.Label();
            this.txtExampleOutput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPIurl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL2 = new System.Windows.Forms.TextBox();
            this.comboPart2URL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL3 = new System.Windows.Forms.TextBox();
            this.comboPart3URL = new System.Windows.Forms.ComboBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPISettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aPISettingsToolStripMenuItem
            // 
            this.aPISettingsToolStripMenuItem.Name = "aPISettingsToolStripMenuItem";
            this.aPISettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.aPISettingsToolStripMenuItem.Text = "API Settings";
            this.aPISettingsToolStripMenuItem.Click += new System.EventHandler(this.apiMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.treeViewToolStripMenuItem.Text = "Tree View";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreditValue,
            this.toolStripKey,
            this.toolStripEmail,
            this.toolStripCredits});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCreditValue
            // 
            this.toolStripCreditValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCreditValue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCreditValue.Image")));
            this.toolStripCreditValue.Name = "toolStripCreditValue";
            this.toolStripCreditValue.Size = new System.Drawing.Size(20, 20);
            this.toolStripCreditValue.Text = "(Click Here)";
            this.toolStripCreditValue.Click += new System.EventHandler(this.toolStripRefresh_Click);
            // 
            // toolStripKey
            // 
            this.toolStripKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripKey.Image = ((System.Drawing.Image)(resources.GetObject("toolStripKey.Image")));
            this.toolStripKey.Name = "toolStripKey";
            this.toolStripKey.Size = new System.Drawing.Size(826, 20);
            this.toolStripKey.Spring = true;
            this.toolStripKey.Text = "[API Key]";
            // 
            // toolStripEmail
            // 
            this.toolStripEmail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEmail.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEmail.Image")));
            this.toolStripEmail.Name = "toolStripEmail";
            this.toolStripEmail.Size = new System.Drawing.Size(84, 20);
            this.toolStripEmail.Text = "[Email]";
            this.toolStripEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripCredits
            // 
            this.toolStripCredits.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripCredits.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCredits.Image")));
            this.toolStripCredits.Name = "toolStripCredits";
            this.toolStripCredits.Size = new System.Drawing.Size(100, 20);
            this.toolStripCredits.Text = "[Credits]";
            this.toolStripCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 28);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxOutput);
            this.splitContainerMain.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainerMain.Size = new System.Drawing.Size(1045, 573);
            this.splitContainerMain.SplitterDistance = 241;
            this.splitContainerMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel5);
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(0, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Settings";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 142);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(541, 45);
            this.flowLayoutPanel5.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonUpdate);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConnect);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClear);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.txtURLip);
            this.flowLayoutPanel3.Controls.Add(this.buttonReverse);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtHostname);
            this.flowLayoutPanel3.Controls.Add(this.buttonResolve);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(559, 109);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(478, 78);
            this.flowLayoutPanel3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "IP:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtURLip
            // 
            this.txtURLip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLip.Location = new System.Drawing.Point(109, 3);
            this.txtURLip.Name = "txtURLip";
            this.txtURLip.Size = new System.Drawing.Size(291, 31);
            this.txtURLip.TabIndex = 2;
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(406, 3);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(57, 23);
            this.buttonReverse.TabIndex = 17;
            this.buttonReverse.Text = "REVR";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "HOST:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHostname
            // 
            this.txtHostname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostname.Location = new System.Drawing.Point(109, 40);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(291, 31);
            this.txtHostname.TabIndex = 3;
            this.txtHostname.Text = "google.com";
            // 
            // buttonResolve
            // 
            this.buttonResolve.Location = new System.Drawing.Point(406, 40);
            this.buttonResolve.Name = "buttonResolve";
            this.buttonResolve.Size = new System.Drawing.Size(57, 23);
            this.buttonResolve.TabIndex = 18;
            this.buttonResolve.Text = "RESO";
            this.buttonResolve.UseVisualStyleBackColor = true;
            this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labelQuery);
            this.flowLayoutPanel4.Controls.Add(this.checkQuery);
            this.flowLayoutPanel4.Controls.Add(this.comboQuery);
            this.flowLayoutPanel4.Controls.Add(this.txtQuery);
            this.flowLayoutPanel4.Controls.Add(this.labelFacets);
            this.flowLayoutPanel4.Controls.Add(this.checkFacets);
            this.flowLayoutPanel4.Controls.Add(this.comboFacet);
            this.flowLayoutPanel4.Controls.Add(this.txtFacet);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(559, 21);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(478, 82);
            this.flowLayoutPanel4.TabIndex = 28;
            // 
            // labelQuery
            // 
            this.labelQuery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuery.ForeColor = System.Drawing.Color.Black;
            this.labelQuery.Location = new System.Drawing.Point(3, 0);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(100, 31);
            this.labelQuery.TabIndex = 0;
            this.labelQuery.Text = "Query:";
            this.labelQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkQuery
            // 
            this.checkQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkQuery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuery.Location = new System.Drawing.Point(109, 3);
            this.checkQuery.Name = "checkQuery";
            this.checkQuery.Size = new System.Drawing.Size(18, 31);
            this.checkQuery.TabIndex = 29;
            this.checkQuery.UseVisualStyleBackColor = true;
            this.checkQuery.CheckedChanged += new System.EventHandler(this.checkQuery_CheckedChanged);
            // 
            // comboQuery
            // 
            this.comboQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuery.FormattingEnabled = true;
            this.comboQuery.Items.AddRange(new object[] {
            "after",
            "asn",
            "before",
            "bitcoin.ip",
            "bitcoin.ip_count",
            "bitcoin.port",
            "bitcoin.version",
            "city",
            "country",
            "geo",
            "has_ipv6",
            "has_screenshot",
            "hash",
            "hostname",
            "http.component",
            "http.component_category",
            "http.html",
            "http.html_hash",
            "http.status",
            "http.title",
            "isp",
            "link",
            "net",
            "ntp.ip",
            "ntp.ip_count",
            "ntp.more",
            "ntp.port",
            "org",
            "os",
            "port",
            "postal",
            "product",
            "ssl",
            "ssl.alpn",
            "ssl.cert.alg",
            "ssl.cert.expired",
            "ssl.cert.extension",
            "ssl.cert.pubkey.bits",
            "ssl.cert.pubkey.type",
            "ssl.cert.serial",
            "ssl.chain_count",
            "ssl.cipher.bits",
            "ssl.cipher.name",
            "ssl.cipher.version",
            "ssl.version",
            "state",
            "telnet.do",
            "telnet.dont",
            "telnet.option",
            "telnet.will",
            "telnet.wont",
            "version"});
            this.comboQuery.Location = new System.Drawing.Point(133, 3);
            this.comboQuery.Name = "comboQuery";
            this.comboQuery.Size = new System.Drawing.Size(166, 31);
            this.comboQuery.TabIndex = 27;
            this.comboQuery.SelectedIndexChanged += new System.EventHandler(this.comboQuery_SelectedIndexChanged);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(305, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(167, 31);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // labelFacets
            // 
            this.labelFacets.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacets.ForeColor = System.Drawing.Color.Black;
            this.labelFacets.Location = new System.Drawing.Point(3, 37);
            this.labelFacets.Name = "labelFacets";
            this.labelFacets.Size = new System.Drawing.Size(100, 31);
            this.labelFacets.TabIndex = 25;
            this.labelFacets.Text = "Facet:";
            this.labelFacets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkFacets
            // 
            this.checkFacets.AutoSize = true;
            this.checkFacets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkFacets.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFacets.Location = new System.Drawing.Point(109, 40);
            this.checkFacets.Name = "checkFacets";
            this.checkFacets.Size = new System.Drawing.Size(18, 31);
            this.checkFacets.TabIndex = 23;
            this.checkFacets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFacets.UseVisualStyleBackColor = true;
            this.checkFacets.CheckedChanged += new System.EventHandler(this.checkFacets_CheckedChanged);
            // 
            // comboFacet
            // 
            this.comboFacet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFacet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFacet.FormattingEnabled = true;
            this.comboFacet.Items.AddRange(new object[] {
            "asn",
            "bitcoin.ip",
            "bitcoin.ip_count",
            "bitcoin.port",
            "bitcoin.user_agent",
            "bitcoin.version",
            "city",
            "country",
            "device",
            "domain",
            "geocluster",
            "has_screenshot",
            "http.component",
            "http.component_category",
            "http.html_hash",
            "http.status",
            "http.title",
            "isp",
            "link",
            "ntp.ip",
            "ntp.ip_count",
            "ntp.more",
            "ntp.port",
            "org",
            "os",
            "port",
            "postal",
            "ssh.cipher",
            "ssh.fingerprint",
            "ssh.mac",
            "ssh.type",
            "ssl.alpn",
            "ssl.cert.alg",
            "ssl.cert.expired",
            "ssl.cert.fingerprint",
            "ssl.cert.pubkey.bits",
            "ssl.cert.pubkey.type",
            "ssl.cert.serial",
            "ssl.chain_count",
            "ssl.cipher.bits",
            "ssl.cipher.name",
            "ssl.cipher.version",
            "ssl.extension",
            "ssl.version",
            "state",
            "telnet.do",
            "telnet.dont",
            "telnet.option",
            "telnet.will",
            "telnet.wont",
            "timestamp_day",
            "timestamp_month",
            "timestamp_year",
            "uptime",
            "version"});
            this.comboFacet.Location = new System.Drawing.Point(133, 40);
            this.comboFacet.Name = "comboFacet";
            this.comboFacet.Size = new System.Drawing.Size(166, 31);
            this.comboFacet.TabIndex = 26;
            this.comboFacet.SelectedIndexChanged += new System.EventHandler(this.comboFacet_SelectedIndexChanged);
            // 
            // txtFacet
            // 
            this.txtFacet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacet.Location = new System.Drawing.Point(305, 40);
            this.txtFacet.Multiline = true;
            this.txtFacet.Name = "txtFacet";
            this.txtFacet.Size = new System.Drawing.Size(167, 31);
            this.txtFacet.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelURLexample);
            this.flowLayoutPanel2.Controls.Add(this.txtExampleOutput);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 193);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1025, 30);
            this.flowLayoutPanel2.TabIndex = 30;
            // 
            // labelURLexample
            // 
            this.labelURLexample.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURLexample.ForeColor = System.Drawing.Color.Black;
            this.labelURLexample.Location = new System.Drawing.Point(3, 0);
            this.labelURLexample.Name = "labelURLexample";
            this.labelURLexample.Size = new System.Drawing.Size(100, 23);
            this.labelURLexample.TabIndex = 12;
            this.labelURLexample.Text = "Example:";
            // 
            // txtExampleOutput
            // 
            this.txtExampleOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.txtExampleOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExampleOutput.Location = new System.Drawing.Point(109, 3);
            this.txtExampleOutput.Multiline = true;
            this.txtExampleOutput.Name = "txtExampleOutput";
            this.txtExampleOutput.Size = new System.Drawing.Size(910, 22);
            this.txtExampleOutput.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtAPIurl);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtURL2);
            this.flowLayoutPanel1.Controls.Add(this.comboPart2URL);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtURL3);
            this.flowLayoutPanel1.Controls.Add(this.comboPart3URL);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 117);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAPIurl
            // 
            this.txtAPIurl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPIurl.Location = new System.Drawing.Point(109, 3);
            this.txtAPIurl.Name = "txtAPIurl";
            this.txtAPIurl.Size = new System.Drawing.Size(422, 31);
            this.txtAPIurl.TabIndex = 2;
            this.txtAPIurl.Text = "https://api.shodan.io";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Part 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtURL2
            // 
            this.txtURL2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL2.Location = new System.Drawing.Point(109, 40);
            this.txtURL2.Name = "txtURL2";
            this.txtURL2.Size = new System.Drawing.Size(167, 31);
            this.txtURL2.TabIndex = 0;
            // 
            // comboPart2URL
            // 
            this.comboPart2URL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPart2URL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPart2URL.FormattingEnabled = true;
            this.comboPart2URL.Items.AddRange(new object[] {
            "shodan",
            "account",
            "dns",
            "tools",
            "api-info",
            "labs"});
            this.comboPart2URL.Location = new System.Drawing.Point(282, 40);
            this.comboPart2URL.Name = "comboPart2URL";
            this.comboPart2URL.Size = new System.Drawing.Size(249, 31);
            this.comboPart2URL.TabIndex = 19;
            this.comboPart2URL.SelectedIndexChanged += new System.EventHandler(this.comboPart2URL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Part 3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtURL3
            // 
            this.txtURL3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL3.Location = new System.Drawing.Point(109, 77);
            this.txtURL3.Name = "txtURL3";
            this.txtURL3.Size = new System.Drawing.Size(167, 31);
            this.txtURL3.TabIndex = 1;
            // 
            // comboPart3URL
            // 
            this.comboPart3URL.AutoCompleteCustomSource.AddRange(new string[] {
            "-- Search Methods --",
            "host/{ip}",
            "host/count",
            "host/search",
            "host/search/tokens",
            "ports",
            "-- Demand Scan --",
            "protocols",
            "scan (1 credit)",
            "scan/internet (Restricted)",
            "scan/{id} ",
            "-- Network Alerts --",
            "alert (POST)",
            "alert/{id}/info",
            "alert/{id} (DELETE)",
            "alert/info",
            "-- Directory Methods --",
            "query",
            "query/search",
            "query/tags",
            "-- Bulk Data --",
            "data",
            "data/{dataset}"});
            this.comboPart3URL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPart3URL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPart3URL.FormattingEnabled = true;
            this.comboPart3URL.Items.AddRange(new object[] {
            "0. -- Search Methods --",
            "1. host/{ip}",
            "2. host/count",
            "3. host/search",
            "4. host/search/tokens",
            "5. ports",
            "6. -- Demand Scan --",
            "7. protocols",
            "8. scan (1 credit)",
            "9. scan/internet (Restricted)",
            "10. scan/{id} ",
            "11. -- Network Alerts --",
            "12. alert (POST)",
            "13. alert/{id}/info",
            "14. alert/{id} (DELETE)",
            "15. alert/info",
            "16. -- Directory Methods --",
            "17. query",
            "18. query/search",
            "19. query/tags",
            "20. -- Bulk Data --",
            "21. data",
            "22. data/{dataset}"});
            this.comboPart3URL.Location = new System.Drawing.Point(282, 77);
            this.comboPart3URL.Name = "comboPart3URL";
            this.comboPart3URL.Size = new System.Drawing.Size(249, 31);
            this.comboPart3URL.TabIndex = 20;
            this.comboPart3URL.SelectedIndexChanged += new System.EventHandler(this.comboPart3URL_SelectedIndexChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(1045, 328);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.Text = "root@logicawe:";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.Control;
            this.txtKey.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(774, 3);
            this.txtKey.MaxLength = 128;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(69, 23);
            this.txtKey.TabIndex = 9;
            this.txtKey.Text = "null";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 626);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "SHODAN - REST API";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPISettingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAPIurl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL2;
        private System.Windows.Forms.Label labelURLexample;
        private System.Windows.Forms.TextBox txtExampleOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtURLip;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCreditValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripEmail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCredits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Button buttonResolve;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.ToolStripStatusLabel toolStripKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.ComboBox comboPart2URL;
        private System.Windows.Forms.ComboBox comboPart3URL;
        private System.Windows.Forms.CheckBox checkFacets;
        private System.Windows.Forms.ComboBox comboFacet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label labelFacets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox comboQuery;
        private System.Windows.Forms.TextBox txtFacet;
        private System.Windows.Forms.CheckBox checkQuery;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
    }
}

