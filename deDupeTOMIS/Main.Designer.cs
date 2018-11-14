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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ippConStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippConStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippEndPtStatLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippEndPtStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippStatusMsgLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ippCmdProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabFR = new System.Windows.Forms.TabControl();
            this.FacialRecognition = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSendImageToIPP = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDeDupStart = new System.Windows.Forms.Button();
            this.btnGenerateTemplate = new System.Windows.Forms.Button();
            this.btnGenTemplates = new System.Windows.Forms.Button();
            this.imgDisplay = new System.Windows.Forms.PictureBox();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabFR.SuspendLayout();
            this.FacialRecognition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ippConStatusLbl,
            this.ippConStatus,
            this.ippEndPtStatLbl,
            this.ippEndPtStat,
            this.ippStatusMsgLbl,
            this.ippStatus,
            this.ippCmdProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1017);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1896, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ippConStatusLbl
            // 
            this.ippConStatusLbl.Name = "ippConStatusLbl";
            this.ippConStatusLbl.Size = new System.Drawing.Size(94, 26);
            this.ippConStatusLbl.Text = "IPP Status:";
            // 
            // ippConStatus
            // 
            this.ippConStatus.Name = "ippConStatus";
            this.ippConStatus.Size = new System.Drawing.Size(154, 26);
            this.ippConStatus.Text = "NOT CONNECTED";
            // 
            // ippEndPtStatLbl
            // 
            this.ippEndPtStatLbl.Name = "ippEndPtStatLbl";
            this.ippEndPtStatLbl.Size = new System.Drawing.Size(118, 26);
            this.ippEndPtStatLbl.Text = "IPP Endpoint:";
            // 
            // ippEndPtStat
            // 
            this.ippEndPtStat.Name = "ippEndPtStat";
            this.ippEndPtStat.Size = new System.Drawing.Size(64, 26);
            this.ippEndPtStat.Text = "LOCAL";
            // 
            // ippStatusMsgLbl
            // 
            this.ippStatusMsgLbl.Name = "ippStatusMsgLbl";
            this.ippStatusMsgLbl.Size = new System.Drawing.Size(64, 26);
            this.ippStatusMsgLbl.Text = "Status:";
            // 
            // ippStatus
            // 
            this.ippStatus.Name = "ippStatus";
            this.ippStatus.Size = new System.Drawing.Size(37, 26);
            this.ippStatus.Text = "NA";
            // 
            // ippCmdProgressBar
            // 
            this.ippCmdProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ippCmdProgressBar.Name = "ippCmdProgressBar";
            this.ippCmdProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ippCmdProgressBar.Size = new System.Drawing.Size(150, 25);
            // 
            // tabFR
            // 
            this.tabFR.Controls.Add(this.FacialRecognition);
            this.tabFR.Controls.Add(this.tabSetup);
            this.tabFR.Controls.Add(this.tabResults);
            this.tabFR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFR.Location = new System.Drawing.Point(0, 0);
            this.tabFR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFR.Name = "tabFR";
            this.tabFR.SelectedIndex = 0;
            this.tabFR.Size = new System.Drawing.Size(1896, 1017);
            this.tabFR.TabIndex = 1;
            // 
            // FacialRecognition
            // 
            this.FacialRecognition.Controls.Add(this.splitContainer1);
            this.FacialRecognition.Location = new System.Drawing.Point(4, 29);
            this.FacialRecognition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacialRecognition.Name = "FacialRecognition";
            this.FacialRecognition.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacialRecognition.Size = new System.Drawing.Size(1888, 984);
            this.FacialRecognition.TabIndex = 0;
            this.FacialRecognition.Text = "Facial Recognition";
            this.FacialRecognition.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSendImageToIPP);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeDupStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerateTemplate);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenTemplates);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imgDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(1880, 974);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSendImageToIPP
            // 
            this.btnSendImageToIPP.Location = new System.Drawing.Point(94, 645);
            this.btnSendImageToIPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendImageToIPP.Name = "btnSendImageToIPP";
            this.btnSendImageToIPP.Size = new System.Drawing.Size(322, 103);
            this.btnSendImageToIPP.TabIndex = 6;
            this.btnSendImageToIPP.Text = "Find Image";
            this.btnSendImageToIPP.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(94, 411);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(322, 103);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect to IPP";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDeDupStart
            // 
            this.btnDeDupStart.Enabled = false;
            this.btnDeDupStart.Location = new System.Drawing.Point(94, 257);
            this.btnDeDupStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeDupStart.Name = "btnDeDupStart";
            this.btnDeDupStart.Size = new System.Drawing.Size(322, 103);
            this.btnDeDupStart.TabIndex = 4;
            this.btnDeDupStart.Text = "Start DeDuplicaiton";
            this.btnDeDupStart.UseVisualStyleBackColor = true;
            // 
            // btnGenerateTemplate
            // 
            this.btnGenerateTemplate.Enabled = false;
            this.btnGenerateTemplate.Location = new System.Drawing.Point(94, 145);
            this.btnGenerateTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateTemplate.Name = "btnGenerateTemplate";
            this.btnGenerateTemplate.Size = new System.Drawing.Size(322, 103);
            this.btnGenerateTemplate.TabIndex = 3;
            this.btnGenerateTemplate.Text = "Generate Single Template";
            this.btnGenerateTemplate.UseVisualStyleBackColor = true;
            // 
            // btnGenTemplates
            // 
            this.btnGenTemplates.Enabled = false;
            this.btnGenTemplates.Location = new System.Drawing.Point(94, 32);
            this.btnGenTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenTemplates.Name = "btnGenTemplates";
            this.btnGenTemplates.Size = new System.Drawing.Size(322, 103);
            this.btnGenTemplates.TabIndex = 0;
            this.btnGenTemplates.Text = "Generate Templates from TOMIS";
            this.btnGenTemplates.UseVisualStyleBackColor = true;
            // 
            // imgDisplay
            // 
            this.imgDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgDisplay.Location = new System.Drawing.Point(0, 0);
            this.imgDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgDisplay.MinimumSize = new System.Drawing.Size(450, 308);
            this.imgDisplay.Name = "imgDisplay";
            this.imgDisplay.Size = new System.Drawing.Size(1362, 974);
            this.imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgDisplay.TabIndex = 0;
            this.imgDisplay.TabStop = false;
            // 
            // tabSetup
            // 
            this.tabSetup.Location = new System.Drawing.Point(4, 29);
            this.tabSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Size = new System.Drawing.Size(1888, 984);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // tabResults
            // 
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Size = new System.Drawing.Size(1888, 981);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "DeDupe Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.tabFR);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1909, 1078);
            this.Name = "Main";
            this.Text = "deDupe Tomis";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabFR.ResumeLayout(false);
            this.FacialRecognition.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabFR;
        private System.Windows.Forms.TabPage FacialRecognition;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel ippConStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippConStatus;
        private System.Windows.Forms.Button btnGenTemplates;
        private System.Windows.Forms.Button btnGenerateTemplate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDeDupStart;
        private System.Windows.Forms.ToolStripStatusLabel ippEndPtStatLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippEndPtStat;
        private System.Windows.Forms.ToolStripStatusLabel ippStatusMsgLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippStatus;
        private System.Windows.Forms.Button btnSendImageToIPP;
        private System.Windows.Forms.ToolStripProgressBar ippCmdProgressBar;
        private System.Windows.Forms.PictureBox imgDisplay;
        private System.Windows.Forms.TabPage tabResults;
    }
}

