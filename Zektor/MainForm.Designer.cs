namespace Zektor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpIOControl = new System.Windows.Forms.TabPage();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.fctbLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tpAVControl = new System.Windows.Forms.TabPage();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.tbLastErrorCode = new System.Windows.Forms.TextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.gbXS = new System.Windows.Forms.GroupBox();
            this.lblAMU = new System.Windows.Forms.Label();
            this.lblVMU = new System.Windows.Forms.Label();
            this.lblAUT = new System.Windows.Forms.Label();
            this.lblKYD = new System.Windows.Forms.Label();
            this.lblIRJ = new System.Windows.Forms.Label();
            this.lblIRS = new System.Windows.Forms.Label();
            this.lblIRE = new System.Windows.Forms.Label();
            this.lblKYE = new System.Windows.Forms.Label();
            this.lblCHS = new System.Windows.Forms.Label();
            this.lblSET = new System.Windows.Forms.Label();
            this.lblCSE = new System.Windows.Forms.Label();
            this.lblCRE = new System.Windows.Forms.Label();
            this.lblCHM = new System.Windows.Forms.Label();
            this.lblECO = new System.Windows.Forms.Label();
            this.lblACK = new System.Windows.Forms.Label();
            this.lblASY = new System.Windows.Forms.Label();
            this.pbXS_AMU = new System.Windows.Forms.Panel();
            this.pbXS_CHS = new System.Windows.Forms.Panel();
            this.pbXS_VMU = new System.Windows.Forms.Panel();
            this.pbXS_SET = new System.Windows.Forms.Panel();
            this.pbXS_IRJ = new System.Windows.Forms.Panel();
            this.pbXS_CHM = new System.Windows.Forms.Panel();
            this.pbXS_AUT = new System.Windows.Forms.Panel();
            this.pbXS_CSE = new System.Windows.Forms.Panel();
            this.pbXS_IRS = new System.Windows.Forms.Panel();
            this.pbXS_ECO = new System.Windows.Forms.Panel();
            this.pbXS_KYD = new System.Windows.Forms.Panel();
            this.pbXS_CRE = new System.Windows.Forms.Panel();
            this.pbXS_IRE = new System.Windows.Forms.Panel();
            this.pbXS_ACK = new System.Windows.Forms.Panel();
            this.pbXS_KYE = new System.Windows.Forms.Panel();
            this.pbXS_ASY = new System.Windows.Forms.Panel();
            this.gbLedIntensity = new System.Windows.Forms.GroupBox();
            this.tbFirmwareVersion = new System.Windows.Forms.TextBox();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tpIOControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbLog)).BeginInit();
            this.tpAdvanced.SuspendLayout();
            this.gbXS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(957, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tpIOControl);
            this.tabs.Controls.Add(this.tpAVControl);
            this.tabs.Controls.Add(this.tpAdvanced);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 24);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(957, 599);
            this.tabs.TabIndex = 4;
            // 
            // tpIOControl
            // 
            this.tpIOControl.Controls.Add(this.flowLayout);
            this.tpIOControl.Controls.Add(this.fctbLog);
            this.tpIOControl.Location = new System.Drawing.Point(4, 22);
            this.tpIOControl.Name = "tpIOControl";
            this.tpIOControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpIOControl.Size = new System.Drawing.Size(949, 573);
            this.tpIOControl.TabIndex = 0;
            this.tpIOControl.Text = "I/O control";
            this.tpIOControl.UseVisualStyleBackColor = true;
            // 
            // flowLayout
            // 
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(3, 3);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(636, 567);
            this.flowLayout.TabIndex = 0;
            // 
            // fctbLog
            // 
            this.fctbLog.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.fctbLog.BackBrush = null;
            this.fctbLog.CharHeight = 15;
            this.fctbLog.CharWidth = 7;
            this.fctbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.fctbLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fctbLog.IsReplaceMode = false;
            this.fctbLog.Location = new System.Drawing.Point(639, 3);
            this.fctbLog.Name = "fctbLog";
            this.fctbLog.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbLog.Size = new System.Drawing.Size(307, 567);
            this.fctbLog.TabIndex = 1;
            this.fctbLog.Zoom = 100;
            // 
            // tpAVControl
            // 
            this.tpAVControl.Location = new System.Drawing.Point(4, 22);
            this.tpAVControl.Name = "tpAVControl";
            this.tpAVControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpAVControl.Size = new System.Drawing.Size(853, 517);
            this.tpAVControl.TabIndex = 1;
            this.tpAVControl.Text = "A/V controls";
            this.tpAVControl.UseVisualStyleBackColor = true;
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.tbLastErrorCode);
            this.tpAdvanced.Controls.Add(this.lblLastError);
            this.tpAdvanced.Controls.Add(this.btnSetIP);
            this.tpAdvanced.Controls.Add(this.tbIpAddress);
            this.tpAdvanced.Controls.Add(this.lblIpAddress);
            this.tpAdvanced.Controls.Add(this.gbXS);
            this.tpAdvanced.Controls.Add(this.gbLedIntensity);
            this.tpAdvanced.Controls.Add(this.tbFirmwareVersion);
            this.tpAdvanced.Controls.Add(this.lblFirmwareVersion);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(853, 517);
            this.tpAdvanced.TabIndex = 2;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // tbLastErrorCode
            // 
            this.tbLastErrorCode.Location = new System.Drawing.Point(152, 72);
            this.tbLastErrorCode.Name = "tbLastErrorCode";
            this.tbLastErrorCode.Size = new System.Drawing.Size(216, 20);
            this.tbLastErrorCode.TabIndex = 5;
            // 
            // lblLastError
            // 
            this.lblLastError.AutoSize = true;
            this.lblLastError.Location = new System.Drawing.Point(38, 75);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(78, 13);
            this.lblLastError.TabIndex = 4;
            this.lblLastError.Text = "Last error code";
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(374, 17);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(75, 23);
            this.btnSetIP.TabIndex = 0;
            this.btnSetIP.Text = "Set";
            this.btnSetIP.UseVisualStyleBackColor = true;
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(152, 20);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(216, 20);
            this.tbIpAddress.TabIndex = 3;
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(38, 23);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblIpAddress.TabIndex = 2;
            this.lblIpAddress.Text = "IP address";
            // 
            // gbXS
            // 
            this.gbXS.Controls.Add(this.lblAMU);
            this.gbXS.Controls.Add(this.lblVMU);
            this.gbXS.Controls.Add(this.lblAUT);
            this.gbXS.Controls.Add(this.lblKYD);
            this.gbXS.Controls.Add(this.lblIRJ);
            this.gbXS.Controls.Add(this.lblIRS);
            this.gbXS.Controls.Add(this.lblIRE);
            this.gbXS.Controls.Add(this.lblKYE);
            this.gbXS.Controls.Add(this.lblCHS);
            this.gbXS.Controls.Add(this.lblSET);
            this.gbXS.Controls.Add(this.lblCSE);
            this.gbXS.Controls.Add(this.lblCRE);
            this.gbXS.Controls.Add(this.lblCHM);
            this.gbXS.Controls.Add(this.lblECO);
            this.gbXS.Controls.Add(this.lblACK);
            this.gbXS.Controls.Add(this.lblASY);
            this.gbXS.Controls.Add(this.pbXS_AMU);
            this.gbXS.Controls.Add(this.pbXS_CHS);
            this.gbXS.Controls.Add(this.pbXS_VMU);
            this.gbXS.Controls.Add(this.pbXS_SET);
            this.gbXS.Controls.Add(this.pbXS_IRJ);
            this.gbXS.Controls.Add(this.pbXS_CHM);
            this.gbXS.Controls.Add(this.pbXS_AUT);
            this.gbXS.Controls.Add(this.pbXS_CSE);
            this.gbXS.Controls.Add(this.pbXS_IRS);
            this.gbXS.Controls.Add(this.pbXS_ECO);
            this.gbXS.Controls.Add(this.pbXS_KYD);
            this.gbXS.Controls.Add(this.pbXS_CRE);
            this.gbXS.Controls.Add(this.pbXS_IRE);
            this.gbXS.Controls.Add(this.pbXS_ACK);
            this.gbXS.Controls.Add(this.pbXS_KYE);
            this.gbXS.Controls.Add(this.pbXS_ASY);
            this.gbXS.Location = new System.Drawing.Point(41, 248);
            this.gbXS.Name = "gbXS";
            this.gbXS.Size = new System.Drawing.Size(678, 80);
            this.gbXS.TabIndex = 3;
            this.gbXS.TabStop = false;
            this.gbXS.Text = "Control settings";
            // 
            // lblAMU
            // 
            this.lblAMU.AutoSize = true;
            this.lblAMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMU.Location = new System.Drawing.Point(586, 54);
            this.lblAMU.Name = "lblAMU";
            this.lblAMU.Size = new System.Drawing.Size(41, 16);
            this.lblAMU.TabIndex = 31;
            this.lblAMU.Text = "AMU";
            this.lblAMU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVMU
            // 
            this.lblVMU.AutoSize = true;
            this.lblVMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVMU.Location = new System.Drawing.Point(548, 54);
            this.lblVMU.Name = "lblVMU";
            this.lblVMU.Size = new System.Drawing.Size(41, 16);
            this.lblVMU.TabIndex = 30;
            this.lblVMU.Text = "VMU";
            this.lblVMU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAUT
            // 
            this.lblAUT.AutoSize = true;
            this.lblAUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAUT.Location = new System.Drawing.Point(511, 54);
            this.lblAUT.Name = "lblAUT";
            this.lblAUT.Size = new System.Drawing.Size(39, 16);
            this.lblAUT.TabIndex = 29;
            this.lblAUT.Text = "AUT";
            this.lblAUT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKYD
            // 
            this.lblKYD.AutoSize = true;
            this.lblKYD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKYD.Location = new System.Drawing.Point(473, 54);
            this.lblKYD.Name = "lblKYD";
            this.lblKYD.Size = new System.Drawing.Size(38, 16);
            this.lblKYD.TabIndex = 28;
            this.lblKYD.Text = "KYD";
            this.lblKYD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIRJ
            // 
            this.lblIRJ.AutoSize = true;
            this.lblIRJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRJ.Location = new System.Drawing.Point(438, 54);
            this.lblIRJ.Name = "lblIRJ";
            this.lblIRJ.Size = new System.Drawing.Size(31, 16);
            this.lblIRJ.TabIndex = 27;
            this.lblIRJ.Text = "IRJ";
            this.lblIRJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIRS
            // 
            this.lblIRS.AutoSize = true;
            this.lblIRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRS.Location = new System.Drawing.Point(400, 54);
            this.lblIRS.Name = "lblIRS";
            this.lblIRS.Size = new System.Drawing.Size(33, 16);
            this.lblIRS.TabIndex = 26;
            this.lblIRS.Text = "IRS";
            this.lblIRS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIRE
            // 
            this.lblIRE.AutoSize = true;
            this.lblIRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRE.Location = new System.Drawing.Point(362, 54);
            this.lblIRE.Name = "lblIRE";
            this.lblIRE.Size = new System.Drawing.Size(33, 16);
            this.lblIRE.TabIndex = 25;
            this.lblIRE.Text = "IRE";
            this.lblIRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKYE
            // 
            this.lblKYE.AutoSize = true;
            this.lblKYE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKYE.Location = new System.Drawing.Point(320, 54);
            this.lblKYE.Name = "lblKYE";
            this.lblKYE.Size = new System.Drawing.Size(37, 16);
            this.lblKYE.TabIndex = 24;
            this.lblKYE.Text = "KYE";
            this.lblKYE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCHS
            // 
            this.lblCHS.AutoSize = true;
            this.lblCHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHS.Location = new System.Drawing.Point(282, 54);
            this.lblCHS.Name = "lblCHS";
            this.lblCHS.Size = new System.Drawing.Size(39, 16);
            this.lblCHS.TabIndex = 23;
            this.lblCHS.Text = "CHS";
            this.lblCHS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSET
            // 
            this.lblSET.AutoSize = true;
            this.lblSET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSET.Location = new System.Drawing.Point(244, 54);
            this.lblSET.Name = "lblSET";
            this.lblSET.Size = new System.Drawing.Size(38, 16);
            this.lblSET.TabIndex = 22;
            this.lblSET.Text = "SET";
            this.lblSET.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCSE
            // 
            this.lblCSE.AutoSize = true;
            this.lblCSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSE.Location = new System.Drawing.Point(206, 54);
            this.lblCSE.Name = "lblCSE";
            this.lblCSE.Size = new System.Drawing.Size(38, 16);
            this.lblCSE.TabIndex = 21;
            this.lblCSE.Text = "CSE";
            this.lblCSE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCRE
            // 
            this.lblCRE.AutoSize = true;
            this.lblCRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRE.Location = new System.Drawing.Point(168, 54);
            this.lblCRE.Name = "lblCRE";
            this.lblCRE.Size = new System.Drawing.Size(39, 16);
            this.lblCRE.TabIndex = 20;
            this.lblCRE.Text = "CRE";
            this.lblCRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCHM
            // 
            this.lblCHM.AutoSize = true;
            this.lblCHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHM.Location = new System.Drawing.Point(130, 54);
            this.lblCHM.Name = "lblCHM";
            this.lblCHM.Size = new System.Drawing.Size(41, 16);
            this.lblCHM.TabIndex = 19;
            this.lblCHM.Text = "CHM";
            this.lblCHM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblECO
            // 
            this.lblECO.AutoSize = true;
            this.lblECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECO.Location = new System.Drawing.Point(92, 54);
            this.lblECO.Name = "lblECO";
            this.lblECO.Size = new System.Drawing.Size(39, 16);
            this.lblECO.TabIndex = 18;
            this.lblECO.Text = "ECO";
            this.lblECO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblACK
            // 
            this.lblACK.AutoSize = true;
            this.lblACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACK.Location = new System.Drawing.Point(54, 54);
            this.lblACK.Name = "lblACK";
            this.lblACK.Size = new System.Drawing.Size(37, 16);
            this.lblACK.TabIndex = 17;
            this.lblACK.Text = "ACK";
            this.lblACK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblASY
            // 
            this.lblASY.AutoSize = true;
            this.lblASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASY.Location = new System.Drawing.Point(16, 54);
            this.lblASY.Name = "lblASY";
            this.lblASY.Size = new System.Drawing.Size(38, 16);
            this.lblASY.TabIndex = 16;
            this.lblASY.Text = "ASY";
            this.lblASY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbXS_AMU
            // 
            this.pbXS_AMU.BackColor = System.Drawing.Color.Silver;
            this.pbXS_AMU.Location = new System.Drawing.Point(589, 19);
            this.pbXS_AMU.Name = "pbXS_AMU";
            this.pbXS_AMU.Size = new System.Drawing.Size(32, 32);
            this.pbXS_AMU.TabIndex = 15;
            this.tooltip.SetToolTip(this.pbXS_AMU, "AMU\n\nOff=Disable audio muting when a zone is muted.\nOn=Enable audio muting when a" +
        " zone is muted.");
            this.pbXS_AMU.Click += new System.EventHandler(this.pbXS_AMU_Click);
            // 
            // pbXS_CHS
            // 
            this.pbXS_CHS.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CHS.Location = new System.Drawing.Point(285, 19);
            this.pbXS_CHS.Name = "pbXS_CHS";
            this.pbXS_CHS.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CHS.TabIndex = 7;
            this.tooltip.SetToolTip(this.pbXS_CHS, "CHS\n\nOff=Setup mode is read only.\nOn=Enable changing parameters in the setup mode" +
        ".");
            this.pbXS_CHS.Click += new System.EventHandler(this.pbXS_CHS_Click);
            // 
            // pbXS_VMU
            // 
            this.pbXS_VMU.BackColor = System.Drawing.Color.Silver;
            this.pbXS_VMU.Location = new System.Drawing.Point(551, 19);
            this.pbXS_VMU.Name = "pbXS_VMU";
            this.pbXS_VMU.Size = new System.Drawing.Size(32, 32);
            this.pbXS_VMU.TabIndex = 14;
            this.tooltip.SetToolTip(this.pbXS_VMU, "VMU\n\nOff=Disable video muting when a zone is muted.\nOn=Enable video muting when a" +
        " zone is muted.");
            this.pbXS_VMU.Click += new System.EventHandler(this.pbXS_VMU_Click);
            // 
            // pbXS_SET
            // 
            this.pbXS_SET.BackColor = System.Drawing.Color.Silver;
            this.pbXS_SET.Location = new System.Drawing.Point(247, 19);
            this.pbXS_SET.Name = "pbXS_SET";
            this.pbXS_SET.Size = new System.Drawing.Size(32, 32);
            this.pbXS_SET.TabIndex = 6;
            this.tooltip.SetToolTip(this.pbXS_SET, "SET\n\nOff=Disable the setup option.\nOn=Enable the setup option.");
            this.pbXS_SET.Click += new System.EventHandler(this.pbXS_SET_Click);
            // 
            // pbXS_IRJ
            // 
            this.pbXS_IRJ.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRJ.Location = new System.Drawing.Point(437, 19);
            this.pbXS_IRJ.Name = "pbXS_IRJ";
            this.pbXS_IRJ.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRJ.TabIndex = 11;
            this.tooltip.SetToolTip(this.pbXS_IRJ, "IRJ\n\nOff=Disable IR jack.\nOn=Enable IR jack.");
            this.pbXS_IRJ.Click += new System.EventHandler(this.pbXS_IRJ_Click);
            // 
            // pbXS_CHM
            // 
            this.pbXS_CHM.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CHM.Location = new System.Drawing.Point(133, 19);
            this.pbXS_CHM.Name = "pbXS_CHM";
            this.pbXS_CHM.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CHM.TabIndex = 3;
            this.tooltip.SetToolTip(this.pbXS_CHM, "CHM\n\nOff=Only send a “.ch” when needed.\nOn=Always append a “.ch” channel mask to " +
        "a zone response cmd");
            this.pbXS_CHM.Click += new System.EventHandler(this.pbXS_CHM_Click);
            // 
            // pbXS_AUT
            // 
            this.pbXS_AUT.BackColor = System.Drawing.Color.Silver;
            this.pbXS_AUT.Location = new System.Drawing.Point(513, 19);
            this.pbXS_AUT.Name = "pbXS_AUT";
            this.pbXS_AUT.Size = new System.Drawing.Size(32, 32);
            this.pbXS_AUT.TabIndex = 13;
            this.tooltip.SetToolTip(this.pbXS_AUT, "AUT\n\nOff=Classic Analog/Digital mode.\nOn=Automatic conversion of Analog/Digital p" +
        "aths.");
            this.pbXS_AUT.Click += new System.EventHandler(this.pbXS_AUT_Click);
            // 
            // pbXS_CSE
            // 
            this.pbXS_CSE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CSE.Location = new System.Drawing.Point(209, 19);
            this.pbXS_CSE.Name = "pbXS_CSE";
            this.pbXS_CSE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CSE.TabIndex = 5;
            this.tooltip.SetToolTip(this.pbXS_CSE, "CSE\n\nOff=Disable the sending of checksums.\nOn=Append a checksums to all responses" +
        ".");
            this.pbXS_CSE.Click += new System.EventHandler(this.pbXS_CSE_Click);
            // 
            // pbXS_IRS
            // 
            this.pbXS_IRS.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRS.Location = new System.Drawing.Point(399, 19);
            this.pbXS_IRS.Name = "pbXS_IRS";
            this.pbXS_IRS.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRS.TabIndex = 10;
            this.tooltip.SetToolTip(this.pbXS_IRS, "IRS\n\nOff=Disable IR sensor.\nOn=Enable IR sensor.");
            this.pbXS_IRS.Click += new System.EventHandler(this.pbXS_IRS_Click);
            // 
            // pbXS_ECO
            // 
            this.pbXS_ECO.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ECO.Location = new System.Drawing.Point(95, 19);
            this.pbXS_ECO.Name = "pbXS_ECO";
            this.pbXS_ECO.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ECO.TabIndex = 2;
            this.tooltip.SetToolTip(this.pbXS_ECO, "ECO\n\nOff=Do not send a response strings for each cmd.\nOn=Always send response str" +
        "ing when a serial command is issued");
            this.pbXS_ECO.Click += new System.EventHandler(this.pbXS_ECO_Click);
            // 
            // pbXS_KYD
            // 
            this.pbXS_KYD.BackColor = System.Drawing.Color.Silver;
            this.pbXS_KYD.Location = new System.Drawing.Point(475, 19);
            this.pbXS_KYD.Name = "pbXS_KYD";
            this.pbXS_KYD.Size = new System.Drawing.Size(32, 32);
            this.pbXS_KYD.TabIndex = 12;
            this.tooltip.SetToolTip(this.pbXS_KYD, "KYD\n\nOff=Disable front panel keys, overrides ‘KYE’.\nOn=Enable front panel keys (a" +
        "llows ‘KYE’ and ‘KE’ settings).");
            this.pbXS_KYD.Click += new System.EventHandler(this.pbXS_KYD_Click);
            // 
            // pbXS_CRE
            // 
            this.pbXS_CRE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CRE.Location = new System.Drawing.Point(171, 19);
            this.pbXS_CRE.Name = "pbXS_CRE";
            this.pbXS_CRE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CRE.TabIndex = 4;
            this.tooltip.SetToolTip(this.pbXS_CRE, "CRE\n\nOff=Don’t send CRs/LFs at end of responses\nOn=End all responses with a carri" +
        "age return and a line feed.");
            this.pbXS_CRE.Click += new System.EventHandler(this.pbXS_CRE_Click);
            // 
            // pbXS_IRE
            // 
            this.pbXS_IRE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRE.Location = new System.Drawing.Point(361, 19);
            this.pbXS_IRE.Name = "pbXS_IRE";
            this.pbXS_IRE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRE.TabIndex = 9;
            this.tooltip.SetToolTip(this.pbXS_IRE, "IRE\n\nOff=Use ‘IRE’ settings for IR control.\nOn=Enable all IR commands, overrides " +
        "‘IRE’ settings.");
            this.pbXS_IRE.Click += new System.EventHandler(this.pbXS_IRE_Click);
            // 
            // pbXS_ACK
            // 
            this.pbXS_ACK.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ACK.Location = new System.Drawing.Point(57, 19);
            this.pbXS_ACK.Name = "pbXS_ACK";
            this.pbXS_ACK.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ACK.TabIndex = 1;
            this.tooltip.SetToolTip(this.pbXS_ACK, "ACK\n\nOff=Don’t acknowledge cmds with “^+$”\nOn=Acknowledge error free commands wit" +
        "h a “^+$”");
            this.pbXS_ACK.Click += new System.EventHandler(this.pbXS_ACK_Click);
            // 
            // pbXS_KYE
            // 
            this.pbXS_KYE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_KYE.Location = new System.Drawing.Point(323, 19);
            this.pbXS_KYE.Name = "pbXS_KYE";
            this.pbXS_KYE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_KYE.TabIndex = 8;
            this.tooltip.SetToolTip(this.pbXS_KYE, "KYE\n\nOff=Use ‘KE’ settings for front panels keys.\nOn=Enable all front panel keys," +
        " overrides ‘KE’ settings.");
            this.pbXS_KYE.Click += new System.EventHandler(this.pbXS_KYE_Click);
            // 
            // pbXS_ASY
            // 
            this.pbXS_ASY.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ASY.Location = new System.Drawing.Point(19, 19);
            this.pbXS_ASY.Name = "pbXS_ASY";
            this.pbXS_ASY.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ASY.TabIndex = 0;
            this.tooltip.SetToolTip(this.pbXS_ASY, "ASY\r\n\r\nOff=Polled mode.\r\nOn=Asynchronous Mode.");
            this.pbXS_ASY.Click += new System.EventHandler(this.pbXS_ASY_Click);
            // 
            // gbLedIntensity
            // 
            this.gbLedIntensity.Location = new System.Drawing.Point(41, 142);
            this.gbLedIntensity.Name = "gbLedIntensity";
            this.gbLedIntensity.Size = new System.Drawing.Size(678, 100);
            this.gbLedIntensity.TabIndex = 2;
            this.gbLedIntensity.TabStop = false;
            this.gbLedIntensity.Text = "Front panel led intensity";
            // 
            // tbFirmwareVersion
            // 
            this.tbFirmwareVersion.Location = new System.Drawing.Point(152, 46);
            this.tbFirmwareVersion.Name = "tbFirmwareVersion";
            this.tbFirmwareVersion.Size = new System.Drawing.Size(216, 20);
            this.tbFirmwareVersion.TabIndex = 1;
            // 
            // lblFirmwareVersion
            // 
            this.lblFirmwareVersion.AutoSize = true;
            this.lblFirmwareVersion.Location = new System.Drawing.Point(38, 49);
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            this.lblFirmwareVersion.Size = new System.Drawing.Size(86, 13);
            this.lblFirmwareVersion.TabIndex = 0;
            this.lblFirmwareVersion.Text = "Firmware version";
            // 
            // tooltip
            // 
            this.tooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.tooltip_Popup);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 623);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Zektor Prowler/Clarity Elite controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tpIOControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbLog)).EndInit();
            this.tpAdvanced.ResumeLayout(false);
            this.tpAdvanced.PerformLayout();
            this.gbXS.ResumeLayout(false);
            this.gbXS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tpIOControl;
        private System.Windows.Forms.TabPage tpAVControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.GroupBox gbXS;
        private System.Windows.Forms.GroupBox gbLedIntensity;
        private System.Windows.Forms.TextBox tbFirmwareVersion;
        private System.Windows.Forms.Label lblFirmwareVersion;
        private System.Windows.Forms.TextBox tbLastErrorCode;
        private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblAMU;
        private System.Windows.Forms.Label lblVMU;
        private System.Windows.Forms.Label lblAUT;
        private System.Windows.Forms.Label lblKYD;
        private System.Windows.Forms.Label lblIRJ;
        private System.Windows.Forms.Label lblIRS;
        private System.Windows.Forms.Label lblIRE;
        private System.Windows.Forms.Label lblKYE;
        private System.Windows.Forms.Label lblCHS;
        private System.Windows.Forms.Label lblSET;
        private System.Windows.Forms.Label lblCSE;
        private System.Windows.Forms.Label lblCRE;
        private System.Windows.Forms.Label lblCHM;
        private System.Windows.Forms.Label lblECO;
        private System.Windows.Forms.Label lblACK;
        private System.Windows.Forms.Label lblASY;
        private System.Windows.Forms.Panel pbXS_AMU;
        private System.Windows.Forms.Panel pbXS_CHS;
        private System.Windows.Forms.Panel pbXS_VMU;
        private System.Windows.Forms.Panel pbXS_SET;
        private System.Windows.Forms.Panel pbXS_IRJ;
        private System.Windows.Forms.Panel pbXS_CHM;
        private System.Windows.Forms.Panel pbXS_AUT;
        private System.Windows.Forms.Panel pbXS_CSE;
        private System.Windows.Forms.Panel pbXS_IRS;
        private System.Windows.Forms.Panel pbXS_ECO;
        private System.Windows.Forms.Panel pbXS_KYD;
        private System.Windows.Forms.Panel pbXS_CRE;
        private System.Windows.Forms.Panel pbXS_IRE;
        private System.Windows.Forms.Panel pbXS_ACK;
        private System.Windows.Forms.Panel pbXS_KYE;
        private System.Windows.Forms.Panel pbXS_ASY;
        private System.Windows.Forms.ToolTip tooltip;
        private FastColoredTextBoxNS.FastColoredTextBox fctbLog;
    }
}

