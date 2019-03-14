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
            this.btnDedupDb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindImage = new System.Windows.Forms.Button();
            this.timeElapsedDisplay = new System.Windows.Forms.TextBox();
            this.timeStartDisplay = new System.Windows.Forms.TextBox();
            this.timeEndDisplay = new System.Windows.Forms.TextBox();
            this.tomisID = new System.Windows.Forms.TextBox();
            this.btnTrainTemplates = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnWebCamStart = new System.Windows.Forms.Button();
            this.btnImageFromFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpImgOriginal = new System.Windows.Forms.GroupBox();
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.grpImgModified = new System.Windows.Forms.GroupBox();
            this.imgProcessed = new System.Windows.Forms.PictureBox();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.grpBoxIPPSetup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnectIPP = new System.Windows.Forms.Button();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.deDupeResultsMatrix = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusFlagTemplateDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFlagTemplateDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.textRecogProg = new System.Windows.Forms.ToolStripStatusLabel();
            this.findImageProgressBar = new System.Windows.Forms.ToolStripProgressBar();
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
            this.grpBoxIPPSetup.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDupeResultsMatrix)).BeginInit();
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
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnDedupDb);
            this.splitContainerMainFr.Panel1.Controls.Add(this.label4);
            this.splitContainerMainFr.Panel1.Controls.Add(this.label3);
            this.splitContainerMainFr.Panel1.Controls.Add(this.label2);
            this.splitContainerMainFr.Panel1.Controls.Add(this.label1);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnFindImage);
            this.splitContainerMainFr.Panel1.Controls.Add(this.timeElapsedDisplay);
            this.splitContainerMainFr.Panel1.Controls.Add(this.timeStartDisplay);
            this.splitContainerMainFr.Panel1.Controls.Add(this.timeEndDisplay);
            this.splitContainerMainFr.Panel1.Controls.Add(this.tomisID);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnTrainTemplates);
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnExit);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnWebCamStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnImageFromFile);
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
            // btnDedupDb
            // 
            this.btnDedupDb.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDedupDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDedupDb.Location = new System.Drawing.Point(10, 138);
            this.btnDedupDb.Name = "btnDedupDb";
            this.btnDedupDb.Size = new System.Drawing.Size(200, 25);
            this.btnDedupDb.TabIndex = 17;
            this.btnDedupDb.Text = "De-Duplicate";
            this.btnDedupDb.UseVisualStyleBackColor = false;
            this.btnDedupDb.Click += new System.EventHandler(this.BtnDedupDb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "TOMIS ID";
            // 
            // btnFindImage
            // 
            this.btnFindImage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFindImage.Location = new System.Drawing.Point(11, 423);
            this.btnFindImage.Name = "btnFindImage";
            this.btnFindImage.Size = new System.Drawing.Size(200, 25);
            this.btnFindImage.TabIndex = 16;
            this.btnFindImage.Text = "Find Image";
            this.btnFindImage.UseVisualStyleBackColor = false;
            this.btnFindImage.Click += new System.EventHandler(this.BtnFindImage_Click);
            // 
            // timeElapsedDisplay
            // 
            this.timeElapsedDisplay.Location = new System.Drawing.Point(69, 112);
            this.timeElapsedDisplay.Name = "timeElapsedDisplay";
            this.timeElapsedDisplay.Size = new System.Drawing.Size(141, 20);
            this.timeElapsedDisplay.TabIndex = 15;
            this.timeElapsedDisplay.Text = "00:00:00:00";
            this.timeElapsedDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeStartDisplay
            // 
            this.timeStartDisplay.Location = new System.Drawing.Point(69, 60);
            this.timeStartDisplay.Name = "timeStartDisplay";
            this.timeStartDisplay.Size = new System.Drawing.Size(141, 20);
            this.timeStartDisplay.TabIndex = 14;
            this.timeStartDisplay.Text = "00:00:00";
            this.timeStartDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeEndDisplay
            // 
            this.timeEndDisplay.Location = new System.Drawing.Point(69, 86);
            this.timeEndDisplay.Name = "timeEndDisplay";
            this.timeEndDisplay.Size = new System.Drawing.Size(141, 20);
            this.timeEndDisplay.TabIndex = 13;
            this.timeEndDisplay.Text = "00:00:00";
            this.timeEndDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tomisID
            // 
            this.tomisID.Location = new System.Drawing.Point(69, 34);
            this.tomisID.Name = "tomisID";
            this.tomisID.Size = new System.Drawing.Size(141, 20);
            this.tomisID.TabIndex = 12;
            this.tomisID.Text = "NA";
            this.tomisID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTrainTemplates
            // 
            this.btnTrainTemplates.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTrainTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainTemplates.Location = new System.Drawing.Point(10, 3);
            this.btnTrainTemplates.Name = "btnTrainTemplates";
            this.btnTrainTemplates.Size = new System.Drawing.Size(200, 25);
            this.btnTrainTemplates.TabIndex = 11;
            this.btnTrainTemplates.Text = "Train Templates";
            this.btnTrainTemplates.UseVisualStyleBackColor = false;
            this.btnTrainTemplates.Click += new System.EventHandler(this.BtnTrainTemplates_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExit.Location = new System.Drawing.Point(10, 454);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 25);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnWebCamStart
            // 
            this.btnWebCamStart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWebCamStart.Location = new System.Drawing.Point(11, 336);
            this.btnWebCamStart.Name = "btnWebCamStart";
            this.btnWebCamStart.Size = new System.Drawing.Size(200, 25);
            this.btnWebCamStart.TabIndex = 9;
            this.btnWebCamStart.Text = "Get Image From Camera\r\n\r\n";
            this.btnWebCamStart.UseVisualStyleBackColor = false;
            this.btnWebCamStart.Click += new System.EventHandler(this.BtnWebCamStart_Click);
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImageFromFile.Location = new System.Drawing.Point(10, 305);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(200, 25);
            this.btnImageFromFile.TabIndex = 3;
            this.btnImageFromFile.Text = "Get Image From File\r\n";
            this.btnImageFromFile.UseVisualStyleBackColor = false;
            this.btnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
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
            this.grpImgOriginal.Text = "Source Image";
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
            this.grpImgModified.Text = "Checking Against";
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
            this.tabSetup.Controls.Add(this.grpBoxIPPSetup);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(1000, 489);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // grpBoxIPPSetup
            // 
            this.grpBoxIPPSetup.Controls.Add(this.textBox1);
            this.grpBoxIPPSetup.Controls.Add(this.label7);
            this.grpBoxIPPSetup.Controls.Add(this.textBox2);
            this.grpBoxIPPSetup.Controls.Add(this.label8);
            this.grpBoxIPPSetup.Controls.Add(this.btnConnectIPP);
            this.grpBoxIPPSetup.Location = new System.Drawing.Point(7, 5);
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
            // tabResults
            // 
            this.tabResults.Controls.Add(this.deDupeResultsMatrix);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1000, 489);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "DeDupe Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // deDupeResultsMatrix
            // 
            this.deDupeResultsMatrix.AllowUserToAddRows = false;
            this.deDupeResultsMatrix.AllowUserToDeleteRows = false;
            this.deDupeResultsMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deDupeResultsMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column4});
            this.deDupeResultsMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deDupeResultsMatrix.Location = new System.Drawing.Point(3, 3);
            this.deDupeResultsMatrix.Name = "deDupeResultsMatrix";
            this.deDupeResultsMatrix.ReadOnly = true;
            this.deDupeResultsMatrix.Size = new System.Drawing.Size(994, 483);
            this.deDupeResultsMatrix.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MDM GUID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TOMIS ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Matching Image";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Match Confidence";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Combine";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // StatusFlagTemplateDbLbl
            // 
            this.StatusFlagTemplateDbLbl.Name = "StatusFlagTemplateDbLbl";
            this.StatusFlagTemplateDbLbl.Size = new System.Drawing.Size(77, 17);
            this.StatusFlagTemplateDbLbl.Text = "Template DB:";
            // 
            // StatusFlagTemplateDb
            // 
            this.StatusFlagTemplateDb.Name = "StatusFlagTemplateDb";
            this.StatusFlagTemplateDb.Size = new System.Drawing.Size(72, 17);
            this.StatusFlagTemplateDb.Text = "UNTRAINED";
            // 
            // statusBarMain
            // 
            this.statusBarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusFlagTemplateDbLbl,
            this.StatusFlagTemplateDb,
            this.textRecogProg,
            this.findImageProgressBar});
            this.statusBarMain.Location = new System.Drawing.Point(0, 515);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(1008, 22);
            this.statusBarMain.TabIndex = 0;
            // 
            // textRecogProg
            // 
            this.textRecogProg.Name = "textRecogProg";
            this.textRecogProg.Size = new System.Drawing.Size(125, 17);
            this.textRecogProg.Text = "Recognition Progress :";
            // 
            // findImageProgressBar
            // 
            this.findImageProgressBar.Name = "findImageProgressBar";
            this.findImageProgressBar.Size = new System.Drawing.Size(100, 16);
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
            this.splitContainerMainFr.Panel1.PerformLayout();
            this.splitContainerMainFr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainFr)).EndInit();
            this.splitContainerMainFr.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpImgOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            this.grpImgModified.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProcessed)).EndInit();
            this.tabSetup.ResumeLayout(false);
            this.grpBoxIPPSetup.ResumeLayout(false);
            this.grpBoxIPPSetup.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDupeResultsMatrix)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBoxIPPSetup;
        private System.Windows.Forms.Button btnConnectIPP;
        private System.Windows.Forms.SplitContainer splitContainerMainFr;
        private System.Windows.Forms.Button btnImageFromFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpImgOriginal;
        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.GroupBox grpImgModified;
        private System.Windows.Forms.PictureBox imgProcessed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView deDupeResultsMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnWebCamStart;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTemplateDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTemplateDb;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnTrainTemplates;
        private System.Windows.Forms.TextBox tomisID;
        private System.Windows.Forms.TextBox timeStartDisplay;
        private System.Windows.Forms.TextBox timeEndDisplay;
        private System.Windows.Forms.TextBox timeElapsedDisplay;
        private System.Windows.Forms.Button btnFindImage;
        private System.Windows.Forms.Button btnDedupDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripProgressBar findImageProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel textRecogProg;
    }
}

