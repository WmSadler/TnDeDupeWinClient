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
            this.tabDeDupMain = new System.Windows.Forms.TabControl();
            this.tabFacialRecognition = new System.Windows.Forms.TabPage();
            this.splitContainerMainFr = new System.Windows.Forms.SplitContainer();
            this.btnCameraOn = new System.Windows.Forms.Button();
            this.btnRecogFaceCamera = new System.Windows.Forms.Button();
            this.btnGenerateTemplateCamera = new System.Windows.Forms.Button();
            this.btnRecogFaceFile = new System.Windows.Forms.Button();
            this.btnDeDupStart = new System.Windows.Forms.Button();
            this.btnGenerateTemplatesFile = new System.Windows.Forms.Button();
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
            this.dbTomisUri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPingIPP = new System.Windows.Forms.Button();
            this.grpBoxTemplateDb = new System.Windows.Forms.GroupBox();
            this.dbSigPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbSigUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbSigUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestTemplateDb = new System.Windows.Forms.Button();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox1.SuspendLayout();
            this.grpBoxTemplateDb.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 991);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1887, 31);
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
            this.tabDeDupMain.Size = new System.Drawing.Size(1887, 991);
            this.tabDeDupMain.TabIndex = 1;
            // 
            // tabFacialRecognition
            // 
            this.tabFacialRecognition.Controls.Add(this.splitContainerMainFr);
            this.tabFacialRecognition.Location = new System.Drawing.Point(4, 29);
            this.tabFacialRecognition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFacialRecognition.Name = "tabFacialRecognition";
            this.tabFacialRecognition.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFacialRecognition.Size = new System.Drawing.Size(1879, 958);
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
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnCameraOn);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnRecogFaceCamera);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnGenerateTemplateCamera);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnRecogFaceFile);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnDeDupStart);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnGenerateTemplatesFile);
            this.splitContainerMainFr.Panel1.Controls.Add(this.btnGenTemplatesTomis);
            this.splitContainerMainFr.Panel1MinSize = 375;
            // 
            // splitContainerMainFr.Panel2
            // 
            this.splitContainerMainFr.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMainFr.Size = new System.Drawing.Size(1880, 974);
            this.splitContainerMainFr.SplitterDistance = 375;
            this.splitContainerMainFr.SplitterWidth = 1;
            this.splitContainerMainFr.TabIndex = 0;
            // 
            // btnCameraOn
            // 
            this.btnCameraOn.Location = new System.Drawing.Point(26, 790);
            this.btnCameraOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCameraOn.Name = "btnCameraOn";
            this.btnCameraOn.Size = new System.Drawing.Size(322, 103);
            this.btnCameraOn.TabIndex = 9;
            this.btnCameraOn.Text = "Camera On";
            this.btnCameraOn.UseVisualStyleBackColor = false;
            // 
            // btnRecogFaceCamera
            // 
            this.btnRecogFaceCamera.Location = new System.Drawing.Point(26, 646);
            this.btnRecogFaceCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecogFaceCamera.Name = "btnRecogFaceCamera";
            this.btnRecogFaceCamera.Size = new System.Drawing.Size(322, 103);
            this.btnRecogFaceCamera.TabIndex = 8;
            this.btnRecogFaceCamera.Text = "Recognize Face From Camera";
            this.btnRecogFaceCamera.UseVisualStyleBackColor = false;
            // 
            // btnGenerateTemplateCamera
            // 
            this.btnGenerateTemplateCamera.Enabled = false;
            this.btnGenerateTemplateCamera.Location = new System.Drawing.Point(26, 393);
            this.btnGenerateTemplateCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateTemplateCamera.Name = "btnGenerateTemplateCamera";
            this.btnGenerateTemplateCamera.Size = new System.Drawing.Size(322, 103);
            this.btnGenerateTemplateCamera.TabIndex = 7;
            this.btnGenerateTemplateCamera.Text = "Generate Template From Camera";
            this.btnGenerateTemplateCamera.UseVisualStyleBackColor = true;
            // 
            // btnRecogFaceFile
            // 
            this.btnRecogFaceFile.Location = new System.Drawing.Point(26, 533);
            this.btnRecogFaceFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecogFaceFile.Name = "btnRecogFaceFile";
            this.btnRecogFaceFile.Size = new System.Drawing.Size(322, 103);
            this.btnRecogFaceFile.TabIndex = 6;
            this.btnRecogFaceFile.Text = "Recognize Face From File";
            this.btnRecogFaceFile.UseVisualStyleBackColor = false;
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
            // btnGenerateTemplatesFile
            // 
            this.btnGenerateTemplatesFile.Enabled = false;
            this.btnGenerateTemplatesFile.Location = new System.Drawing.Point(26, 280);
            this.btnGenerateTemplatesFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateTemplatesFile.Name = "btnGenerateTemplatesFile";
            this.btnGenerateTemplatesFile.Size = new System.Drawing.Size(322, 103);
            this.btnGenerateTemplatesFile.TabIndex = 3;
            this.btnGenerateTemplatesFile.Text = "Generate Template From File";
            this.btnGenerateTemplatesFile.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1504, 974);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpImgOriginal
            // 
            this.grpImgOriginal.Controls.Add(this.imgOriginal);
            this.grpImgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgOriginal.Location = new System.Drawing.Point(3, 3);
            this.grpImgOriginal.Name = "grpImgOriginal";
            this.grpImgOriginal.Size = new System.Drawing.Size(746, 968);
            this.grpImgOriginal.TabIndex = 0;
            this.grpImgOriginal.TabStop = false;
            this.grpImgOriginal.Text = "Original Image";
            // 
            // imgOriginal
            // 
            this.imgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgOriginal.Location = new System.Drawing.Point(3, 22);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(740, 943);
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            // 
            // grpImgModified
            // 
            this.grpImgModified.Controls.Add(this.imgProcessed);
            this.grpImgModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImgModified.Location = new System.Drawing.Point(755, 3);
            this.grpImgModified.Name = "grpImgModified";
            this.grpImgModified.Size = new System.Drawing.Size(746, 968);
            this.grpImgModified.TabIndex = 1;
            this.grpImgModified.TabStop = false;
            this.grpImgModified.Text = "Processed Image";
            // 
            // imgProcessed
            // 
            this.imgProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProcessed.Location = new System.Drawing.Point(3, 22);
            this.imgProcessed.Name = "imgProcessed";
            this.imgProcessed.Size = new System.Drawing.Size(740, 943);
            this.imgProcessed.TabIndex = 0;
            this.imgProcessed.TabStop = false;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.grpBoxTomisDbSetup);
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Controls.Add(this.grpBoxTemplateDb);
            this.tabSetup.Location = new System.Drawing.Point(4, 29);
            this.tabSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Size = new System.Drawing.Size(1888, 984);
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
            this.grpBoxTomisDbSetup.Controls.Add(this.dbTomisUri);
            this.grpBoxTomisDbSetup.Controls.Add(this.label6);
            this.grpBoxTomisDbSetup.Controls.Add(this.button1);
            this.grpBoxTomisDbSetup.Location = new System.Drawing.Point(79, 255);
            this.grpBoxTomisDbSetup.Name = "grpBoxTomisDbSetup";
            this.grpBoxTomisDbSetup.Size = new System.Drawing.Size(808, 169);
            this.grpBoxTomisDbSetup.TabIndex = 2;
            this.grpBoxTomisDbSetup.TabStop = false;
            this.grpBoxTomisDbSetup.Text = "TOMIS Db Setup";
            // 
            // dbTomisPassword
            // 
            this.dbTomisPassword.Location = new System.Drawing.Point(428, 76);
            this.dbTomisPassword.Name = "dbTomisPassword";
            this.dbTomisPassword.Size = new System.Drawing.Size(311, 26);
            this.dbTomisPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // dbTomisUser
            // 
            this.dbTomisUser.Location = new System.Drawing.Point(138, 76);
            this.dbTomisUser.Name = "dbTomisUser";
            this.dbTomisUser.Size = new System.Drawing.Size(196, 26);
            this.dbTomisUser.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "User:";
            // 
            // dbTomisUri
            // 
            this.dbTomisUri.Location = new System.Drawing.Point(138, 28);
            this.dbTomisUri.Name = "dbTomisUri";
            this.dbTomisUri.Size = new System.Drawing.Size(601, 26);
            this.dbTomisUri.TabIndex = 2;
            this.dbTomisUri.Text = "localhost";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPingIPP);
            this.groupBox1.Location = new System.Drawing.Point(79, 579);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IPP Endpoint Setup";
            // 
            // btnPingIPP
            // 
            this.btnPingIPP.Location = new System.Drawing.Point(298, 284);
            this.btnPingIPP.Name = "btnPingIPP";
            this.btnPingIPP.Size = new System.Drawing.Size(235, 33);
            this.btnPingIPP.TabIndex = 1;
            this.btnPingIPP.Text = "Ping IPP";
            this.btnPingIPP.UseVisualStyleBackColor = true;
            // 
            // grpBoxTemplateDb
            // 
            this.grpBoxTemplateDb.Controls.Add(this.dbSigPassword);
            this.grpBoxTemplateDb.Controls.Add(this.label3);
            this.grpBoxTemplateDb.Controls.Add(this.dbSigUser);
            this.grpBoxTemplateDb.Controls.Add(this.label2);
            this.grpBoxTemplateDb.Controls.Add(this.dbSigUri);
            this.grpBoxTemplateDb.Controls.Add(this.label1);
            this.grpBoxTemplateDb.Controls.Add(this.btnTestTemplateDb);
            this.grpBoxTemplateDb.Location = new System.Drawing.Point(79, 52);
            this.grpBoxTemplateDb.Name = "grpBoxTemplateDb";
            this.grpBoxTemplateDb.Size = new System.Drawing.Size(808, 169);
            this.grpBoxTemplateDb.TabIndex = 0;
            this.grpBoxTemplateDb.TabStop = false;
            this.grpBoxTemplateDb.Text = "Template Db Setup";
            // 
            // dbSigPassword
            // 
            this.dbSigPassword.Location = new System.Drawing.Point(428, 76);
            this.dbSigPassword.Name = "dbSigPassword";
            this.dbSigPassword.Size = new System.Drawing.Size(311, 26);
            this.dbSigPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // dbSigUser
            // 
            this.dbSigUser.Location = new System.Drawing.Point(138, 76);
            this.dbSigUser.Name = "dbSigUser";
            this.dbSigUser.Size = new System.Drawing.Size(196, 26);
            this.dbSigUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 79);
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
            // btnTestTemplateDb
            // 
            this.btnTestTemplateDb.Location = new System.Drawing.Point(298, 120);
            this.btnTestTemplateDb.Name = "btnTestTemplateDb";
            this.btnTestTemplateDb.Size = new System.Drawing.Size(235, 33);
            this.btnTestTemplateDb.TabIndex = 0;
            this.btnTestTemplateDb.Text = "Test Connection";
            this.btnTestTemplateDb.UseVisualStyleBackColor = true;
            // 
            // tabResults
            // 
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Size = new System.Drawing.Size(1888, 984);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "DeDupe Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1887, 1022);
            this.Controls.Add(this.tabDeDupMain);
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
            this.groupBox1.ResumeLayout(false);
            this.grpBoxTemplateDb.ResumeLayout(false);
            this.grpBoxTemplateDb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabDeDupMain;
        private System.Windows.Forms.TabPage tabFacialRecognition;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.ToolStripStatusLabel ippConStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippConStatus;
        private System.Windows.Forms.ToolStripStatusLabel ippEndPtStatLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippEndPtStat;
        private System.Windows.Forms.ToolStripStatusLabel ippStatusMsgLbl;
        private System.Windows.Forms.ToolStripStatusLabel ippStatus;
        private System.Windows.Forms.ToolStripProgressBar ippCmdProgressBar;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.GroupBox grpBoxTomisDbSetup;
        private System.Windows.Forms.TextBox dbTomisPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbTomisUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbTomisUri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPingIPP;
        private System.Windows.Forms.GroupBox grpBoxTemplateDb;
        private System.Windows.Forms.TextBox dbSigPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbSigUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbSigUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestTemplateDb;
        private System.Windows.Forms.SplitContainer splitContainerMainFr;
        private System.Windows.Forms.Button btnRecogFaceCamera;
        private System.Windows.Forms.Button btnGenerateTemplateCamera;
        private System.Windows.Forms.Button btnRecogFaceFile;
        private System.Windows.Forms.Button btnDeDupStart;
        private System.Windows.Forms.Button btnGenerateTemplatesFile;
        private System.Windows.Forms.Button btnGenTemplatesTomis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpImgOriginal;
        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.GroupBox grpImgModified;
        private System.Windows.Forms.PictureBox imgProcessed;
        private System.Windows.Forms.Button btnCameraOn;
    }
}

