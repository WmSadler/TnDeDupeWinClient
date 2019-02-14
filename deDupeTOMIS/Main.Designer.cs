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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnWebCamStart = new System.Windows.Forms.Button();
            this.BtnIdentifyImage = new System.Windows.Forms.Button();
            this.BtnDeDupStart = new System.Windows.Forms.Button();
            this.BtnImageFromFile = new System.Windows.Forms.Button();
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
            this.StatusFlagTomisDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFlagTomisDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFlagTemplateDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFlagTemplateDb = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.StatusFlagAESDbLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusFlagAESDb = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnExit);
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnWebCamStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnIdentifyImage);
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnDeDupStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.BtnImageFromFile);
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
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExit.Location = new System.Drawing.Point(10, 429);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 45);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnWebCamStart
            // 
            this.BtnWebCamStart.Location = new System.Drawing.Point(10, 127);
            this.BtnWebCamStart.Name = "BtnWebCamStart";
            this.BtnWebCamStart.Size = new System.Drawing.Size(200, 45);
            this.BtnWebCamStart.TabIndex = 9;
            this.BtnWebCamStart.Text = "Get Image From Camera\r\n<ESC> - Exit <CR> - Capture";
            this.BtnWebCamStart.UseVisualStyleBackColor = true;
            this.BtnWebCamStart.Click += new System.EventHandler(this.BtnWebCamStart_Click);
            // 
            // BtnIdentifyImage
            // 
            this.BtnIdentifyImage.Enabled = false;
            this.BtnIdentifyImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnIdentifyImage.Location = new System.Drawing.Point(10, 178);
            this.BtnIdentifyImage.Name = "BtnIdentifyImage";
            this.BtnIdentifyImage.Size = new System.Drawing.Size(200, 45);
            this.BtnIdentifyImage.TabIndex = 8;
            this.BtnIdentifyImage.Text = "Identify Image";
            this.BtnIdentifyImage.UseVisualStyleBackColor = false;
            this.BtnIdentifyImage.Click += new System.EventHandler(this.BtnIdentifyImage_Click);
            // 
            // BtnDeDupStart
            // 
            this.BtnDeDupStart.Enabled = false;
            this.BtnDeDupStart.Location = new System.Drawing.Point(10, 3);
            this.BtnDeDupStart.Name = "BtnDeDupStart";
            this.BtnDeDupStart.Size = new System.Drawing.Size(200, 45);
            this.BtnDeDupStart.TabIndex = 4;
            this.BtnDeDupStart.Text = "Start DeDuplicaiton";
            this.BtnDeDupStart.UseVisualStyleBackColor = true;
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(10, 76);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(200, 45);
            this.BtnImageFromFile.TabIndex = 3;
            this.BtnImageFromFile.Text = "Get Image From File\r\n";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
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
            this.imgOriginal.Click += new System.EventHandler(this.ImgOriginal_Click);
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
            // StatusFlagTomisDbLbl
            // 
            this.StatusFlagTomisDbLbl.Name = "StatusFlagTomisDbLbl";
            this.StatusFlagTomisDbLbl.Size = new System.Drawing.Size(62, 17);
            this.StatusFlagTomisDbLbl.Text = "TOMIS db:";
            // 
            // StatusFlagTomisDb
            // 
            this.StatusFlagTomisDb.Name = "StatusFlagTomisDb";
            this.StatusFlagTomisDb.Size = new System.Drawing.Size(94, 17);
            this.StatusFlagTomisDb.Text = "DISCONNECTED";
            this.StatusFlagTomisDb.Click += new System.EventHandler(this.StatusFlagTomisDb_Click);
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
            this.StatusFlagTemplateDb.Size = new System.Drawing.Size(94, 17);
            this.StatusFlagTemplateDb.Text = "DISCONNECTED";
            this.StatusFlagTemplateDb.Click += new System.EventHandler(this.StatusFlagTemplateDb_Click);
            // 
            // statusBarMain
            // 
            this.statusBarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusFlagTomisDbLbl,
            this.StatusFlagTomisDb,
            this.StatusFlagAESDbLbl,
            this.StatusFlagAESDb,
            this.StatusFlagTemplateDbLbl,
            this.StatusFlagTemplateDb});
            this.statusBarMain.Location = new System.Drawing.Point(0, 515);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(1008, 22);
            this.statusBarMain.TabIndex = 0;
            // 
            // StatusFlagAESDbLbl
            // 
            this.StatusFlagAESDbLbl.Name = "StatusFlagAESDbLbl";
            this.StatusFlagAESDbLbl.Size = new System.Drawing.Size(47, 17);
            this.StatusFlagAESDbLbl.Text = "AES db:";
            // 
            // StatusFlagAESDb
            // 
            this.StatusFlagAESDb.Name = "StatusFlagAESDb";
            this.StatusFlagAESDb.Size = new System.Drawing.Size(94, 17);
            this.StatusFlagAESDb.Text = "DISCONNECTED";
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
        private System.Windows.Forms.Button BtnIdentifyImage;
        private System.Windows.Forms.Button BtnDeDupStart;
        private System.Windows.Forms.Button BtnImageFromFile;
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
        private System.Windows.Forms.Button BtnWebCamStart;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTomisDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTomisDb;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTemplateDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagTemplateDb;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagAESDbLbl;
        private System.Windows.Forms.ToolStripStatusLabel StatusFlagAESDb;
    }
}

