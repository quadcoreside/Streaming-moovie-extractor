namespace aSgare_Bot
{
    partial class ConfigScrapForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.list_configs = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chk_reCheckStep1 = new System.Windows.Forms.CheckBox();
            this.chk_nameAsUnique = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_itemNameIndices = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_itemDescriptionIndices = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_itemUrlSourceIndices = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_urls = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemImageIndices = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_itemUrlIndices = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_itemsColllectionIndices = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_configName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_itemPartNameIndices = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_itemPartCollectionIndices = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_itemPartUrlSourceIndices = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.list_configs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemPartUrlSourceIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemPartNameIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemPartCollectionIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.btn_load);
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.chk_reCheckStep1);
            this.splitContainer1.Panel2.Controls.Add(this.chk_nameAsUnique);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemNameIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemDescriptionIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemUrlSourceIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txt_urls);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemImageIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemUrlIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txt_itemsColllectionIndices);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_configName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(976, 655);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // list_configs
            // 
            this.list_configs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_configs.FormattingEnabled = true;
            this.list_configs.Location = new System.Drawing.Point(0, 0);
            this.list_configs.Name = "list_configs";
            this.list_configs.Size = new System.Drawing.Size(266, 655);
            this.list_configs.TabIndex = 0;
            this.list_configs.DoubleClick += new System.EventHandler(this.list_configs_DoubleClick);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(324, 610);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(123, 33);
            this.btn_load.TabIndex = 26;
            this.btn_load.Text = "Charger";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(195, 610);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 33);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_reCheckStep1
            // 
            this.chk_reCheckStep1.AutoSize = true;
            this.chk_reCheckStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_reCheckStep1.Location = new System.Drawing.Point(143, 442);
            this.chk_reCheckStep1.Name = "chk_reCheckStep1";
            this.chk_reCheckStep1.Size = new System.Drawing.Size(161, 19);
            this.chk_reCheckStep1.TabIndex = 24;
            this.chk_reCheckStep1.Text = "Recurssive Check Step 1";
            this.chk_reCheckStep1.UseVisualStyleBackColor = true;
            // 
            // chk_nameAsUnique
            // 
            this.chk_nameAsUnique.AutoSize = true;
            this.chk_nameAsUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_nameAsUnique.Location = new System.Drawing.Point(15, 442);
            this.chk_nameAsUnique.Name = "chk_nameAsUnique";
            this.chk_nameAsUnique.Size = new System.Drawing.Size(119, 19);
            this.chk_nameAsUnique.TabIndex = 23;
            this.chk_nameAsUnique.Text = "Name as Unique";
            this.chk_nameAsUnique.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Step 3";
            // 
            // txt_itemNameIndices
            // 
            this.txt_itemNameIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemNameIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemNameIndices.Location = new System.Drawing.Point(15, 150);
            this.txt_itemNameIndices.Name = "txt_itemNameIndices";
            this.txt_itemNameIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemNameIndices.TabIndex = 21;
            this.txt_itemNameIndices.Text = "div;class=\'movief\'";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Item name indices:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Step 2";
            // 
            // txt_itemDescriptionIndices
            // 
            this.txt_itemDescriptionIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemDescriptionIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemDescriptionIndices.Location = new System.Drawing.Point(15, 373);
            this.txt_itemDescriptionIndices.Name = "txt_itemDescriptionIndices";
            this.txt_itemDescriptionIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemDescriptionIndices.TabIndex = 16;
            this.txt_itemDescriptionIndices.Text = "div;class=\'filmaltiaciklama\'";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Item Description indices:";
            // 
            // txt_itemUrlSourceIndices
            // 
            this.txt_itemUrlSourceIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemUrlSourceIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemUrlSourceIndices.Location = new System.Drawing.Point(15, 326);
            this.txt_itemUrlSourceIndices.Name = "txt_itemUrlSourceIndices";
            this.txt_itemUrlSourceIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemUrlSourceIndices.TabIndex = 14;
            this.txt_itemUrlSourceIndices.Text = "div;class=\'filmicerik\';iframe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Item URL Source indices:";
            // 
            // txt_urls
            // 
            this.txt_urls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_urls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_urls.Location = new System.Drawing.Point(57, 32);
            this.txt_urls.Name = "txt_urls";
            this.txt_urls.Size = new System.Drawing.Size(637, 21);
            this.txt_urls.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "URLS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Step 1";
            // 
            // txt_itemImageIndices
            // 
            this.txt_itemImageIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemImageIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemImageIndices.Location = new System.Drawing.Point(15, 237);
            this.txt_itemImageIndices.Name = "txt_itemImageIndices";
            this.txt_itemImageIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemImageIndices.TabIndex = 9;
            this.txt_itemImageIndices.Text = "img;src";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Image indices:";
            // 
            // txt_itemUrlIndices
            // 
            this.txt_itemUrlIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemUrlIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemUrlIndices.Location = new System.Drawing.Point(15, 194);
            this.txt_itemUrlIndices.Name = "txt_itemUrlIndices";
            this.txt_itemUrlIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemUrlIndices.TabIndex = 7;
            this.txt_itemUrlIndices.Text = "a;href";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item URL indices:";
            // 
            // txt_itemsColllectionIndices
            // 
            this.txt_itemsColllectionIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemsColllectionIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemsColllectionIndices.Location = new System.Drawing.Point(15, 107);
            this.txt_itemsColllectionIndices.Name = "txt_itemsColllectionIndices";
            this.txt_itemsColllectionIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemsColllectionIndices.TabIndex = 5;
            this.txt_itemsColllectionIndices.Text = "div;class=\'moviefilm\';";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Items Collection indices:";
            // 
            // txt_configName
            // 
            this.txt_configName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_configName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_configName.Location = new System.Drawing.Point(121, 6);
            this.txt_configName.Name = "txt_configName";
            this.txt_configName.Size = new System.Drawing.Size(573, 21);
            this.txt_configName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la config:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Step 2";
            // 
            // txt_itemPartNameIndices
            // 
            this.txt_itemPartNameIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemPartNameIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPartNameIndices.Location = new System.Drawing.Point(15, 564);
            this.txt_itemPartNameIndices.Name = "txt_itemPartNameIndices";
            this.txt_itemPartNameIndices.Size = new System.Drawing.Size(339, 21);
            this.txt_itemPartNameIndices.TabIndex = 30;
            this.txt_itemPartNameIndices.Text = "span";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Item Sub Name indices:";
            // 
            // txt_itemPartCollectionIndices
            // 
            this.txt_itemPartCollectionIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemPartCollectionIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPartCollectionIndices.Location = new System.Drawing.Point(15, 517);
            this.txt_itemPartCollectionIndices.Name = "txt_itemPartCollectionIndices";
            this.txt_itemPartCollectionIndices.Size = new System.Drawing.Size(679, 21);
            this.txt_itemPartCollectionIndices.TabIndex = 28;
            this.txt_itemPartCollectionIndices.Text = "div;class=\'keremiya_part\';a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Item Sub Collection indices:";
            // 
            // txt_itemPartUrlSourceIndices
            // 
            this.txt_itemPartUrlSourceIndices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemPartUrlSourceIndices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPartUrlSourceIndices.Location = new System.Drawing.Point(360, 564);
            this.txt_itemPartUrlSourceIndices.Name = "txt_itemPartUrlSourceIndices";
            this.txt_itemPartUrlSourceIndices.Size = new System.Drawing.Size(334, 21);
            this.txt_itemPartUrlSourceIndices.TabIndex = 33;
            this.txt_itemPartUrlSourceIndices.Text = "a;href";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(357, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Item Sub Url Source indices:";
            // 
            // ConfigScrapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 655);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ConfigScrapForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigScrapForm";
            this.Load += new System.EventHandler(this.ConfigScrapForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_configName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_itemsColllectionIndices;
        private System.Windows.Forms.TextBox txt_itemImageIndices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_itemUrlIndices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_urls;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_itemDescriptionIndices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_itemUrlSourceIndices;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_itemNameIndices;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk_nameAsUnique;
        private System.Windows.Forms.CheckBox chk_reCheckStep1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ListBox list_configs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_itemPartNameIndices;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_itemPartCollectionIndices;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_itemPartUrlSourceIndices;
        private System.Windows.Forms.Label label15;
    }
}