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
            this.btnExit = new System.Windows.Forms.Button();
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
            this.dbSigUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnConnectTemplateDb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusFlagUserLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFlagUser = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeDupMain
            // 
            this.tabDeDupMain.Controls.Add(this.tabFacialRecognition);
            this.tabDeDupMain.Controls.Add(this.tabSetup);
            this.tabDeDupMain.Controls.Add(this.tabResults);
            this.tabDeDupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeDupMain.Location = new System.Drawing.Point(0, 0);
            this.tabDeDupMain.Name = "tabDeDupMain";
            this.tabDeDupMain.SelectedIndex = 0;
            this.tabDeDupMain.Size = new System.Drawing.Size(1008, 515);
            this.tabDeDupMain.TabIndex = 1;
            // 
            // tabFacialRecognition
            // 
            this.tabFacialRecognition.Controls.Add(this.splitContainerMainFr);
            this.tabFacialRecognition.Location = new System.Drawing.Point(4, 22);
            this.tabFacialRecognition.Name = "tabFacialRecognition";
            this.tabFacialRecognition.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacialRecognition.Size = new System.Drawing.Size(1000, 489);
            this.tabFacialRecognition.TabIndex = 0;
            this.tabFacialRecognition.Text = "Facial Recognition";
            this.tabFacialRecognition.UseVisualStyleBackColor = true;
            // 
            // splitContainerMainFr
            // 
            this.splitContainerMainFr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainFr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMainFr.Location = new System.Drawing.Point(3, 3);
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
            this.splitContainerMainFr.Panel1MinSize = 220;
            // 
            // splitContainerMainFr.Panel2
            // 
            this.splitContainerMainFr.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMainFr.Panel2MinSize = 200;
            this.splitContainerMainFr.Size = new System.Drawing.Size(994, 483);
            this.splitContainerMainFr.SplitterDistance = 220;
            this.splitContainerMainFr.SplitterWidth = 1;
            this.splitContainerMainFr.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(10, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWebCamStart
            // 
            this.btnWebCamStart.Location = new System.Drawing.Point(10, 189);
            this.btnWebCamStart.Name = "btnWebCamStart";
            this.btnWebCamStart.Size = new System.Drawing.Size(200, 45);
            this.btnWebCamStart.TabIndex = 9;
            this.btnWebCamStart.Text = "Get Image From Camera\r\n<ESC> - Exit <CR> - Capture";
            this.btnWebCamStart.UseVisualStyleBackColor = true;
            this.btnWebCamStart.Click += new System.EventHandler(this.btnWebCamStart_Click);
            // 
            // btnIdentifyImage
            // 
            this.btnIdentifyImage.Enabled = false;
            this.btnIdentifyImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIdentifyImage.Location = new System.Drawing.Point(10, 240);
            this.btnIdentifyImage.Name = "btnIdentifyImage";
            this.btnIdentifyImage.Size = new System.Drawing.Size(200, 45);
            this.btnIdentifyImage.TabIndex = 8;
            this.btnIdentifyImage.Text = "Identify Image";
            this.btnIdentifyImage.UseVisualStyleBackColor = false;
            this.btnIdentifyImage.Click += new System.EventHandler(this.btnIdentifyImage_Click);
            // 
            // btnDeDupStart
            // 
            this.btnDeDupStart.Enabled = false;
            this.btnDeDupStart.Location = new System.Drawing.Point(10, 68);
            this.btnDeDupStart.Name = "btnDeDupStart";
            this.btnDeDupStart.Size = new System.Drawing.Size(200, 45);
            this.btnDeDupStart.TabIndex = 4;
            this.btnDeDupStart.Text = "Start DeDuplicaiton";
            this.btnDeDupStart.UseVisualStyleBackColor = true;
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.Location = new System.Drawing.Point(10, 138);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(200, 45);
            this.btnImageFromFile.TabIndex = 3;
            this.btnImageFromFile.Text = "Get Image From File\r\n";
            this.btnImageFromFile.UseVisualStyleBackColor = true;
            this.btnImageFromFile.Click += new System.EventHandler(this.btnImageFromFile_Click);
            // 
            // btnGenTemplatesTomis
            // 
            this.btnGenTemplatesTomis.Enabled = false;
            this.btnGenTemplatesTomis.Location = new System.Drawing.Point(10, 17);
            this.btnGenTemplatesTomis.Name = "btnGenTemplatesTomis";
            this.btnGenTemplatesTomis.Size = new System.Drawing.Size(200, 45);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpImgOriginal
            // 
            this.grpImgOriginal.Controls.Add(this.imgOriginal);
            this.grpImgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgOriginal.Location = new System.Drawing.Point(2, 2);
            this.grpImgOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.grpImgOriginal.Name = "grpImgOriginal";
            this.grpImgOriginal.Padding = new System.Windows.Forms.Padding(2);
            this.grpImgOriginal.Size = new System.Drawing.Size(382, 479);
            this.grpImgOriginal.TabIndex = 0;
            this.grpImgOriginal.TabStop = false;
            this.grpImgOriginal.Text = "Original Image";
            // 
            // imgOriginal
            // 
            this.imgOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgOriginal.Location = new System.Drawing.Point(2, 15);
            this.imgOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(378, 462);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            this.imgOriginal.Click += new System.EventHandler(this.imgOriginal_Click);
            // 
            // grpImgModified
            // 
            this.grpImgModified.Controls.Add(this.imgProcessed);
            this.grpImgModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgModified.Location = new System.Drawing.Point(388, 2);
            this.grpImgModified.Margin = new System.Windows.Forms.Padding(2);
            this.grpImgModified.Name = "grpImgModified";
            this.grpImgModified.Padding = new System.Windows.Forms.Padding(2);
            this.grpImgModified.Size = new System.Drawing.Size(383, 479);
            this.grpImgModified.TabIndex = 1;
            this.grpImgModified.TabStop = false;
            this.grpImgModified.Text = "Processed Image";
            // 
            // imgProcessed
            // 
            this.imgProcessed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProcessed.Location = new System.Drawing.Point(2, 15);
            this.imgProcessed.Margin = new System.Windows.Forms.Padding(2);
            this.imgProcessed.Name = "imgProcessed";
            this.imgProcessed.Size = new System.Drawing.Size(379, 462);
            this.imgProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProcessed.TabIndex = 0;
            this.imgProcessed.TabStop = false;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Controls.Add(this.grpBoxTomisDbSetup);
            this.tabSetup.Controls.Add(this.grpBoxIPPSetup);
            this.tabSetup.Controls.Add(this.grpBoxTemplateDbSetup);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(1254, 616);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // grpBoxTomisDbSetup
            // 
            this.grpBoxTomisDbSetup.Controls.Add(this.dbTomisSysName);
            this.grpBoxTomisDbSetup.Controls.Add(this.label6);
            this.grpBoxTomisDbSetup.Controls.Add(this.btnConnectToTomis);
            this.grpBoxTomisDbSetup.Location = new System.Drawing.Point(7, 161);
            this.grpBoxTomisDbSetup.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxTomisDbSetup.Name = "grpBoxTomisDbSetup";
            this.grpBoxTomisDbSetup.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxTomisDbSetup.Size = new System.Drawing.Size(539, 74);
            this.grpBoxTomisDbSetup.TabIndex = 2;
            this.grpBoxTomisDbSetup.TabStop = false;
            this.grpBoxTomisDbSetup.Text = "TOMIS Db Setup";
            // 
            // dbTomisSysName
            // 
            this.dbTomisSysName.Location = new System.Drawing.Point(92, 18);
            this.dbTomisSysName.Margin = new System.Windows.Forms.Padding(2);
            this.dbTomisSysName.Name = "dbTomisSysName";
            this.dbTomisSysName.Size = new System.Drawing.Size(402, 20);
            this.dbTomisSysName.TabIndex = 2;
            this.dbTomisSysName.Text = "10.10.170.20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DB Sys Name:";
            // 
            // btnConnectToTomis
            // 
            this.btnConnectToTomis.Location = new System.Drawing.Point(199, 42);
            this.btnConnectToTomis.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectToTomis.Name = "btnConnectToTomis";
            this.btnConnectToTomis.Size = new System.Drawing.Size(157, 21);
            this.btnConnectToTomis.TabIndex = 0;
            this.btnConnectToTomis.Text = "Connect to TOMIS db";
            this.btnConnectToTomis.UseVisualStyleBackColor = true;
            this.btnConnectToTomis.Click += new System.EventHandler(this.btnConnectToTomis_Click);
            // 
            // grpBoxIPPSetup
            // 
            this.grpBoxIPPSetup.Controls.Add(this.textBox1);
            this.grpBoxIPPSetup.Controls.Add(this.label7);
            this.grpBoxIPPSetup.Controls.Add(this.textBox2);
            this.grpBoxIPPSetup.Controls.Add(this.label8);
            this.grpBoxIPPSetup.Controls.Add(this.btnConnectIPP);
            this.grpBoxIPPSetup.Location = new System.Drawing.Point(7, 239);
            this.grpBoxIPPSetup.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxIPPSetup.Name = "grpBoxIPPSetup";
            this.grpBoxIPPSetup.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxIPPSetup.Size = new System.Drawing.Size(539, 74);
            this.grpBoxIPPSetup.TabIndex = 1;
            this.grpBoxIPPSetup.TabStop = false;
            this.grpBoxIPPSetup.Text = "IPP Endpoint Setup";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "12345";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "PORT:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 17);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "localhost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "IPP URI:";
            // 
            // btnConnectIPP
            // 
            this.btnConnectIPP.Location = new System.Drawing.Point(199, 41);
            this.btnConnectIPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectIPP.Name = "btnConnectIPP";
            this.btnConnectIPP.Size = new System.Drawing.Size(157, 21);
            this.btnConnectIPP.TabIndex = 1;
            this.btnConnectIPP.Text = "Connect to IPP";
            this.btnConnectIPP.UseVisualStyleBackColor = true;
            // 
            // grpBoxTemplateDbSetup
            // 
            this.grpBoxTemplateDbSetup.Controls.Add(this.dbSigUri);
            this.grpBoxTemplateDbSetup.Controls.Add(this.label1);
            this.grpBoxTemplateDbSetup.Controls.Add(this.btnConnectTemplateDb);
            this.grpBoxTemplateDbSetup.Location = new System.Drawing.Point(7, 83);
            this.grpBoxTemplateDbSetup.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxTemplateDbSetup.Name = "grpBoxTemplateDbSetup";
            this.grpBoxTemplateDbSetup.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxTemplateDbSetup.Size = new System.Drawing.Size(539, 74);
            this.grpBoxTemplateDbSetup.TabIndex = 0;
            this.grpBoxTemplateDbSetup.TabStop = false;
            this.grpBoxTemplateDbSetup.Text = "Template Db Setup";
            // 
            // dbSigUri
            // 
            this.dbSigUri.Location = new System.Drawing.Point(92, 18);
            this.dbSigUri.Margin = new System.Windows.Forms.Padding(2);
            this.dbSigUri.Name = "dbSigUri";
            this.dbSigUri.Size = new System.Drawing.Size(402, 20);
            this.dbSigUri.TabIndex = 2;
            this.dbSigUri.Text = "AG03NDCWB00053";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB Sys Name:";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dataGridView1);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1254, 616);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1248, 610);
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
            this.ippEndPtStatLbl.Size = new System.Drawing.Size(78, 17);
            this.ippEndPtStatLbl.Text = "IPP Endpoint:";
            // 
            // statusFlagIPP
            // 
            this.statusFlagIPP.Name = "statusFlagIPP";
            this.statusFlagIPP.Size = new System.Drawing.Size(94, 17);
            this.statusFlagIPP.Text = "DISCONNECTED";
            // 
            // statusFlagTomisDbLbl
            // 
            this.statusFlagTomisDbLbl.Name = "statusFlagTomisDbLbl";
            this.statusFlagTomisDbLbl.Size = new System.Drawing.Size(62, 17);
            this.statusFlagTomisDbLbl.Text = "TOMIS db:";
            // 
            // statusFlagTomisDb
            // 
            this.statusFlagTomisDb.Name = "statusFlagTomisDb";
            this.statusFlagTomisDb.Size = new System.Drawing.Size(94, 17);
            this.statusFlagTomisDb.Text = "DISCONNECTED";
            // 
            // statusFlagTemplateDbLbl
            // 
            this.statusFlagTemplateDbLbl.Name = "statusFlagTemplateDbLbl";
            this.statusFlagTemplateDbLbl.Size = new System.Drawing.Size(77, 17);
            this.statusFlagTemplateDbLbl.Text = "Template DB:";
            // 
            // statusFlagTemplateDb
            // 
            this.statusFlagTemplateDb.Name = "statusFlagTemplateDb";
            this.statusFlagTemplateDb.Size = new System.Drawing.Size(94, 17);
            this.statusFlagTemplateDb.Text = "DISCONNECTED";
            // 
            // statusBarMain
            // 
            this.statusBarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFlagUserLbl,
            this.statusFlagUser,
            this.ippEndPtStatLbl,
            this.statusFlagIPP,
            this.statusFlagTomisDbLbl,
            this.statusFlagTomisDb,
            this.statusFlagTemplateDbLbl,
            this.statusFlagTemplateDb});
            this.statusBarMain.Location = new System.Drawing.Point(0, 515);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(1008, 22);
            this.statusBarMain.TabIndex = 0;
            // 
            // btnConnectTemplateDb
            // 
            this.btnConnectTemplateDb.Location = new System.Drawing.Point(199, 42);
            this.btnConnectTemplateDb.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectTemplateDb.Name = "btnConnectTemplateDb";
            this.btnConnectTemplateDb.Size = new System.Drawing.Size(157, 21);
            this.btnConnectTemplateDb.TabIndex = 0;
            this.btnConnectTemplateDb.Text = "Connect to Template DB";
            this.btnConnectTemplateDb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(539, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template Db Setup";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(63, 17);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(105, 20);
            this.txtUserId.TabIndex = 2;
            this.txtUserId.Text = "AG039AG_SA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(241, 18);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(105, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(417, 18);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(105, 20);
            this.txtDomain.TabIndex = 6;
            this.txtDomain.Text = "NET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Domain:";
            // 
            // statusFlagUserLbl
            // 
            this.statusFlagUserLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.statusFlagUserLbl.Name = "statusFlagUserLbl";
            this.statusFlagUserLbl.Size = new System.Drawing.Size(44, 17);
            this.statusFlagUserLbl.Text = "UserID:";
            // 
            // statusFlagUser
            // 
            this.statusFlagUser.Name = "statusFlagUser";
            this.statusFlagUser.Size = new System.Drawing.Size(79, 17);
            this.statusFlagUser.Text = "LOGGED OUT";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabDeDupMain);
            this.Controls.Add(this.statusBarMain);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabDeDupMain;
        private System.Windows.Forms.TabPage tabFacialRecognition;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.GroupBox grpBoxTomisDbSetup;
        private System.Windows.Forms.TextBox dbTomisSysName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConnectToTomis;
        private System.Windows.Forms.GroupBox grpBoxIPPSetup;
        private System.Windows.Forms.Button btnConnectIPP;
        private System.Windows.Forms.GroupBox grpBoxTemplateDbSetup;
        private System.Windows.Forms.TextBox dbSigUri;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConnectTemplateDb;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagUserLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusFlagUser;
    }
}

