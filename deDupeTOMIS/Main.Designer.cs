namespace deDupeTOMIS
{
    partial class Main
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
            this.tabDeDupMain = new System.Windows.Forms.TabControl();
            this.tabFacialRecognition = new System.Windows.Forms.TabPage();
            this.splitContainerMainFr = new System.Windows.Forms.SplitContainer();
            this.btnWebCamStart = new System.Windows.Forms.Button();
            this.btnIdentifyImage = new System.Windows.Forms.Button();
            this.btnDeDupStart = new System.Windows.Forms.Button();
            this.btnImageFromFile = new System.Windows.Forms.Button();
            this.btnGenTemplatesTomis = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpImgOriginal = new System.Windows.Forms.GroupBox();
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.grpImgModified = new System.Windows.Forms.GroupBox();
            this.imgProcessed = new System.Windows.Forms.PictureBox();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.grpBoxTomisDbSetup = new System.Windows.Forms.GroupBox();
            this.dbTomisPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbTomisUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dbTomisSysName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnectToTomis = new System.Windows.Forms.Button();
            this.grpBoxIPPSetup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnectIPP = new System.Windows.Forms.Button();
            this.grpBoxTemplateDbSetup = new System.Windows.Forms.GroupBox();
            this.dbSigPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbSigUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbSigUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectTemplateDb = new System.Windows.Forms.Button();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ippEndPtStatLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagIPP = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagTomisDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagTomisDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagTemplateDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagTemplateDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabDeDupMain.SuspendLayout();
            this.tabFacialRecognition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainFr)).BeginInit();
            this.splitContainerMainFr.Panel1.SuspendLayout();
            this.splitContainerMainFr.Panel2.SuspendLayout();
            this.splitContainerMainFr.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpImgOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            this.grpImgModified.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProcessed)).BeginInit();
            this.tabSetup.SuspendLayout();
            this.grpBoxTomisDbSetup.SuspendLayout();
            this.grpBoxIPPSetup.SuspendLayout();
            this.grpBoxTemplateDbSetup.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusBarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeDupMain
            // 
            this.tabDeDupMain.Controls.Add(this.tabFacialRecognition);
            this.tabDeDupMain.Controls.Add(this.tabSetup);
            this.tabDeDupMain.Controls.Add(this.tabResults);
            this.tabDeDupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeDupMain.Location = new System.Drawing.Point(0, 0);
            this.tabDeDupMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDeDupMain.Name = "tabDeDupMain";
            this.tabDeDupMain.SelectedIndex = 0;
            this.tabDeDupMain.Size = new System.Drawing.Size(1893, 992);
            this.tabDeDupMain.TabIndex = 1;
            // 
            // tabFacialRecognition
            // 
            this.tabFacialRecognition.Controls.Add(this.splitContainerMainFr);
            this.tabFacialRecognition.Location = new System.Drawing.Point(4, 29);
            this.tabFacialRecognition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFacialRecognition.Name = "tabFacialRecognition";
            this.tabFacialRecognition.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFacialRecognition.Size = new System.Drawing.Size(1885, 959);
            this.tabFacialRecognition.TabIndex = 0;
            this.tabFacialRecognition.Text = "Facial Recognition";
            this.tabFacialRecognition.UseVisualStyleBackColor = true;
            // 
            // splitContainerMainFr
            // 
            this.splitContainerMainFr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMainFr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMainFr.IsSplitterFixed = true;
            this.splitContainerMainFr.Location = new System.Drawing.Point(4, 5);
            this.splitContainerMainFr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerMainFr.Name = "splitContainerMainFr";
            // 
            // splitContainerMainFr.Panel1
            // 
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnExit);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnWebCamStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnIdentifyImage);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnDeDupStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnImageFromFile);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnGenTemplatesTomis);
            this.splitContainerMainFr.Panel1MinSize = 375;
            // 
            // splitContainerMainFr.Panel2
            // 
            this.splitContainerMainFr.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMainFr.Size = new System.Drawing.Size(1886, 975);
            this.splitContainerMainFr.SplitterDistance = 375;
            this.splitContainerMainFr.SplitterWidth = 2;
            this.splitContainerMainFr.TabIndex = 0;
            // 
            // btnWebCamStart
            // 
            this.btnWebCamStart.Location = new System.Drawing.Point(26, 422);
            this.btnWebCamStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWebCamStart.Name = "btnWebCamStart";
            this.btnWebCamStart.Size = new System.Drawing.Size(322, 103);
            this.btnWebCamStart.TabIndex = 9;
            this.btnWebCamStart.Text = "Get Image From Camera\r\n<ESC> - Exit <CR> - Capture";
            this.btnWebCamStart.UseVisualStyleBackColor = true;
            this.btnWebCamStart.Click += new System.EventHandler(this.btnWebCamStart_Click);
            // 
            // btnIdentifyImage
            // 
            this.btnIdentifyImage.Enabled = false;
            this.btnIdentifyImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIdentifyImage.Location = new System.Drawing.Point(26, 535);
            this.btnIdentifyImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIdentifyImage.Name = "btnIdentifyImage";
            this.btnIdentifyImage.Size = new System.Drawing.Size(322, 103);
            this.btnIdentifyImage.TabIndex = 8;
            this.btnIdentifyImage.Text = "Identify Image";
            this.btnIdentifyImage.UseVisualStyleBackColor = false;
            this.btnIdentifyImage.Click += new System.EventHandler(this.btnIdentifyImage_Click);
            // 
            // btnDeDupStart
            // 
            this.btnDeDupStart.Enabled = false;
            this.btnDeDupStart.Location = new System.Drawing.Point(26, 145);
            this.btnDeDupStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeDupStart.Name = "btnDeDupStart";
            this.btnDeDupStart.Size = new System.Drawing.Size(322, 103);
            this.btnDeDupStart.TabIndex = 4;
            this.btnDeDupStart.Text = "Start DeDuplicaiton";
            this.btnDeDupStart.UseVisualStyleBackColor = true;
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.Location = new System.Drawing.Point(26, 309);
            this.btnImageFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(322, 103);
            this.btnImageFromFile.TabIndex = 3;
            this.btnImageFromFile.Text = "Get Image From File\r\n";
            this.btnImageFromFile.UseVisualStyleBackColor = true;
            this.btnImageFromFile.Click += new System.EventHandler(this.btnImageFromFile_Click);
            // 
            // btnGenTemplatesTomis
            // 
            this.btnGenTemplatesTomis.Enabled = false;
            this.btnGenTemplatesTomis.Location = new System.Drawing.Point(26, 32);
            this.btnGenTemplatesTomis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenTemplatesTomis.Name = "btnGenTemplatesTomis";
            this.btnGenTemplatesTomis.Size = new System.Drawing.Size(322, 103);
            this.btnGenTemplatesTomis.TabIndex = 0;
            this.btnGenTemplatesTomis.Text = "Generate Templates from TOMIS";
            this.btnGenTemplatesTomis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpImgOriginal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpImgModified, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1509, 975);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpImgOriginal
            // 
            this.grpImgOriginal.Controls.Add(this.imgOriginal);
            this.grpImgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgOriginal.Location = new System.Drawing.Point(3, 3);
            this.grpImgOriginal.Name = "grpImgOriginal";
            this.grpImgOriginal.Size = new System.Drawing.Size(748, 969);
            this.grpImgOriginal.TabIndex = 0;
            this.grpImgOriginal.TabStop = false;
            this.grpImgOriginal.Text = "Original Image";
            // 
            // imgOriginal
            // 
            this.imgOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgOriginal.Location = new System.Drawing.Point(3, 22);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(742, 944);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            this.imgOriginal.Click += new System.EventHandler(this.imgOriginal_Click);
            // 
            // grpImgModified
            // 
            this.grpImgModified.Controls.Add(this.imgProcessed);
            this.grpImgModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgModified.Location = new System.Drawing.Point(757, 3);
            this.grpImgModified.Name = "grpImgModified";
            this.grpImgModified.Size = new System.Drawing.Size(749, 969);
            this.grpImgModified.TabIndex = 1;
            this.grpImgModified.TabStop = false;
            this.grpImgModified.Text = "Processed Image";
            // 
            // imgProcessed
            // 
            this.imgProcessed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProcessed.Location = new System.Drawing.Point(3, 22);
            this.imgProcessed.Name = "imgProcessed";
            this.imgProcessed.Size = new System.Drawing.Size(743, 944);
            this.imgProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProcessed.TabIndex = 0;
            this.imgProcessed.TabStop = false;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.grpBoxTomisDbSetup);
            this.tabSetup.Controls.Add(this.grpBoxIPPSetup);
            this.tabSetup.Controls.Add(this.grpBoxTemplateDbSetup);
            this.tabSetup.Location = new System.Drawing.Point(4, 29);
            this.tabSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Size = new System.Drawing.Size(1885, 959);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // grpBoxTomisDbSetup
            // 
            this.grpBoxTomisDbSetup.Controls.Add(this.dbTomisPassword);
            this.grpBoxTomisDbSetup.Controls.Add(this.label4);
            this.grpBoxTomisDbSetup.Controls.Add(this.dbTomisUser);
            this.grpBoxTomisDbSetup.Controls.Add(this.label5);
            this.grpBoxTomisDbSetup.Controls.Add(this.dbTomisSysName);
            this.grpBoxTomisDbSetup.Controls.Add(this.label6);
            this.grpBoxTomisDbSetup.Controls.Add(this.btnConnectToTomis);
            this.grpBoxTomisDbSetup.Location = new System.Drawing.Point(80, 255);
            this.grpBoxTomisDbSetup.Name = "grpBoxTomisDbSetup";
            this.grpBoxTomisDbSetup.Size = new System.Drawing.Size(808, 169);
            this.grpBoxTomisDbSetup.TabIndex = 2;
            this.grpBoxTomisDbSetup.TabStop = false;
            this.grpBoxTomisDbSetup.Text = "TOMIS Db Setup";
            // 
            // dbTomisPassword
            // 
            this.dbTomisPassword.Location = new System.Drawing.Point(428, 75);
            this.dbTomisPassword.Name = "dbTomisPassword";
            this.dbTomisPassword.PasswordChar = '*';
            this.dbTomisPassword.Size = new System.Drawing.Size(312, 26);
            this.dbTomisPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // dbTomisUser
            // 
            this.dbTomisUser.Location = new System.Drawing.Point(138, 75);
            this.dbTomisUser.Name = "dbTomisUser";
            this.dbTomisUser.Size = new System.Drawing.Size(196, 26);
            this.dbTomisUser.TabIndex = 4;
            this.dbTomisUser.Text = "ag039ag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "User:";
            // 
            // dbTomisSysName
            // 
            this.dbTomisSysName.Location = new System.Drawing.Point(138, 28);
            this.dbTomisSysName.Name = "dbTomisSysName";
            this.dbTomisSysName.Size = new System.Drawing.Size(601, 26);
            this.dbTomisSysName.TabIndex = 2;
            this.dbTomisSysName.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "DB Sys Name:";
            // 
            // btnConnectToTomis
            // 
            this.btnConnectToTomis.Location = new System.Drawing.Point(298, 120);
            this.btnConnectToTomis.Name = "btnConnectToTomis";
            this.btnConnectToTomis.Size = new System.Drawing.Size(236, 32);
            this.btnConnectToTomis.TabIndex = 0;
            this.btnConnectToTomis.Text = "Connect to TOMIS db";
            this.btnConnectToTomis.UseVisualStyleBackColor = true;
            // 
            // grpBoxIPPSetup
            // 
            this.grpBoxIPPSetup.Controls.Add(this.textBox1);
            this.grpBoxIPPSetup.Controls.Add(this.label7);
            this.grpBoxIPPSetup.Controls.Add(this.textBox2);
            this.grpBoxIPPSetup.Controls.Add(this.label8);
            this.grpBoxIPPSetup.Controls.Add(this.btnConnectIPP);
            this.grpBoxIPPSetup.Location = new System.Drawing.Point(80, 466);
            this.grpBoxIPPSetup.Name = "grpBoxIPPSetup";
            this.grpBoxIPPSetup.Size = new System.Drawing.Size(808, 169);
            this.grpBoxIPPSetup.TabIndex = 1;
            this.grpBoxIPPSetup.TabStop = false;
            this.grpBoxIPPSetup.Text = "IPP Endpoint Setup";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "12345";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PORT:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "localhost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "IPP URI:";
            // 
            // btnConnectIPP
            // 
            this.btnConnectIPP.Location = new System.Drawing.Point(298, 106);
            this.btnConnectIPP.Name = "btnConnectIPP";
            this.btnConnectIPP.Size = new System.Drawing.Size(236, 32);
            this.btnConnectIPP.TabIndex = 1;
            this.btnConnectIPP.Text = "Connect to IPP";
            this.btnConnectIPP.UseVisualStyleBackColor = true;
            // 
            // grpBoxTemplateDbSetup
            // 
            this.grpBoxTemplateDbSetup.Controls.Add(this.dbSigPassword);
            this.grpBoxTemplateDbSetup.Controls.Add(this.label3);
            this.grpBoxTemplateDbSetup.Controls.Add(this.dbSigUser);
            this.grpBoxTemplateDbSetup.Controls.Add(this.label2);
            this.grpBoxTemplateDbSetup.Controls.Add(this.dbSigUri);
            this.grpBoxTemplateDbSetup.Controls.Add(this.label1);
            this.grpBoxTemplateDbSetup.Controls.Add(this.btnConnectTemplateDb);
            this.grpBoxTemplateDbSetup.Location = new System.Drawing.Point(80, 52);
            this.grpBoxTemplateDbSetup.Name = "grpBoxTemplateDbSetup";
            this.grpBoxTemplateDbSetup.Size = new System.Drawing.Size(808, 169);
            this.grpBoxTemplateDbSetup.TabIndex = 0;
            this.grpBoxTemplateDbSetup.TabStop = false;
            this.grpBoxTemplateDbSetup.Text = "Template Db Setup";
            // 
            // dbSigPassword
            // 
            this.dbSigPassword.Location = new System.Drawing.Point(428, 75);
            this.dbSigPassword.Name = "dbSigPassword";
            this.dbSigPassword.PasswordChar = '*';
            this.dbSigPassword.Size = new System.Drawing.Size(312, 26);
            this.dbSigPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // dbSigUser
            // 
            this.dbSigUser.Location = new System.Drawing.Point(138, 75);
            this.dbSigUser.Name = "dbSigUser";
            this.dbSigUser.Size = new System.Drawing.Size(196, 26);
            this.dbSigUser.TabIndex = 4;
            this.dbSigUser.Text = "ag039ag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User:";
            // 
            // dbSigUri
            // 
            this.dbSigUri.Location = new System.Drawing.Point(138, 28);
            this.dbSigUri.Name = "dbSigUri";
            this.dbSigUri.Size = new System.Drawing.Size(601, 26);
            this.dbSigUri.TabIndex = 2;
            this.dbSigUri.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB Sys Name:";
            // 
            // btnConnectTemplateDb
            // 
            this.btnConnectTemplateDb.Location = new System.Drawing.Point(298, 120);
            this.btnConnectTemplateDb.Name = "btnConnectTemplateDb";
            this.btnConnectTemplateDb.Size = new System.Drawing.Size(236, 32);
            this.btnConnectTemplateDb.TabIndex = 0;
            this.btnConnectTemplateDb.Text = "Connect to Template DB";
            this.btnConnectTemplateDb.UseVisualStyleBackColor = true;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dataGridView1);
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Size = new System.Drawing.Size(1885, 959);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "DeDupe Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1877, 949);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MDM GUID";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TOMIS ID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Matching Image";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Match Confidence";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Combine";
            this.Column4.Name = "Column4";
            // 
            // ippEndPtStatLbl
            // 
            this.ippEndPtStatLbl.Name = "ippEndPtStatLbl";
            this.ippEndPtStatLbl.Size = new System.Drawing.Size(118, 25);
            this.ippEndPtStatLbl.Text = "IPP Endpoint:";
            // 
            // statusFlagIPP
            // 
            this.statusFlagIPP.Name = "statusFlagIPP";
            this.statusFlagIPP.Size = new System.Drawing.Size(142, 25);
            this.statusFlagIPP.Text = "DISCONNECTED";
            // 
            // statusFlagTomisDbLbl
            // 
            this.statusFlagTomisDbLbl.Name = "statusFlagTomisDbLbl";
            this.statusFlagTomisDbLbl.Size = new System.Drawing.Size(96, 25);
            this.statusFlagTomisDbLbl.Text = "TOMIS db:";
            // 
            // statusFlagTomisDb
            // 
            this.statusFlagTomisDb.Name = "statusFlagTomisDb";
            this.statusFlagTomisDb.Size = new System.Drawing.Size(142, 25);
            this.statusFlagTomisDb.Text = "DISCONNECTED";
            // 
            // statusFlagTemplateDbLbl
            // 
            this.statusFlagTemplateDbLbl.Name = "statusFlagTemplateDbLbl";
            this.statusFlagTemplateDbLbl.Size = new System.Drawing.Size(115, 25);
            this.statusFlagTemplateDbLbl.Text = "Template DB:";
            // 
            // statusFlagTemplateDb
            // 
            this.statusFlagTemplateDb.Name = "statusFlagTemplateDb";
            this.statusFlagTemplateDb.Size = new System.Drawing.Size(142, 25);
            this.statusFlagTemplateDb.Text = "DISCONNECTED";
            // 
            // statusBarMain
            // 
            this.statusBarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ippEndPtStatLbl,
            this.statusFlagIPP,
            this.statusFlagTomisDbLbl,
            this.statusFlagTomisDb,
            this.statusFlagTemplateDbLbl,
            this.statusFlagTemplateDb});
            this.statusBarMain.Location = new System.Drawing.Point(0, 992);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusBarMain.Size = new System.Drawing.Size(1893, 30);
            this.statusBarMain.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(26, 706);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(322, 103);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1893, 1022);
            this.Controls.Add(this.tabDeDupMain);
            this.Controls.Add(this.statusBarMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1903, 1030);
            this.Name = "Main";
            this.Text = "deDupe Tomis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDeDupMain.ResumeLayout(false);
            this.tabFacialRecognition.ResumeLayout(false);
            this.splitContainerMainFr.Panel1.ResumeLayout(false);
            this.splitContainerMainFr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainFr)).EndInit();
            this.splitContainerMainFr.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpImgOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            this.grpImgModified.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProcessed)).EndInit();
            this.tabSetup.ResumeLayout(false);
            this.grpBoxTomisDbSetup.ResumeLayout(false);
            this.grpBoxTomisDbSetup.PerformLayout();
            this.grpBoxIPPSetup.ResumeLayout(false);
            this.grpBoxIPPSetup.PerformLayout();
            this.grpBoxTemplateDbSetup.ResumeLayout(false);
            this.grpBoxTemplateDbSetup.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusBarMain.ResumeLayout(false);
            this.statusBarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabDeDupMain;
        private System.Windows.Forms.TabPage tabFacialRecognition;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.GroupBox grpBoxTomisDbSetup;
        private System.Windows.Forms.TextBox dbTomisPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbTomisUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbTomisSysName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnectToTomis;
        private System.Windows.Forms.GroupBox grpBoxIPPSetup;
        private System.Windows.Forms.Button btnConnectIPP;
        private System.Windows.Forms.GroupBox grpBoxTemplateDbSetup;
        private System.Windows.Forms.TextBox dbSigPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbSigUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbSigUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectTemplateDb;
        private System.Windows.Forms.SplitContainer splitContainerMainFr;
        private System.Windows.Forms.Button btnIdentifyImage;
        private System.Windows.Forms.Button btnDeDupStart;
        private System.Windows.Forms.Button btnImageFromFile;
        private System.Windows.Forms.Button btnGenTemplatesTomis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpImgOriginal;
        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.GroupBox grpImgModified;
        private System.Windows.Forms.PictureBox imgProcessed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnWebCamStart;
        private System.Windows.Forms.ToolStripStatusLabel ippEndPtStatLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagIPP;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagTomisDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagTomisDb;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagTemplateDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagTemplateDb;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.Button btnExit;
    }
}

