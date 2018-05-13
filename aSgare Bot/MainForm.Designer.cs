namespace aSgare_Bot
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_items_sended = new System.Windows.Forms.Label();
            this.txt_items_found = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_configName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_loadConfig = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.list_result = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsFound = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerAuServeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.list_sended = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sendedMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValiderParametre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_urlAPi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_onlineState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.cmsFound.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.sendedMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 26);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel1.Controls.Add(this.txt_items_sended, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_items_found, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_items_sended
            // 
            this.txt_items_sended.AutoSize = true;
            this.txt_items_sended.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_items_sended.Location = new System.Drawing.Point(348, 0);
            this.txt_items_sended.Name = "txt_items_sended";
            this.txt_items_sended.Size = new System.Drawing.Size(134, 18);
            this.txt_items_sended.TabIndex = 1;
            this.txt_items_sended.Text = "Items sended: 0";
            // 
            // txt_items_found
            // 
            this.txt_items_found.AutoSize = true;
            this.txt_items_found.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_items_found.Location = new System.Drawing.Point(3, 0);
            this.txt_items_found.Name = "txt_items_found";
            this.txt_items_found.Size = new System.Drawing.Size(120, 18);
            this.txt_items_found.TabIndex = 0;
            this.txt_items_found.Text = "Items found: 0";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 50);
            this.panel2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(964, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(8, 32);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(20, 15);
            this.txt_status.TabIndex = 0;
            this.txt_status.Text = "[+]";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 381);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(980, 381);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_configName);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btn_loadConfig);
            this.tabPage3.Controls.Add(this.btn_start);
            this.tabPage3.Controls.Add(this.list_result);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 355);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Items fond";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_configName
            // 
            this.txt_configName.AutoSize = true;
            this.txt_configName.Location = new System.Drawing.Point(54, 95);
            this.txt_configName.Name = "txt_configName";
            this.txt_configName.Size = new System.Drawing.Size(78, 13);
            this.txt_configName.TabIndex = 7;
            this.txt_configName.Text = "N/A                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Config:";
            // 
            // btn_loadConfig
            // 
            this.btn_loadConfig.Location = new System.Drawing.Point(7, 57);
            this.btn_loadConfig.Name = "btn_loadConfig";
            this.btn_loadConfig.Size = new System.Drawing.Size(205, 35);
            this.btn_loadConfig.TabIndex = 4;
            this.btn_loadConfig.Text = "Charger une config";
            this.btn_loadConfig.UseVisualStyleBackColor = true;
            this.btn_loadConfig.Click += new System.EventHandler(this.btn_loadConfig_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(7, 16);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(205, 35);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Démarer";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // list_result
            // 
            this.list_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_result.ContextMenuStrip = this.cmsFound;
            this.list_result.FullRowSelect = true;
            this.list_result.GridLines = true;
            this.list_result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_result.Location = new System.Drawing.Point(217, 3);
            this.list_result.Name = "list_result";
            this.list_result.Size = new System.Drawing.Size(756, 346);
            this.list_result.TabIndex = 1;
            this.list_result.UseCompatibleStateImageBehavior = false;
            this.list_result.View = System.Windows.Forms.View.Details;
            this.list_result.DoubleClick += new System.EventHandler(this.list_result_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titre";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre de lien";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Domain";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "date";
            this.columnHeader6.Width = 146;
            // 
            // cmsFound
            // 
            this.cmsFound.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.envoyerAuServeurToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cmsFound.Name = "cmsFound";
            this.cmsFound.Size = new System.Drawing.Size(174, 70);
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.voirToolStripMenuItem.Text = "Voir";
            this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
            // 
            // envoyerAuServeurToolStripMenuItem
            // 
            this.envoyerAuServeurToolStripMenuItem.Name = "envoyerAuServeurToolStripMenuItem";
            this.envoyerAuServeurToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.envoyerAuServeurToolStripMenuItem.Text = "Envoyer au serveur";
            this.envoyerAuServeurToolStripMenuItem.Click += new System.EventHandler(this.envoyerAuServeurToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.list_sended);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 355);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Items Sended";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // list_sended
            // 
            this.list_sended.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader14});
            this.list_sended.ContextMenuStrip = this.sendedMenuStrip;
            this.list_sended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_sended.FullRowSelect = true;
            this.list_sended.GridLines = true;
            this.list_sended.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_sended.Location = new System.Drawing.Point(3, 3);
            this.list_sended.Name = "list_sended";
            this.list_sended.Size = new System.Drawing.Size(966, 349);
            this.list_sended.TabIndex = 2;
            this.list_sended.UseCompatibleStateImageBehavior = false;
            this.list_sended.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Titre";
            this.columnHeader8.Width = 149;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre de lien";
            this.columnHeader9.Width = 258;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Domain";
            this.columnHeader13.Width = 128;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "date";
            this.columnHeader14.Width = 146;
            // 
            // sendedMenuStrip
            // 
            this.sendedMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.sendedMenuStrip.Name = "cmsFound";
            this.sendedMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Voir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.voirStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Renvoyer au serveur";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.renvoyerStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Supprimer";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.supprimerStripMenuItem3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(970, 447);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_onlineState);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_country);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnValiderParametre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_urlAPi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serveur";
            // 
            // btnValiderParametre
            // 
            this.btnValiderParametre.Location = new System.Drawing.Point(17, 101);
            this.btnValiderParametre.Name = "btnValiderParametre";
            this.btnValiderParametre.Size = new System.Drawing.Size(97, 27);
            this.btnValiderParametre.TabIndex = 2;
            this.btnValiderParametre.Text = "Valider";
            this.btnValiderParametre.UseVisualStyleBackColor = true;
            this.btnValiderParametre.Click += new System.EventHandler(this.btnValiderParametre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "API URL:";
            // 
            // txt_urlAPi
            // 
            this.txt_urlAPi.Location = new System.Drawing.Point(17, 37);
            this.txt_urlAPi.Name = "txt_urlAPi";
            this.txt_urlAPi.Size = new System.Drawing.Size(555, 20);
            this.txt_urlAPi.TabIndex = 0;
            this.txt_urlAPi.Text = "http://api.wara.fr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pays code:";
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(17, 76);
            this.txt_country.MaxLength = 2;
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(57, 20);
            this.txt_country.TabIndex = 4;
            this.txt_country.Text = "FR";
            // 
            // txt_onlineState
            // 
            this.txt_onlineState.Location = new System.Drawing.Point(174, 76);
            this.txt_onlineState.MaxLength = 2;
            this.txt_onlineState.Name = "txt_onlineState";
            this.txt_onlineState.Size = new System.Drawing.Size(57, 20);
            this.txt_onlineState.TabIndex = 6;
            this.txt_onlineState.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "En ligne statuts:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 479);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aSgare Scrap items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.cmsFound.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.sendedMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txt_items_sended;
        private System.Windows.Forms.Label txt_items_found;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_loadConfig;
        public System.Windows.Forms.Label txt_status;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txt_configName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView list_result;
        private System.Windows.Forms.ContextMenuStrip cmsFound;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerAuServeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        public System.Windows.Forms.ListView list_sended;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValiderParametre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_urlAPi;
        private System.Windows.Forms.ContextMenuStrip sendedMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_onlineState;
        private System.Windows.Forms.Label label4;
    }
}

