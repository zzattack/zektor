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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpMainConfig = new System.Windows.Forms.TabPage();
            this.gbMasterVolume = new System.Windows.Forms.GroupBox();
            this.lblVolumeLevelVal = new System.Windows.Forms.Label();
            this.btnReadMasterVolume = new System.Windows.Forms.Button();
            this.btnChangeMasterVolume = new System.Windows.Forms.Button();
            this.tkbMasterVolume = new System.Windows.Forms.TrackBar();
            this.lblVolumeLevel = new System.Windows.Forms.Label();
            this.gbPowerConfig = new System.Windows.Forms.GroupBox();
            this.lblConnectionStateVal = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPowerStateVal = new System.Windows.Forms.Label();
            this.lblPowerState = new System.Windows.Forms.Label();
            this.btnPowerToggle = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.gbZones = new System.Windows.Forms.GroupBox();
            this.flowLayoutZones = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAudioMode = new System.Windows.Forms.GroupBox();
            this.btnReadAudioMode = new System.Windows.Forms.Button();
            this.btnChangeAudioMode = new System.Windows.Forms.Button();
            this.rbAudioModeClassic = new System.Windows.Forms.RadioButton();
            this.rbAudioModeAutoConvert = new System.Windows.Forms.RadioButton();
            this.tpAVControl = new System.Windows.Forms.TabPage();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.gbDeviceStatus = new System.Windows.Forms.GroupBox();
            this.btnReadCapabilities = new System.Windows.Forms.Button();
            this.tbCapabilities = new System.Windows.Forms.TextBox();
            this.lblCapabilities = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.btnReadErrorCode = new System.Windows.Forms.Button();
            this.tbFirmwareVersion = new System.Windows.Forms.TextBox();
            this.btnReadFirmware = new System.Windows.Forms.Button();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.btnReadIP = new System.Windows.Forms.Button();
            this.btnChangeIP = new System.Windows.Forms.Button();
            this.tbLastErrorCode = new System.Windows.Forms.TextBox();
            this.lblLastError = new System.Windows.Forms.Label();
            this.gbLedIntensity = new System.Windows.Forms.GroupBox();
            this.lblPct3 = new System.Windows.Forms.Label();
            this.btnChangeLightingMode = new System.Windows.Forms.Button();
            this.nudStandby = new System.Windows.Forms.NumericUpDown();
            this.btnReadLightingMode = new System.Windows.Forms.Button();
            this.lblPct2 = new System.Windows.Forms.Label();
            this.lblLightingMode = new System.Windows.Forms.Label();
            this.nudBright = new System.Windows.Forms.NumericUpDown();
            this.lblPct1 = new System.Windows.Forms.Label();
            this.cbLightingMode = new System.Windows.Forms.ComboBox();
            this.nudDimmed = new System.Windows.Forms.NumericUpDown();
            this.lblDimmed = new System.Windows.Forms.Label();
            this.lblStandby = new System.Windows.Forms.Label();
            this.lblBright = new System.Windows.Forms.Label();
            this.gbAdvancedControls = new System.Windows.Forms.GroupBox();
            this.lblOptimizeDescription = new System.Windows.Forms.Label();
            this.gbXS = new System.Windows.Forms.GroupBox();
            this.pbXS_ASY = new System.Windows.Forms.Panel();
            this.pbXS_KYE = new System.Windows.Forms.Panel();
            this.pbXS_ACK = new System.Windows.Forms.Panel();
            this.pbXS_IRE = new System.Windows.Forms.Panel();
            this.pbXS_CRE = new System.Windows.Forms.Panel();
            this.pbXS_KYD = new System.Windows.Forms.Panel();
            this.pbXS_ECO = new System.Windows.Forms.Panel();
            this.pbXS_IRS = new System.Windows.Forms.Panel();
            this.pbXS_CSE = new System.Windows.Forms.Panel();
            this.pbXS_AUT = new System.Windows.Forms.Panel();
            this.pbXS_CHM = new System.Windows.Forms.Panel();
            this.pbXS_IRJ = new System.Windows.Forms.Panel();
            this.pbXS_SET = new System.Windows.Forms.Panel();
            this.pbXS_VMU = new System.Windows.Forms.Panel();
            this.pbXS_CHS = new System.Windows.Forms.Panel();
            this.pbXS_AMU = new System.Windows.Forms.Panel();
            this.lblASY = new System.Windows.Forms.Label();
            this.lblACK = new System.Windows.Forms.Label();
            this.lblECO = new System.Windows.Forms.Label();
            this.lblCHM = new System.Windows.Forms.Label();
            this.lblCRE = new System.Windows.Forms.Label();
            this.lblCSE = new System.Windows.Forms.Label();
            this.lblSET = new System.Windows.Forms.Label();
            this.lblCHS = new System.Windows.Forms.Label();
            this.lblKYE = new System.Windows.Forms.Label();
            this.btnReadControlSettings = new System.Windows.Forms.Button();
            this.lblIRE = new System.Windows.Forms.Label();
            this.lblClickToToggleXS = new System.Windows.Forms.Label();
            this.lblIRS = new System.Windows.Forms.Label();
            this.lblAMU = new System.Windows.Forms.Label();
            this.lblIRJ = new System.Windows.Forms.Label();
            this.lblVMU = new System.Windows.Forms.Label();
            this.lblKYD = new System.Windows.Forms.Label();
            this.lblAUT = new System.Windows.Forms.Label();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.gbTransmitChanged = new System.Windows.Forms.GroupBox();
            this.lblClickToToggleXE = new System.Windows.Forms.Label();
            this.lblKYE2 = new System.Windows.Forms.Label();
            this.lblCTL = new System.Windows.Forms.Label();
            this.lblLMI = new System.Windows.Forms.Label();
            this.lblIRR = new System.Windows.Forms.Label();
            this.lblKEY = new System.Windows.Forms.Label();
            this.lblQDZ = new System.Windows.Forms.Label();
            this.lblQMZ = new System.Windows.Forms.Label();
            this.lblQSZ = new System.Windows.Forms.Label();
            this.lblPWR = new System.Windows.Forms.Label();
            this.pbXE_CTL = new System.Windows.Forms.Panel();
            this.pbXE_LMI = new System.Windows.Forms.Panel();
            this.pbXE_QDZ = new System.Windows.Forms.Panel();
            this.pbXE_IRR = new System.Windows.Forms.Panel();
            this.pbXE_QMZ = new System.Windows.Forms.Panel();
            this.pbXE_KEY = new System.Windows.Forms.Panel();
            this.pbXE_QSZ = new System.Windows.Forms.Panel();
            this.pbXE_KYE = new System.Windows.Forms.Panel();
            this.pbXE_PWR = new System.Windows.Forms.Panel();
            this.btnReadTransmitEnableSettings = new System.Windows.Forms.Button();
            this.tpKeyControl = new System.Windows.Forms.TabPage();
            this.tableKeys = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKeyControlTop = new System.Windows.Forms.Panel();
            this.dgvKeyEmulation = new System.Windows.Forms.DataGridView();
            this.dgvcKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvcRelease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblKeyPressEmulate = new System.Windows.Forms.Label();
            this.lblKeyEmulationDescription = new System.Windows.Forms.Label();
            this.pnlKeyControlBottom = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbMirrored_KYD = new System.Windows.Forms.Panel();
            this.pbMirrored_KYE = new System.Windows.Forms.Panel();
            this.btnReadKeysEnabled = new System.Windows.Forms.Button();
            this.lblKeyEnablingDescription = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvKeyEnabling = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcKeyIsEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcKeyEnable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvcKeyDisable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvcKeyEnableToggle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fctbLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.split = new System.Windows.Forms.SplitContainer();
            this.menu.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tpMainConfig.SuspendLayout();
            this.gbMasterVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMasterVolume)).BeginInit();
            this.gbPowerConfig.SuspendLayout();
            this.gbZones.SuspendLayout();
            this.flowLayoutZones.SuspendLayout();
            this.gbAudioMode.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.gbDeviceStatus.SuspendLayout();
            this.gbLedIntensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDimmed)).BeginInit();
            this.gbAdvancedControls.SuspendLayout();
            this.gbXS.SuspendLayout();
            this.gbTransmitChanged.SuspendLayout();
            this.tpKeyControl.SuspendLayout();
            this.tableKeys.SuspendLayout();
            this.pnlKeyControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyEmulation)).BeginInit();
            this.pnlKeyControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyEnabling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1013, 24);
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
            this.tabs.Controls.Add(this.tpMainConfig);
            this.tabs.Controls.Add(this.tpAVControl);
            this.tabs.Controls.Add(this.tpAdvanced);
            this.tabs.Controls.Add(this.tpKeyControl);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1013, 501);
            this.tabs.TabIndex = 4;
            // 
            // tpMainConfig
            // 
            this.tpMainConfig.Controls.Add(this.gbMasterVolume);
            this.tpMainConfig.Controls.Add(this.gbPowerConfig);
            this.tpMainConfig.Controls.Add(this.gbZones);
            this.tpMainConfig.Controls.Add(this.gbAudioMode);
            this.tpMainConfig.Location = new System.Drawing.Point(4, 22);
            this.tpMainConfig.Name = "tpMainConfig";
            this.tpMainConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainConfig.Size = new System.Drawing.Size(1005, 475);
            this.tpMainConfig.TabIndex = 0;
            this.tpMainConfig.Text = "Main configuration";
            this.tpMainConfig.UseVisualStyleBackColor = true;
            // 
            // gbMasterVolume
            // 
            this.gbMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMasterVolume.Controls.Add(this.lblVolumeLevelVal);
            this.gbMasterVolume.Controls.Add(this.btnReadMasterVolume);
            this.gbMasterVolume.Controls.Add(this.btnChangeMasterVolume);
            this.gbMasterVolume.Controls.Add(this.tkbMasterVolume);
            this.gbMasterVolume.Controls.Add(this.lblVolumeLevel);
            this.gbMasterVolume.Location = new System.Drawing.Point(415, 19);
            this.gbMasterVolume.Name = "gbMasterVolume";
            this.gbMasterVolume.Size = new System.Drawing.Size(320, 82);
            this.gbMasterVolume.TabIndex = 21;
            this.gbMasterVolume.TabStop = false;
            this.gbMasterVolume.Text = "Master volume";
            // 
            // lblVolumeLevelVal
            // 
            this.lblVolumeLevelVal.AutoSize = true;
            this.lblVolumeLevelVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeLevelVal.Location = new System.Drawing.Point(199, 11);
            this.lblVolumeLevelVal.Name = "lblVolumeLevelVal";
            this.lblVolumeLevelVal.Size = new System.Drawing.Size(58, 13);
            this.lblVolumeLevelVal.TabIndex = 22;
            this.lblVolumeLevelVal.Text = "unknown";
            // 
            // btnReadMasterVolume
            // 
            this.btnReadMasterVolume.Location = new System.Drawing.Point(15, 27);
            this.btnReadMasterVolume.Name = "btnReadMasterVolume";
            this.btnReadMasterVolume.Size = new System.Drawing.Size(75, 23);
            this.btnReadMasterVolume.TabIndex = 15;
            this.btnReadMasterVolume.Text = "Read";
            this.btnReadMasterVolume.UseVisualStyleBackColor = true;
            this.btnReadMasterVolume.Click += new System.EventHandler(this.btnReadMasterVolume_Click);
            // 
            // btnChangeMasterVolume
            // 
            this.btnChangeMasterVolume.Location = new System.Drawing.Point(15, 52);
            this.btnChangeMasterVolume.Name = "btnChangeMasterVolume";
            this.btnChangeMasterVolume.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMasterVolume.TabIndex = 14;
            this.btnChangeMasterVolume.Text = "Change";
            this.btnChangeMasterVolume.UseVisualStyleBackColor = true;
            this.btnChangeMasterVolume.Click += new System.EventHandler(this.btnChangeMasterVolume_Click);
            // 
            // tkbMasterVolume
            // 
            this.tkbMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tkbMasterVolume.Location = new System.Drawing.Point(115, 30);
            this.tkbMasterVolume.Maximum = 200;
            this.tkbMasterVolume.Name = "tkbMasterVolume";
            this.tkbMasterVolume.Size = new System.Drawing.Size(199, 45);
            this.tkbMasterVolume.TabIndex = 0;
            this.tkbMasterVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbMasterVolume.Scroll += new System.EventHandler(this.tkbMasterVolume_Scroll);
            // 
            // lblVolumeLevel
            // 
            this.lblVolumeLevel.AutoSize = true;
            this.lblVolumeLevel.Location = new System.Drawing.Point(123, 11);
            this.lblVolumeLevel.Name = "lblVolumeLevel";
            this.lblVolumeLevel.Size = new System.Drawing.Size(70, 13);
            this.lblVolumeLevel.TabIndex = 15;
            this.lblVolumeLevel.Text = "Volume level:";
            // 
            // gbPowerConfig
            // 
            this.gbPowerConfig.Controls.Add(this.lblConnectionStateVal);
            this.gbPowerConfig.Controls.Add(this.btnSetup);
            this.gbPowerConfig.Controls.Add(this.btnDisconnect);
            this.gbPowerConfig.Controls.Add(this.btnConnect);
            this.gbPowerConfig.Controls.Add(this.label2);
            this.gbPowerConfig.Controls.Add(this.lblPowerStateVal);
            this.gbPowerConfig.Controls.Add(this.lblPowerState);
            this.gbPowerConfig.Controls.Add(this.btnPowerToggle);
            this.gbPowerConfig.Controls.Add(this.btnPowerOff);
            this.gbPowerConfig.Controls.Add(this.btnPowerOn);
            this.gbPowerConfig.Location = new System.Drawing.Point(17, 19);
            this.gbPowerConfig.Name = "gbPowerConfig";
            this.gbPowerConfig.Size = new System.Drawing.Size(374, 82);
            this.gbPowerConfig.TabIndex = 2;
            this.gbPowerConfig.TabStop = false;
            this.gbPowerConfig.Text = "Power config";
            // 
            // lblConnectionStateVal
            // 
            this.lblConnectionStateVal.AutoSize = true;
            this.lblConnectionStateVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStateVal.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStateVal.Location = new System.Drawing.Point(75, 27);
            this.lblConnectionStateVal.Name = "lblConnectionStateVal";
            this.lblConnectionStateVal.Size = new System.Drawing.Size(21, 13);
            this.lblConnectionStateVal.TabIndex = 25;
            this.lblConnectionStateVal.Text = "no";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(293, 20);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 24;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(212, 20);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(131, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Connected:";
            // 
            // lblPowerStateVal
            // 
            this.lblPowerStateVal.AutoSize = true;
            this.lblPowerStateVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerStateVal.Location = new System.Drawing.Point(54, 54);
            this.lblPowerStateVal.Name = "lblPowerStateVal";
            this.lblPowerStateVal.Size = new System.Drawing.Size(58, 13);
            this.lblPowerStateVal.TabIndex = 20;
            this.lblPowerStateVal.Text = "unknown";
            // 
            // lblPowerState
            // 
            this.lblPowerState.AutoSize = true;
            this.lblPowerState.Location = new System.Drawing.Point(14, 54);
            this.lblPowerState.Name = "lblPowerState";
            this.lblPowerState.Size = new System.Drawing.Size(40, 13);
            this.lblPowerState.TabIndex = 19;
            this.lblPowerState.Text = "Power:";
            // 
            // btnPowerToggle
            // 
            this.btnPowerToggle.Location = new System.Drawing.Point(293, 49);
            this.btnPowerToggle.Name = "btnPowerToggle";
            this.btnPowerToggle.Size = new System.Drawing.Size(75, 23);
            this.btnPowerToggle.TabIndex = 18;
            this.btnPowerToggle.Text = "Toggle";
            this.btnPowerToggle.UseVisualStyleBackColor = true;
            this.btnPowerToggle.Click += new System.EventHandler(this.btnPowerToggle_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(212, 49);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(75, 23);
            this.btnPowerOff.TabIndex = 17;
            this.btnPowerOff.Text = "Power off";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(131, 49);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(75, 23);
            this.btnPowerOn.TabIndex = 16;
            this.btnPowerOn.Text = "Power on";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // gbZones
            // 
            this.gbZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZones.Controls.Add(this.flowLayoutZones);
            this.gbZones.Location = new System.Drawing.Point(17, 125);
            this.gbZones.Name = "gbZones";
            this.gbZones.Size = new System.Drawing.Size(980, 332);
            this.gbZones.TabIndex = 1;
            this.gbZones.TabStop = false;
            this.gbZones.Text = "Zone I/O";
            // 
            // flowLayoutZones
            // 
            this.flowLayoutZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutZones.Controls.Add(this.label1);
            this.flowLayoutZones.Location = new System.Drawing.Point(22, 18);
            this.flowLayoutZones.Name = "flowLayoutZones";
            this.flowLayoutZones.Size = new System.Drawing.Size(942, 300);
            this.flowLayoutZones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 145);
            this.label1.TabIndex = 24;
            this.label1.Text = "Device capabilities unknown. Connect first.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAudioMode
            // 
            this.gbAudioMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAudioMode.Controls.Add(this.btnReadAudioMode);
            this.gbAudioMode.Controls.Add(this.btnChangeAudioMode);
            this.gbAudioMode.Controls.Add(this.rbAudioModeClassic);
            this.gbAudioMode.Controls.Add(this.rbAudioModeAutoConvert);
            this.gbAudioMode.Location = new System.Drawing.Point(747, 19);
            this.gbAudioMode.Name = "gbAudioMode";
            this.gbAudioMode.Size = new System.Drawing.Size(250, 82);
            this.gbAudioMode.TabIndex = 14;
            this.gbAudioMode.TabStop = false;
            this.gbAudioMode.Text = "Audio mode";
            // 
            // btnReadAudioMode
            // 
            this.btnReadAudioMode.Location = new System.Drawing.Point(18, 27);
            this.btnReadAudioMode.Name = "btnReadAudioMode";
            this.btnReadAudioMode.Size = new System.Drawing.Size(75, 23);
            this.btnReadAudioMode.TabIndex = 15;
            this.btnReadAudioMode.Text = "Read";
            this.btnReadAudioMode.UseVisualStyleBackColor = true;
            this.btnReadAudioMode.Click += new System.EventHandler(this.btnReadAudioMode_Click);
            // 
            // btnChangeAudioMode
            // 
            this.btnChangeAudioMode.Location = new System.Drawing.Point(18, 52);
            this.btnChangeAudioMode.Name = "btnChangeAudioMode";
            this.btnChangeAudioMode.Size = new System.Drawing.Size(75, 23);
            this.btnChangeAudioMode.TabIndex = 14;
            this.btnChangeAudioMode.Text = "Change";
            this.btnChangeAudioMode.UseVisualStyleBackColor = true;
            this.btnChangeAudioMode.Click += new System.EventHandler(this.btnChangeAudioMode_Click);
            // 
            // rbAudioModeClassic
            // 
            this.rbAudioModeClassic.AutoSize = true;
            this.rbAudioModeClassic.Location = new System.Drawing.Point(112, 55);
            this.rbAudioModeClassic.Name = "rbAudioModeClassic";
            this.rbAudioModeClassic.Size = new System.Drawing.Size(87, 17);
            this.rbAudioModeClassic.TabIndex = 13;
            this.rbAudioModeClassic.TabStop = true;
            this.rbAudioModeClassic.Text = "Classic mode";
            this.tooltip.SetToolTip(this.rbAudioModeClassic, resources.GetString("rbAudioModeClassic.ToolTip"));
            this.rbAudioModeClassic.UseVisualStyleBackColor = true;
            // 
            // rbAudioModeAutoConvert
            // 
            this.rbAudioModeAutoConvert.AutoSize = true;
            this.rbAudioModeAutoConvert.Location = new System.Drawing.Point(112, 30);
            this.rbAudioModeAutoConvert.Name = "rbAudioModeAutoConvert";
            this.rbAudioModeAutoConvert.Size = new System.Drawing.Size(127, 17);
            this.rbAudioModeAutoConvert.TabIndex = 12;
            this.rbAudioModeAutoConvert.TabStop = true;
            this.rbAudioModeAutoConvert.Text = "Automatic conversion";
            this.tooltip.SetToolTip(this.rbAudioModeAutoConvert, resources.GetString("rbAudioModeAutoConvert.ToolTip"));
            this.rbAudioModeAutoConvert.UseVisualStyleBackColor = true;
            // 
            // tpAVControl
            // 
            this.tpAVControl.Location = new System.Drawing.Point(4, 22);
            this.tpAVControl.Name = "tpAVControl";
            this.tpAVControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpAVControl.Size = new System.Drawing.Size(1005, 475);
            this.tpAVControl.TabIndex = 1;
            this.tpAVControl.Text = "A/V controls";
            this.tpAVControl.UseVisualStyleBackColor = true;
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.Controls.Add(this.gbDeviceStatus);
            this.tpAdvanced.Controls.Add(this.gbLedIntensity);
            this.tpAdvanced.Controls.Add(this.gbAdvancedControls);
            this.tpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(1005, 475);
            this.tpAdvanced.TabIndex = 2;
            this.tpAdvanced.Text = "Advanced";
            this.tpAdvanced.UseVisualStyleBackColor = true;
            // 
            // gbDeviceStatus
            // 
            this.gbDeviceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeviceStatus.Controls.Add(this.btnReadCapabilities);
            this.gbDeviceStatus.Controls.Add(this.tbCapabilities);
            this.gbDeviceStatus.Controls.Add(this.lblCapabilities);
            this.gbDeviceStatus.Controls.Add(this.tbIpAddress);
            this.gbDeviceStatus.Controls.Add(this.lblVersionInfo);
            this.gbDeviceStatus.Controls.Add(this.btnReadErrorCode);
            this.gbDeviceStatus.Controls.Add(this.tbFirmwareVersion);
            this.gbDeviceStatus.Controls.Add(this.btnReadFirmware);
            this.gbDeviceStatus.Controls.Add(this.lblIpAddress);
            this.gbDeviceStatus.Controls.Add(this.btnReadIP);
            this.gbDeviceStatus.Controls.Add(this.btnChangeIP);
            this.gbDeviceStatus.Controls.Add(this.tbLastErrorCode);
            this.gbDeviceStatus.Controls.Add(this.lblLastError);
            this.gbDeviceStatus.Location = new System.Drawing.Point(17, 15);
            this.gbDeviceStatus.Name = "gbDeviceStatus";
            this.gbDeviceStatus.Size = new System.Drawing.Size(974, 123);
            this.gbDeviceStatus.TabIndex = 14;
            this.gbDeviceStatus.TabStop = false;
            this.gbDeviceStatus.Text = "Device status";
            // 
            // btnReadCapabilities
            // 
            this.btnReadCapabilities.Location = new System.Drawing.Point(444, 93);
            this.btnReadCapabilities.Name = "btnReadCapabilities";
            this.btnReadCapabilities.Size = new System.Drawing.Size(75, 23);
            this.btnReadCapabilities.TabIndex = 11;
            this.btnReadCapabilities.Text = "Read";
            this.btnReadCapabilities.UseVisualStyleBackColor = true;
            this.btnReadCapabilities.Click += new System.EventHandler(this.btnReadCapabilities_Click);
            // 
            // tbCapabilities
            // 
            this.tbCapabilities.Location = new System.Drawing.Point(139, 95);
            this.tbCapabilities.Name = "tbCapabilities";
            this.tbCapabilities.Size = new System.Drawing.Size(295, 20);
            this.tbCapabilities.TabIndex = 10;
            // 
            // lblCapabilities
            // 
            this.lblCapabilities.AutoSize = true;
            this.lblCapabilities.Location = new System.Drawing.Point(25, 98);
            this.lblCapabilities.Name = "lblCapabilities";
            this.lblCapabilities.Size = new System.Drawing.Size(60, 13);
            this.lblCapabilities.TabIndex = 9;
            this.lblCapabilities.Text = "Capabilities";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(139, 17);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(295, 20);
            this.tbIpAddress.TabIndex = 3;
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.Location = new System.Drawing.Point(25, 46);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(62, 13);
            this.lblVersionInfo.TabIndex = 0;
            this.lblVersionInfo.Text = "Version info";
            // 
            // btnReadErrorCode
            // 
            this.btnReadErrorCode.Location = new System.Drawing.Point(444, 67);
            this.btnReadErrorCode.Name = "btnReadErrorCode";
            this.btnReadErrorCode.Size = new System.Drawing.Size(75, 23);
            this.btnReadErrorCode.TabIndex = 8;
            this.btnReadErrorCode.Text = "Read";
            this.btnReadErrorCode.UseVisualStyleBackColor = true;
            this.btnReadErrorCode.Click += new System.EventHandler(this.btnReadErrorCode_Click);
            // 
            // tbFirmwareVersion
            // 
            this.tbFirmwareVersion.Location = new System.Drawing.Point(139, 43);
            this.tbFirmwareVersion.Name = "tbFirmwareVersion";
            this.tbFirmwareVersion.Size = new System.Drawing.Size(295, 20);
            this.tbFirmwareVersion.TabIndex = 1;
            // 
            // btnReadFirmware
            // 
            this.btnReadFirmware.Location = new System.Drawing.Point(444, 41);
            this.btnReadFirmware.Name = "btnReadFirmware";
            this.btnReadFirmware.Size = new System.Drawing.Size(75, 23);
            this.btnReadFirmware.TabIndex = 7;
            this.btnReadFirmware.Text = "Read";
            this.btnReadFirmware.UseVisualStyleBackColor = true;
            this.btnReadFirmware.Click += new System.EventHandler(this.btnReadFirmware_Click);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(25, 20);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblIpAddress.TabIndex = 2;
            this.lblIpAddress.Text = "IP address";
            // 
            // btnReadIP
            // 
            this.btnReadIP.Location = new System.Drawing.Point(444, 15);
            this.btnReadIP.Name = "btnReadIP";
            this.btnReadIP.Size = new System.Drawing.Size(75, 23);
            this.btnReadIP.TabIndex = 6;
            this.btnReadIP.Text = "Read";
            this.btnReadIP.UseVisualStyleBackColor = true;
            this.btnReadIP.Click += new System.EventHandler(this.btnReadIP_Click);
            // 
            // btnChangeIP
            // 
            this.btnChangeIP.Location = new System.Drawing.Point(525, 15);
            this.btnChangeIP.Name = "btnChangeIP";
            this.btnChangeIP.Size = new System.Drawing.Size(75, 23);
            this.btnChangeIP.TabIndex = 0;
            this.btnChangeIP.Text = "Change";
            this.btnChangeIP.UseVisualStyleBackColor = true;
            this.btnChangeIP.Click += new System.EventHandler(this.btnChangeIP_Click);
            // 
            // tbLastErrorCode
            // 
            this.tbLastErrorCode.Location = new System.Drawing.Point(139, 69);
            this.tbLastErrorCode.Name = "tbLastErrorCode";
            this.tbLastErrorCode.Size = new System.Drawing.Size(295, 20);
            this.tbLastErrorCode.TabIndex = 5;
            // 
            // lblLastError
            // 
            this.lblLastError.AutoSize = true;
            this.lblLastError.Location = new System.Drawing.Point(25, 72);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(78, 13);
            this.lblLastError.TabIndex = 4;
            this.lblLastError.Text = "Last error code";
            // 
            // gbLedIntensity
            // 
            this.gbLedIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLedIntensity.Controls.Add(this.lblPct3);
            this.gbLedIntensity.Controls.Add(this.btnChangeLightingMode);
            this.gbLedIntensity.Controls.Add(this.nudStandby);
            this.gbLedIntensity.Controls.Add(this.btnReadLightingMode);
            this.gbLedIntensity.Controls.Add(this.lblPct2);
            this.gbLedIntensity.Controls.Add(this.lblLightingMode);
            this.gbLedIntensity.Controls.Add(this.nudBright);
            this.gbLedIntensity.Controls.Add(this.lblPct1);
            this.gbLedIntensity.Controls.Add(this.cbLightingMode);
            this.gbLedIntensity.Controls.Add(this.nudDimmed);
            this.gbLedIntensity.Controls.Add(this.lblDimmed);
            this.gbLedIntensity.Controls.Add(this.lblStandby);
            this.gbLedIntensity.Controls.Add(this.lblBright);
            this.gbLedIntensity.Location = new System.Drawing.Point(17, 148);
            this.gbLedIntensity.Name = "gbLedIntensity";
            this.gbLedIntensity.Size = new System.Drawing.Size(974, 55);
            this.gbLedIntensity.TabIndex = 2;
            this.gbLedIntensity.TabStop = false;
            this.gbLedIntensity.Text = "Front panel leds";
            // 
            // lblPct3
            // 
            this.lblPct3.AutoSize = true;
            this.lblPct3.Location = new System.Drawing.Point(824, 30);
            this.lblPct3.Name = "lblPct3";
            this.lblPct3.Size = new System.Drawing.Size(15, 13);
            this.lblPct3.TabIndex = 16;
            this.lblPct3.Text = "%";
            // 
            // btnChangeLightingMode
            // 
            this.btnChangeLightingMode.Location = new System.Drawing.Point(132, 24);
            this.btnChangeLightingMode.Name = "btnChangeLightingMode";
            this.btnChangeLightingMode.Size = new System.Drawing.Size(91, 23);
            this.btnChangeLightingMode.TabIndex = 12;
            this.btnChangeLightingMode.Text = "Change";
            this.btnChangeLightingMode.UseVisualStyleBackColor = true;
            this.btnChangeLightingMode.Click += new System.EventHandler(this.btnChangeLightingMode_Click);
            // 
            // nudStandby
            // 
            this.nudStandby.Location = new System.Drawing.Point(765, 27);
            this.nudStandby.Name = "nudStandby";
            this.nudStandby.Size = new System.Drawing.Size(57, 20);
            this.nudStandby.TabIndex = 2;
            // 
            // btnReadLightingMode
            // 
            this.btnReadLightingMode.Location = new System.Drawing.Point(41, 24);
            this.btnReadLightingMode.Name = "btnReadLightingMode";
            this.btnReadLightingMode.Size = new System.Drawing.Size(85, 23);
            this.btnReadLightingMode.TabIndex = 11;
            this.btnReadLightingMode.Text = "Read config";
            this.btnReadLightingMode.UseVisualStyleBackColor = true;
            this.btnReadLightingMode.Click += new System.EventHandler(this.btnReadLightingMode_Click);
            // 
            // lblPct2
            // 
            this.lblPct2.AutoSize = true;
            this.lblPct2.Location = new System.Drawing.Point(686, 30);
            this.lblPct2.Name = "lblPct2";
            this.lblPct2.Size = new System.Drawing.Size(15, 13);
            this.lblPct2.TabIndex = 15;
            this.lblPct2.Text = "%";
            // 
            // lblLightingMode
            // 
            this.lblLightingMode.AutoSize = true;
            this.lblLightingMode.Location = new System.Drawing.Point(254, 30);
            this.lblLightingMode.Name = "lblLightingMode";
            this.lblLightingMode.Size = new System.Drawing.Size(73, 13);
            this.lblLightingMode.TabIndex = 10;
            this.lblLightingMode.Text = "Lighting mode";
            // 
            // nudBright
            // 
            this.nudBright.Location = new System.Drawing.Point(490, 27);
            this.nudBright.Name = "nudBright";
            this.nudBright.Size = new System.Drawing.Size(57, 20);
            this.nudBright.TabIndex = 0;
            this.tooltip.SetToolTip(this.nudBright, "Front panel LED brightness in \'Bright\' mode");
            // 
            // lblPct1
            // 
            this.lblPct1.AutoSize = true;
            this.lblPct1.Location = new System.Drawing.Point(549, 30);
            this.lblPct1.Name = "lblPct1";
            this.lblPct1.Size = new System.Drawing.Size(15, 13);
            this.lblPct1.TabIndex = 14;
            this.lblPct1.Text = "%";
            // 
            // cbLightingMode
            // 
            this.cbLightingMode.FormattingEnabled = true;
            this.cbLightingMode.Location = new System.Drawing.Point(330, 26);
            this.cbLightingMode.Name = "cbLightingMode";
            this.cbLightingMode.Size = new System.Drawing.Size(90, 21);
            this.cbLightingMode.TabIndex = 0;
            // 
            // nudDimmed
            // 
            this.nudDimmed.Location = new System.Drawing.Point(626, 27);
            this.nudDimmed.Name = "nudDimmed";
            this.nudDimmed.Size = new System.Drawing.Size(57, 20);
            this.nudDimmed.TabIndex = 1;
            this.tooltip.SetToolTip(this.nudDimmed, "Front panel LED brightness in \'Dimmed\' mode");
            // 
            // lblDimmed
            // 
            this.lblDimmed.AutoSize = true;
            this.lblDimmed.Location = new System.Drawing.Point(579, 30);
            this.lblDimmed.Name = "lblDimmed";
            this.lblDimmed.Size = new System.Drawing.Size(45, 13);
            this.lblDimmed.TabIndex = 10;
            this.lblDimmed.Text = "Dimmed";
            // 
            // lblStandby
            // 
            this.lblStandby.AutoSize = true;
            this.lblStandby.Location = new System.Drawing.Point(715, 30);
            this.lblStandby.Name = "lblStandby";
            this.lblStandby.Size = new System.Drawing.Size(46, 13);
            this.lblStandby.TabIndex = 11;
            this.lblStandby.Text = "Standby";
            this.tooltip.SetToolTip(this.lblStandby, "Front panel LED brightness in \'Standby\' mode");
            // 
            // lblBright
            // 
            this.lblBright.AutoSize = true;
            this.lblBright.Location = new System.Drawing.Point(453, 30);
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(34, 13);
            this.lblBright.TabIndex = 9;
            this.lblBright.Text = "Bright";
            // 
            // gbAdvancedControls
            // 
            this.gbAdvancedControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdvancedControls.Controls.Add(this.lblOptimizeDescription);
            this.gbAdvancedControls.Controls.Add(this.gbXS);
            this.gbAdvancedControls.Controls.Add(this.btnOptimize);
            this.gbAdvancedControls.Controls.Add(this.gbTransmitChanged);
            this.gbAdvancedControls.Location = new System.Drawing.Point(17, 211);
            this.gbAdvancedControls.Name = "gbAdvancedControls";
            this.gbAdvancedControls.Size = new System.Drawing.Size(974, 255);
            this.gbAdvancedControls.TabIndex = 59;
            this.gbAdvancedControls.TabStop = false;
            this.gbAdvancedControls.Text = "Advanced controls";
            // 
            // lblOptimizeDescription
            // 
            this.lblOptimizeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptimizeDescription.Location = new System.Drawing.Point(150, 24);
            this.lblOptimizeDescription.Name = "lblOptimizeDescription";
            this.lblOptimizeDescription.Size = new System.Drawing.Size(390, 33);
            this.lblOptimizeDescription.TabIndex = 57;
            this.lblOptimizeDescription.Text = "Clicking this button will select the most suitable settings for this program: asy" +
    "nchronous mode, change notifications for all updates, with checksums.";
            // 
            // gbXS
            // 
            this.gbXS.Controls.Add(this.pbXS_ASY);
            this.gbXS.Controls.Add(this.pbXS_KYE);
            this.gbXS.Controls.Add(this.pbXS_ACK);
            this.gbXS.Controls.Add(this.pbXS_IRE);
            this.gbXS.Controls.Add(this.pbXS_CRE);
            this.gbXS.Controls.Add(this.pbXS_KYD);
            this.gbXS.Controls.Add(this.pbXS_ECO);
            this.gbXS.Controls.Add(this.pbXS_IRS);
            this.gbXS.Controls.Add(this.pbXS_CSE);
            this.gbXS.Controls.Add(this.pbXS_AUT);
            this.gbXS.Controls.Add(this.pbXS_CHM);
            this.gbXS.Controls.Add(this.pbXS_IRJ);
            this.gbXS.Controls.Add(this.pbXS_SET);
            this.gbXS.Controls.Add(this.pbXS_VMU);
            this.gbXS.Controls.Add(this.pbXS_CHS);
            this.gbXS.Controls.Add(this.pbXS_AMU);
            this.gbXS.Controls.Add(this.lblASY);
            this.gbXS.Controls.Add(this.lblACK);
            this.gbXS.Controls.Add(this.lblECO);
            this.gbXS.Controls.Add(this.lblCHM);
            this.gbXS.Controls.Add(this.lblCRE);
            this.gbXS.Controls.Add(this.lblCSE);
            this.gbXS.Controls.Add(this.lblSET);
            this.gbXS.Controls.Add(this.lblCHS);
            this.gbXS.Controls.Add(this.lblKYE);
            this.gbXS.Controls.Add(this.btnReadControlSettings);
            this.gbXS.Controls.Add(this.lblIRE);
            this.gbXS.Controls.Add(this.lblClickToToggleXS);
            this.gbXS.Controls.Add(this.lblIRS);
            this.gbXS.Controls.Add(this.lblAMU);
            this.gbXS.Controls.Add(this.lblIRJ);
            this.gbXS.Controls.Add(this.lblVMU);
            this.gbXS.Controls.Add(this.lblKYD);
            this.gbXS.Controls.Add(this.lblAUT);
            this.gbXS.Location = new System.Drawing.Point(27, 65);
            this.gbXS.Name = "gbXS";
            this.gbXS.Size = new System.Drawing.Size(742, 85);
            this.gbXS.TabIndex = 58;
            this.gbXS.TabStop = false;
            this.gbXS.Text = "Operational modes";
            // 
            // pbXS_ASY
            // 
            this.pbXS_ASY.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ASY.Location = new System.Drawing.Point(120, 27);
            this.pbXS_ASY.Name = "pbXS_ASY";
            this.pbXS_ASY.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ASY.TabIndex = 0;
            this.tooltip.SetToolTip(this.pbXS_ASY, "ASY\r\n\r\nOff=Polled mode.\r\nOn=Asynchronous Mode.");
            // 
            // pbXS_KYE
            // 
            this.pbXS_KYE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_KYE.Location = new System.Drawing.Point(424, 27);
            this.pbXS_KYE.Name = "pbXS_KYE";
            this.pbXS_KYE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_KYE.TabIndex = 8;
            this.tooltip.SetToolTip(this.pbXS_KYE, "KYE\r\n\r\nOn=Use ‘KE’ settings for front panels keys.\r\nOff=Enable all front panel ke" +
        "ys regardless of ‘KE’ settings.");
            // 
            // pbXS_ACK
            // 
            this.pbXS_ACK.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ACK.Location = new System.Drawing.Point(158, 27);
            this.pbXS_ACK.Name = "pbXS_ACK";
            this.pbXS_ACK.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ACK.TabIndex = 1;
            this.tooltip.SetToolTip(this.pbXS_ACK, "ACK\n\nOff=Don’t acknowledge cmds with “^+$”\nOn=Acknowledge error free commands wit" +
        "h a “^+$”");
            // 
            // pbXS_IRE
            // 
            this.pbXS_IRE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRE.Location = new System.Drawing.Point(462, 27);
            this.pbXS_IRE.Name = "pbXS_IRE";
            this.pbXS_IRE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRE.TabIndex = 9;
            this.tooltip.SetToolTip(this.pbXS_IRE, "IRE\n\nOff=Use ‘IRE’ settings for IR control.\nOn=Enable all IR commands, overrides " +
        "‘IRE’ settings.");
            // 
            // pbXS_CRE
            // 
            this.pbXS_CRE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CRE.Location = new System.Drawing.Point(272, 27);
            this.pbXS_CRE.Name = "pbXS_CRE";
            this.pbXS_CRE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CRE.TabIndex = 4;
            this.tooltip.SetToolTip(this.pbXS_CRE, "CRE\n\nOff=Don’t send CRs/LFs at end of responses\nOn=End all responses with a carri" +
        "age return and a line feed.");
            // 
            // pbXS_KYD
            // 
            this.pbXS_KYD.BackColor = System.Drawing.Color.Silver;
            this.pbXS_KYD.Location = new System.Drawing.Point(576, 27);
            this.pbXS_KYD.Name = "pbXS_KYD";
            this.pbXS_KYD.Size = new System.Drawing.Size(32, 32);
            this.pbXS_KYD.TabIndex = 12;
            this.tooltip.SetToolTip(this.pbXS_KYD, "KYD - Key disable\r\n\r\nOn=Disable front panel keys, overrides ‘KYE’.\r\nOff=Enable fr" +
        "ont panel keys (allows ‘KYE’ and ‘KE’ settings).");
            // 
            // pbXS_ECO
            // 
            this.pbXS_ECO.BackColor = System.Drawing.Color.Silver;
            this.pbXS_ECO.Location = new System.Drawing.Point(196, 27);
            this.pbXS_ECO.Name = "pbXS_ECO";
            this.pbXS_ECO.Size = new System.Drawing.Size(32, 32);
            this.pbXS_ECO.TabIndex = 2;
            this.tooltip.SetToolTip(this.pbXS_ECO, "ECO\n\nOff=Do not send a response strings for each cmd.\nOn=Always send response str" +
        "ing when a serial command is issued");
            // 
            // pbXS_IRS
            // 
            this.pbXS_IRS.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRS.Location = new System.Drawing.Point(500, 27);
            this.pbXS_IRS.Name = "pbXS_IRS";
            this.pbXS_IRS.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRS.TabIndex = 10;
            this.tooltip.SetToolTip(this.pbXS_IRS, "IRS\n\nOff=Disable IR sensor.\nOn=Enable IR sensor.");
            // 
            // pbXS_CSE
            // 
            this.pbXS_CSE.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CSE.Location = new System.Drawing.Point(310, 27);
            this.pbXS_CSE.Name = "pbXS_CSE";
            this.pbXS_CSE.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CSE.TabIndex = 5;
            this.tooltip.SetToolTip(this.pbXS_CSE, "CSE\n\nOff=Disable the sending of checksums.\nOn=Append a checksums to all responses" +
        ".");
            // 
            // pbXS_AUT
            // 
            this.pbXS_AUT.BackColor = System.Drawing.Color.Silver;
            this.pbXS_AUT.Location = new System.Drawing.Point(614, 27);
            this.pbXS_AUT.Name = "pbXS_AUT";
            this.pbXS_AUT.Size = new System.Drawing.Size(32, 32);
            this.pbXS_AUT.TabIndex = 13;
            this.tooltip.SetToolTip(this.pbXS_AUT, "AUT\n\nOff=Classic Analog/Digital mode.\nOn=Automatic conversion of Analog/Digital p" +
        "aths.");
            // 
            // pbXS_CHM
            // 
            this.pbXS_CHM.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CHM.Location = new System.Drawing.Point(234, 27);
            this.pbXS_CHM.Name = "pbXS_CHM";
            this.pbXS_CHM.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CHM.TabIndex = 3;
            this.tooltip.SetToolTip(this.pbXS_CHM, "CHM\n\nOff=Only send a “.ch” when needed.\nOn=Always append a “.ch” channel mask to " +
        "a zone response cmd");
            // 
            // pbXS_IRJ
            // 
            this.pbXS_IRJ.BackColor = System.Drawing.Color.Silver;
            this.pbXS_IRJ.Location = new System.Drawing.Point(538, 27);
            this.pbXS_IRJ.Name = "pbXS_IRJ";
            this.pbXS_IRJ.Size = new System.Drawing.Size(32, 32);
            this.pbXS_IRJ.TabIndex = 11;
            this.tooltip.SetToolTip(this.pbXS_IRJ, "IRJ\n\nOff=Disable IR jack.\nOn=Enable IR jack.");
            // 
            // pbXS_SET
            // 
            this.pbXS_SET.BackColor = System.Drawing.Color.Silver;
            this.pbXS_SET.Location = new System.Drawing.Point(348, 27);
            this.pbXS_SET.Name = "pbXS_SET";
            this.pbXS_SET.Size = new System.Drawing.Size(32, 32);
            this.pbXS_SET.TabIndex = 6;
            this.tooltip.SetToolTip(this.pbXS_SET, "SET\n\nOff=Disable the setup option.\nOn=Enable the setup option.");
            // 
            // pbXS_VMU
            // 
            this.pbXS_VMU.BackColor = System.Drawing.Color.Silver;
            this.pbXS_VMU.Location = new System.Drawing.Point(652, 27);
            this.pbXS_VMU.Name = "pbXS_VMU";
            this.pbXS_VMU.Size = new System.Drawing.Size(32, 32);
            this.pbXS_VMU.TabIndex = 14;
            this.tooltip.SetToolTip(this.pbXS_VMU, "VMU\n\nOff=Disable video muting when a zone is muted.\nOn=Enable video muting when a" +
        " zone is muted.");
            // 
            // pbXS_CHS
            // 
            this.pbXS_CHS.BackColor = System.Drawing.Color.Silver;
            this.pbXS_CHS.Location = new System.Drawing.Point(386, 27);
            this.pbXS_CHS.Name = "pbXS_CHS";
            this.pbXS_CHS.Size = new System.Drawing.Size(32, 32);
            this.pbXS_CHS.TabIndex = 7;
            this.tooltip.SetToolTip(this.pbXS_CHS, "CHS\n\nOff=Setup mode is read only.\nOn=Enable changing parameters in the setup mode" +
        ".");
            // 
            // pbXS_AMU
            // 
            this.pbXS_AMU.BackColor = System.Drawing.Color.Silver;
            this.pbXS_AMU.Location = new System.Drawing.Point(690, 27);
            this.pbXS_AMU.Name = "pbXS_AMU";
            this.pbXS_AMU.Size = new System.Drawing.Size(32, 32);
            this.pbXS_AMU.TabIndex = 15;
            this.tooltip.SetToolTip(this.pbXS_AMU, "AMU\n\nOff=Disable audio muting when a zone is muted.\nOn=Enable audio muting when a" +
        " zone is muted.");
            // 
            // lblASY
            // 
            this.lblASY.AutoSize = true;
            this.lblASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASY.Location = new System.Drawing.Point(117, 62);
            this.lblASY.Name = "lblASY";
            this.lblASY.Size = new System.Drawing.Size(38, 16);
            this.lblASY.TabIndex = 16;
            this.lblASY.Text = "ASY";
            this.lblASY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblACK
            // 
            this.lblACK.AutoSize = true;
            this.lblACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACK.Location = new System.Drawing.Point(155, 62);
            this.lblACK.Name = "lblACK";
            this.lblACK.Size = new System.Drawing.Size(37, 16);
            this.lblACK.TabIndex = 17;
            this.lblACK.Text = "ACK";
            this.lblACK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblECO
            // 
            this.lblECO.AutoSize = true;
            this.lblECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECO.Location = new System.Drawing.Point(193, 62);
            this.lblECO.Name = "lblECO";
            this.lblECO.Size = new System.Drawing.Size(39, 16);
            this.lblECO.TabIndex = 18;
            this.lblECO.Text = "ECO";
            this.lblECO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCHM
            // 
            this.lblCHM.AutoSize = true;
            this.lblCHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHM.Location = new System.Drawing.Point(231, 62);
            this.lblCHM.Name = "lblCHM";
            this.lblCHM.Size = new System.Drawing.Size(41, 16);
            this.lblCHM.TabIndex = 19;
            this.lblCHM.Text = "CHM";
            this.lblCHM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCRE
            // 
            this.lblCRE.AutoSize = true;
            this.lblCRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRE.Location = new System.Drawing.Point(269, 62);
            this.lblCRE.Name = "lblCRE";
            this.lblCRE.Size = new System.Drawing.Size(39, 16);
            this.lblCRE.TabIndex = 20;
            this.lblCRE.Text = "CRE";
            this.lblCRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCSE
            // 
            this.lblCSE.AutoSize = true;
            this.lblCSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSE.Location = new System.Drawing.Point(307, 62);
            this.lblCSE.Name = "lblCSE";
            this.lblCSE.Size = new System.Drawing.Size(38, 16);
            this.lblCSE.TabIndex = 21;
            this.lblCSE.Text = "CSE";
            this.lblCSE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSET
            // 
            this.lblSET.AutoSize = true;
            this.lblSET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSET.Location = new System.Drawing.Point(345, 62);
            this.lblSET.Name = "lblSET";
            this.lblSET.Size = new System.Drawing.Size(38, 16);
            this.lblSET.TabIndex = 22;
            this.lblSET.Text = "SET";
            this.lblSET.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCHS
            // 
            this.lblCHS.AutoSize = true;
            this.lblCHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHS.Location = new System.Drawing.Point(383, 62);
            this.lblCHS.Name = "lblCHS";
            this.lblCHS.Size = new System.Drawing.Size(39, 16);
            this.lblCHS.TabIndex = 23;
            this.lblCHS.Text = "CHS";
            this.lblCHS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKYE
            // 
            this.lblKYE.AutoSize = true;
            this.lblKYE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKYE.Location = new System.Drawing.Point(423, 62);
            this.lblKYE.Name = "lblKYE";
            this.lblKYE.Size = new System.Drawing.Size(37, 16);
            this.lblKYE.TabIndex = 24;
            this.lblKYE.Text = "KYE";
            this.lblKYE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReadControlSettings
            // 
            this.btnReadControlSettings.Location = new System.Drawing.Point(13, 36);
            this.btnReadControlSettings.Name = "btnReadControlSettings";
            this.btnReadControlSettings.Size = new System.Drawing.Size(85, 23);
            this.btnReadControlSettings.TabIndex = 33;
            this.btnReadControlSettings.Text = "Read config";
            this.btnReadControlSettings.UseVisualStyleBackColor = true;
            this.btnReadControlSettings.Click += new System.EventHandler(this.btnReadControlSettings_Click);
            // 
            // lblIRE
            // 
            this.lblIRE.AutoSize = true;
            this.lblIRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRE.Location = new System.Drawing.Point(463, 62);
            this.lblIRE.Name = "lblIRE";
            this.lblIRE.Size = new System.Drawing.Size(33, 16);
            this.lblIRE.TabIndex = 25;
            this.lblIRE.Text = "IRE";
            this.lblIRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClickToToggleXS
            // 
            this.lblClickToToggleXS.AutoSize = true;
            this.lblClickToToggleXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToToggleXS.Location = new System.Drawing.Point(134, 11);
            this.lblClickToToggleXS.Name = "lblClickToToggleXS";
            this.lblClickToToggleXS.Size = new System.Drawing.Size(225, 13);
            this.lblClickToToggleXS.TabIndex = 32;
            this.lblClickToToggleXS.Text = "Click box to toggle. Hover over for description.";
            // 
            // lblIRS
            // 
            this.lblIRS.AutoSize = true;
            this.lblIRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRS.Location = new System.Drawing.Point(501, 62);
            this.lblIRS.Name = "lblIRS";
            this.lblIRS.Size = new System.Drawing.Size(33, 16);
            this.lblIRS.TabIndex = 26;
            this.lblIRS.Text = "IRS";
            this.lblIRS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAMU
            // 
            this.lblAMU.AutoSize = true;
            this.lblAMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMU.Location = new System.Drawing.Point(687, 62);
            this.lblAMU.Name = "lblAMU";
            this.lblAMU.Size = new System.Drawing.Size(41, 16);
            this.lblAMU.TabIndex = 31;
            this.lblAMU.Text = "AMU";
            this.lblAMU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIRJ
            // 
            this.lblIRJ.AutoSize = true;
            this.lblIRJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRJ.Location = new System.Drawing.Point(539, 62);
            this.lblIRJ.Name = "lblIRJ";
            this.lblIRJ.Size = new System.Drawing.Size(31, 16);
            this.lblIRJ.TabIndex = 27;
            this.lblIRJ.Text = "IRJ";
            this.lblIRJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVMU
            // 
            this.lblVMU.AutoSize = true;
            this.lblVMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVMU.Location = new System.Drawing.Point(649, 62);
            this.lblVMU.Name = "lblVMU";
            this.lblVMU.Size = new System.Drawing.Size(41, 16);
            this.lblVMU.TabIndex = 30;
            this.lblVMU.Text = "VMU";
            this.lblVMU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKYD
            // 
            this.lblKYD.AutoSize = true;
            this.lblKYD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKYD.Location = new System.Drawing.Point(574, 62);
            this.lblKYD.Name = "lblKYD";
            this.lblKYD.Size = new System.Drawing.Size(38, 16);
            this.lblKYD.TabIndex = 28;
            this.lblKYD.Text = "KYD";
            this.lblKYD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAUT
            // 
            this.lblAUT.AutoSize = true;
            this.lblAUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAUT.Location = new System.Drawing.Point(612, 62);
            this.lblAUT.Name = "lblAUT";
            this.lblAUT.Size = new System.Drawing.Size(39, 16);
            this.lblAUT.TabIndex = 29;
            this.lblAUT.Text = "AUT";
            this.lblAUT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOptimize
            // 
            this.btnOptimize.Location = new System.Drawing.Point(41, 28);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(85, 23);
            this.btnOptimize.TabIndex = 56;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // gbTransmitChanged
            // 
            this.gbTransmitChanged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTransmitChanged.Controls.Add(this.lblClickToToggleXE);
            this.gbTransmitChanged.Controls.Add(this.lblKYE2);
            this.gbTransmitChanged.Controls.Add(this.lblCTL);
            this.gbTransmitChanged.Controls.Add(this.lblLMI);
            this.gbTransmitChanged.Controls.Add(this.lblIRR);
            this.gbTransmitChanged.Controls.Add(this.lblKEY);
            this.gbTransmitChanged.Controls.Add(this.lblQDZ);
            this.gbTransmitChanged.Controls.Add(this.lblQMZ);
            this.gbTransmitChanged.Controls.Add(this.lblQSZ);
            this.gbTransmitChanged.Controls.Add(this.lblPWR);
            this.gbTransmitChanged.Controls.Add(this.pbXE_CTL);
            this.gbTransmitChanged.Controls.Add(this.pbXE_LMI);
            this.gbTransmitChanged.Controls.Add(this.pbXE_QDZ);
            this.gbTransmitChanged.Controls.Add(this.pbXE_IRR);
            this.gbTransmitChanged.Controls.Add(this.pbXE_QMZ);
            this.gbTransmitChanged.Controls.Add(this.pbXE_KEY);
            this.gbTransmitChanged.Controls.Add(this.pbXE_QSZ);
            this.gbTransmitChanged.Controls.Add(this.pbXE_KYE);
            this.gbTransmitChanged.Controls.Add(this.pbXE_PWR);
            this.gbTransmitChanged.Controls.Add(this.btnReadTransmitEnableSettings);
            this.gbTransmitChanged.Location = new System.Drawing.Point(27, 161);
            this.gbTransmitChanged.Name = "gbTransmitChanged";
            this.gbTransmitChanged.Size = new System.Drawing.Size(430, 85);
            this.gbTransmitChanged.TabIndex = 3;
            this.gbTransmitChanged.TabStop = false;
            this.gbTransmitChanged.Text = "Notification of changes";
            // 
            // lblClickToToggleXE
            // 
            this.lblClickToToggleXE.AutoSize = true;
            this.lblClickToToggleXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToToggleXE.Location = new System.Drawing.Point(129, 10);
            this.lblClickToToggleXE.Name = "lblClickToToggleXE";
            this.lblClickToToggleXE.Size = new System.Drawing.Size(225, 13);
            this.lblClickToToggleXE.TabIndex = 55;
            this.lblClickToToggleXE.Text = "Click box to toggle. Hover over for description.";
            // 
            // lblKYE2
            // 
            this.lblKYE2.AutoSize = true;
            this.lblKYE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKYE2.Location = new System.Drawing.Point(416, 61);
            this.lblKYE2.Name = "lblKYE2";
            this.lblKYE2.Size = new System.Drawing.Size(37, 16);
            this.lblKYE2.TabIndex = 54;
            this.lblKYE2.Text = "KYE";
            this.lblKYE2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCTL
            // 
            this.lblCTL.AutoSize = true;
            this.lblCTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTL.Location = new System.Drawing.Point(378, 61);
            this.lblCTL.Name = "lblCTL";
            this.lblCTL.Size = new System.Drawing.Size(36, 16);
            this.lblCTL.TabIndex = 53;
            this.lblCTL.Text = "CTL";
            this.lblCTL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLMI
            // 
            this.lblLMI.AutoSize = true;
            this.lblLMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLMI.Location = new System.Drawing.Point(343, 61);
            this.lblLMI.Name = "lblLMI";
            this.lblLMI.Size = new System.Drawing.Size(32, 16);
            this.lblLMI.TabIndex = 52;
            this.lblLMI.Text = "LMI";
            this.lblLMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIRR
            // 
            this.lblIRR.AutoSize = true;
            this.lblIRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRR.Location = new System.Drawing.Point(305, 61);
            this.lblIRR.Name = "lblIRR";
            this.lblIRR.Size = new System.Drawing.Size(34, 16);
            this.lblIRR.TabIndex = 51;
            this.lblIRR.Text = "IRR";
            this.lblIRR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKEY
            // 
            this.lblKEY.AutoSize = true;
            this.lblKEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKEY.Location = new System.Drawing.Point(264, 61);
            this.lblKEY.Name = "lblKEY";
            this.lblKEY.Size = new System.Drawing.Size(37, 16);
            this.lblKEY.TabIndex = 50;
            this.lblKEY.Text = "KEY";
            this.lblKEY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQDZ
            // 
            this.lblQDZ.AutoSize = true;
            this.lblQDZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQDZ.Location = new System.Drawing.Point(226, 61);
            this.lblQDZ.Name = "lblQDZ";
            this.lblQDZ.Size = new System.Drawing.Size(39, 16);
            this.lblQDZ.TabIndex = 49;
            this.lblQDZ.Text = "QDZ";
            this.lblQDZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQMZ
            // 
            this.lblQMZ.AutoSize = true;
            this.lblQMZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQMZ.Location = new System.Drawing.Point(188, 61);
            this.lblQMZ.Name = "lblQMZ";
            this.lblQMZ.Size = new System.Drawing.Size(40, 16);
            this.lblQMZ.TabIndex = 48;
            this.lblQMZ.Text = "QMZ";
            this.lblQMZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblQSZ
            // 
            this.lblQSZ.AutoSize = true;
            this.lblQSZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQSZ.Location = new System.Drawing.Point(150, 61);
            this.lblQSZ.Name = "lblQSZ";
            this.lblQSZ.Size = new System.Drawing.Size(38, 16);
            this.lblQSZ.TabIndex = 47;
            this.lblQSZ.Text = "QSZ";
            this.lblQSZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPWR
            // 
            this.lblPWR.AutoSize = true;
            this.lblPWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWR.Location = new System.Drawing.Point(112, 61);
            this.lblPWR.Name = "lblPWR";
            this.lblPWR.Size = new System.Drawing.Size(43, 16);
            this.lblPWR.TabIndex = 46;
            this.lblPWR.Text = "PWR";
            this.lblPWR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbXE_CTL
            // 
            this.pbXE_CTL.BackColor = System.Drawing.Color.Silver;
            this.pbXE_CTL.Location = new System.Drawing.Point(381, 26);
            this.pbXE_CTL.Name = "pbXE_CTL";
            this.pbXE_CTL.Size = new System.Drawing.Size(32, 32);
            this.pbXE_CTL.TabIndex = 44;
            this.tooltip.SetToolTip(this.pbXE_CTL, "Send update when control settings have changed.");
            // 
            // pbXE_LMI
            // 
            this.pbXE_LMI.BackColor = System.Drawing.Color.Silver;
            this.pbXE_LMI.Location = new System.Drawing.Point(343, 26);
            this.pbXE_LMI.Name = "pbXE_LMI";
            this.pbXE_LMI.Size = new System.Drawing.Size(32, 32);
            this.pbXE_LMI.TabIndex = 43;
            this.tooltip.SetToolTip(this.pbXE_LMI, "Send update when light mode and / or intensities have changed");
            // 
            // pbXE_QDZ
            // 
            this.pbXE_QDZ.BackColor = System.Drawing.Color.Silver;
            this.pbXE_QDZ.Location = new System.Drawing.Point(229, 26);
            this.pbXE_QDZ.Name = "pbXE_QDZ";
            this.pbXE_QDZ.Size = new System.Drawing.Size(32, 32);
            this.pbXE_QDZ.TabIndex = 40;
            this.tooltip.SetToolTip(this.pbXE_QDZ, "Send update when switching delay settings have changed.");
            // 
            // pbXE_IRR
            // 
            this.pbXE_IRR.BackColor = System.Drawing.Color.Silver;
            this.pbXE_IRR.Location = new System.Drawing.Point(305, 26);
            this.pbXE_IRR.Name = "pbXE_IRR";
            this.pbXE_IRR.Size = new System.Drawing.Size(32, 32);
            this.pbXE_IRR.TabIndex = 42;
            this.tooltip.SetToolTip(this.pbXE_IRR, "Send update when a new IR code has been received");
            // 
            // pbXE_QMZ
            // 
            this.pbXE_QMZ.BackColor = System.Drawing.Color.Silver;
            this.pbXE_QMZ.Location = new System.Drawing.Point(191, 26);
            this.pbXE_QMZ.Name = "pbXE_QMZ";
            this.pbXE_QMZ.Size = new System.Drawing.Size(32, 32);
            this.pbXE_QMZ.TabIndex = 39;
            this.tooltip.SetToolTip(this.pbXE_QMZ, "Send update when mute settings have changed");
            // 
            // pbXE_KEY
            // 
            this.pbXE_KEY.BackColor = System.Drawing.Color.Silver;
            this.pbXE_KEY.Location = new System.Drawing.Point(267, 26);
            this.pbXE_KEY.Name = "pbXE_KEY";
            this.pbXE_KEY.Size = new System.Drawing.Size(32, 32);
            this.pbXE_KEY.TabIndex = 41;
            this.tooltip.SetToolTip(this.pbXE_KEY, "Send update when one or more keys have been pressed.");
            // 
            // pbXE_QSZ
            // 
            this.pbXE_QSZ.BackColor = System.Drawing.Color.Silver;
            this.pbXE_QSZ.Location = new System.Drawing.Point(153, 26);
            this.pbXE_QSZ.Name = "pbXE_QSZ";
            this.pbXE_QSZ.Size = new System.Drawing.Size(32, 32);
            this.pbXE_QSZ.TabIndex = 38;
            this.tooltip.SetToolTip(this.pbXE_QSZ, "Send update when selection (Source / Zone Mapping) has changed");
            // 
            // pbXE_KYE
            // 
            this.pbXE_KYE.BackColor = System.Drawing.Color.Silver;
            this.pbXE_KYE.Location = new System.Drawing.Point(419, 26);
            this.pbXE_KYE.Name = "pbXE_KYE";
            this.pbXE_KYE.Size = new System.Drawing.Size(32, 32);
            this.pbXE_KYE.TabIndex = 45;
            this.tooltip.SetToolTip(this.pbXE_KYE, "Send update when ‘keycode enabled’ mask has changed");
            // 
            // pbXE_PWR
            // 
            this.pbXE_PWR.BackColor = System.Drawing.Color.Silver;
            this.pbXE_PWR.Location = new System.Drawing.Point(115, 26);
            this.pbXE_PWR.Name = "pbXE_PWR";
            this.pbXE_PWR.Size = new System.Drawing.Size(32, 32);
            this.pbXE_PWR.TabIndex = 37;
            this.tooltip.SetToolTip(this.pbXE_PWR, "Send update when power state has changed");
            // 
            // btnReadTransmitEnableSettings
            // 
            this.btnReadTransmitEnableSettings.Location = new System.Drawing.Point(14, 35);
            this.btnReadTransmitEnableSettings.Name = "btnReadTransmitEnableSettings";
            this.btnReadTransmitEnableSettings.Size = new System.Drawing.Size(85, 23);
            this.btnReadTransmitEnableSettings.TabIndex = 35;
            this.btnReadTransmitEnableSettings.Text = "Read config";
            this.btnReadTransmitEnableSettings.UseVisualStyleBackColor = true;
            this.btnReadTransmitEnableSettings.Click += new System.EventHandler(this.btnReadTransmitEnableSettings_Click);
            // 
            // tpKeyControl
            // 
            this.tpKeyControl.Controls.Add(this.tableKeys);
            this.tpKeyControl.Location = new System.Drawing.Point(4, 22);
            this.tpKeyControl.Name = "tpKeyControl";
            this.tpKeyControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpKeyControl.Size = new System.Drawing.Size(1005, 475);
            this.tpKeyControl.TabIndex = 3;
            this.tpKeyControl.Text = "Key Control";
            this.tpKeyControl.UseVisualStyleBackColor = true;
            // 
            // tableKeys
            // 
            this.tableKeys.ColumnCount = 1;
            this.tableKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableKeys.Controls.Add(this.pnlKeyControlTop, 0, 0);
            this.tableKeys.Controls.Add(this.pnlKeyControlBottom, 0, 1);
            this.tableKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKeys.Location = new System.Drawing.Point(3, 3);
            this.tableKeys.Name = "tableKeys";
            this.tableKeys.RowCount = 2;
            this.tableKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKeys.Size = new System.Drawing.Size(999, 469);
            this.tableKeys.TabIndex = 2;
            // 
            // pnlKeyControlTop
            // 
            this.pnlKeyControlTop.Controls.Add(this.dgvKeyEmulation);
            this.pnlKeyControlTop.Controls.Add(this.lblKeyPressEmulate);
            this.pnlKeyControlTop.Controls.Add(this.lblKeyEmulationDescription);
            this.pnlKeyControlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKeyControlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlKeyControlTop.Name = "pnlKeyControlTop";
            this.pnlKeyControlTop.Size = new System.Drawing.Size(1318, 228);
            this.pnlKeyControlTop.TabIndex = 6;
            // 
            // dgvKeyEmulation
            // 
            this.dgvKeyEmulation.AllowUserToAddRows = false;
            this.dgvKeyEmulation.AllowUserToDeleteRows = false;
            this.dgvKeyEmulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKeyEmulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyEmulation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcKeyName,
            this.dgvcPress,
            this.dgvcRelease});
            this.dgvKeyEmulation.Location = new System.Drawing.Point(16, 41);
            this.dgvKeyEmulation.Margin = new System.Windows.Forms.Padding(16);
            this.dgvKeyEmulation.Name = "dgvKeyEmulation";
            this.dgvKeyEmulation.ReadOnly = true;
            this.dgvKeyEmulation.RowTemplate.Height = 30;
            this.dgvKeyEmulation.Size = new System.Drawing.Size(1286, 185);
            this.dgvKeyEmulation.TabIndex = 0;
            this.dgvKeyEmulation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyEmulation_CellContentClick);
            // 
            // dgvcKeyName
            // 
            this.dgvcKeyName.HeaderText = "Key";
            this.dgvcKeyName.Name = "dgvcKeyName";
            this.dgvcKeyName.ReadOnly = true;
            // 
            // dgvcPress
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvcPress.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcPress.HeaderText = "Press";
            this.dgvcPress.Name = "dgvcPress";
            this.dgvcPress.ReadOnly = true;
            this.dgvcPress.Text = "Press";
            // 
            // dgvcRelease
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvcRelease.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcRelease.HeaderText = "Release";
            this.dgvcRelease.Name = "dgvcRelease";
            this.dgvcRelease.ReadOnly = true;
            this.dgvcRelease.Text = "Release";
            // 
            // lblKeyPressEmulate
            // 
            this.lblKeyPressEmulate.AutoSize = true;
            this.lblKeyPressEmulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyPressEmulate.Location = new System.Drawing.Point(25, 16);
            this.lblKeyPressEmulate.Name = "lblKeyPressEmulate";
            this.lblKeyPressEmulate.Size = new System.Drawing.Size(148, 16);
            this.lblKeyPressEmulate.TabIndex = 59;
            this.lblKeyPressEmulate.Text = "Key press emulation";
            this.lblKeyPressEmulate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKeyEmulationDescription
            // 
            this.lblKeyEmulationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyEmulationDescription.Location = new System.Drawing.Point(187, 10);
            this.lblKeyEmulationDescription.Name = "lblKeyEmulationDescription";
            this.lblKeyEmulationDescription.Size = new System.Drawing.Size(586, 33);
            this.lblKeyEmulationDescription.TabIndex = 58;
            this.lblKeyEmulationDescription.Text = "The buttons below allow for keypresses to be internally processed. This works, re" +
    "gardless of whether keys are disabled.\r\nNote: after every press, a release is ex" +
    "pected (see KYD, KYE on Advanced tab).";
            // 
            // pnlKeyControlBottom
            // 
            this.pnlKeyControlBottom.Controls.Add(this.label8);
            this.pnlKeyControlBottom.Controls.Add(this.label10);
            this.pnlKeyControlBottom.Controls.Add(this.pbMirrored_KYD);
            this.pnlKeyControlBottom.Controls.Add(this.pbMirrored_KYE);
            this.pnlKeyControlBottom.Controls.Add(this.btnReadKeysEnabled);
            this.pnlKeyControlBottom.Controls.Add(this.lblKeyEnablingDescription);
            this.pnlKeyControlBottom.Controls.Add(this.label9);
            this.pnlKeyControlBottom.Controls.Add(this.dgvKeyEnabling);
            this.pnlKeyControlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKeyControlBottom.Location = new System.Drawing.Point(3, 237);
            this.pnlKeyControlBottom.Name = "pnlKeyControlBottom";
            this.pnlKeyControlBottom.Size = new System.Drawing.Size(1318, 229);
            this.pnlKeyControlBottom.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(835, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "KYD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(913, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "KYE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbMirrored_KYD
            // 
            this.pbMirrored_KYD.BackColor = System.Drawing.Color.Silver;
            this.pbMirrored_KYD.Location = new System.Drawing.Point(879, 4);
            this.pbMirrored_KYD.Name = "pbMirrored_KYD";
            this.pbMirrored_KYD.Size = new System.Drawing.Size(32, 32);
            this.pbMirrored_KYD.TabIndex = 64;
            this.tooltip.SetToolTip(this.pbMirrored_KYD, "KYD - Key disable\r\n\r\nOn=Disable front panel keys, overrides ‘KYE’.\r\nOff=Enable fr" +
        "ont panel keys (allows ‘KYE’ and ‘KE’ settings).");
            // 
            // pbMirrored_KYE
            // 
            this.pbMirrored_KYE.BackColor = System.Drawing.Color.Silver;
            this.pbMirrored_KYE.Location = new System.Drawing.Point(955, 4);
            this.pbMirrored_KYE.Name = "pbMirrored_KYE";
            this.pbMirrored_KYE.Size = new System.Drawing.Size(32, 32);
            this.pbMirrored_KYE.TabIndex = 63;
            this.tooltip.SetToolTip(this.pbMirrored_KYE, "KYE - Key enable\r\n\r\nOn=Enable all front panel keys, overrides ‘KE’ settings.\r\nOff" +
        "=Use individual ‘KE’ settings for front panels keys.");
            // 
            // btnReadKeysEnabled
            // 
            this.btnReadKeysEnabled.Location = new System.Drawing.Point(272, 9);
            this.btnReadKeysEnabled.Name = "btnReadKeysEnabled";
            this.btnReadKeysEnabled.Size = new System.Drawing.Size(75, 23);
            this.btnReadKeysEnabled.TabIndex = 62;
            this.btnReadKeysEnabled.Text = "Read config";
            this.btnReadKeysEnabled.UseVisualStyleBackColor = true;
            this.btnReadKeysEnabled.Click += new System.EventHandler(this.btnReadKeysEnabled_Click);
            // 
            // lblKeyEnablingDescription
            // 
            this.lblKeyEnablingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyEnablingDescription.Location = new System.Drawing.Point(363, 7);
            this.lblKeyEnablingDescription.Name = "lblKeyEnablingDescription";
            this.lblKeyEnablingDescription.Size = new System.Drawing.Size(430, 33);
            this.lblKeyEnablingDescription.TabIndex = 61;
            this.lblKeyEnablingDescription.Text = "This allows individual front panel keys to be enabled or disabled. Note that this" +
    " works\r\nin conjunction with the KYE and KYD settings on the advanced tab, mirror" +
    "ed on the right.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Enable/disable front panel keys";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvKeyEnabling
            // 
            this.dgvKeyEnabling.AllowUserToAddRows = false;
            this.dgvKeyEnabling.AllowUserToDeleteRows = false;
            this.dgvKeyEnabling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKeyEnabling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyEnabling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgvcKeyIsEnabled,
            this.dgvcKeyEnable,
            this.dgvcKeyDisable,
            this.dgvcKeyEnableToggle});
            this.dgvKeyEnabling.Location = new System.Drawing.Point(16, 42);
            this.dgvKeyEnabling.Name = "dgvKeyEnabling";
            this.dgvKeyEnabling.ReadOnly = true;
            this.dgvKeyEnabling.RowTemplate.Height = 30;
            this.dgvKeyEnabling.Size = new System.Drawing.Size(1286, 174);
            this.dgvKeyEnabling.TabIndex = 1;
            this.dgvKeyEnabling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyEnabling_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvcKeyIsEnabled
            // 
            this.dgvcKeyIsEnabled.HeaderText = "Is enabled?";
            this.dgvcKeyIsEnabled.Name = "dgvcKeyIsEnabled";
            this.dgvcKeyIsEnabled.ReadOnly = true;
            this.dgvcKeyIsEnabled.ThreeState = true;
            // 
            // dgvcKeyEnable
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvcKeyEnable.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcKeyEnable.HeaderText = "Enable";
            this.dgvcKeyEnable.Name = "dgvcKeyEnable";
            this.dgvcKeyEnable.ReadOnly = true;
            this.dgvcKeyEnable.Text = "Enable";
            // 
            // dgvcKeyDisable
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvcKeyDisable.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvcKeyDisable.HeaderText = "Disable";
            this.dgvcKeyDisable.Name = "dgvcKeyDisable";
            this.dgvcKeyDisable.ReadOnly = true;
            this.dgvcKeyDisable.Text = "Disable";
            // 
            // dgvcKeyEnableToggle
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvcKeyEnableToggle.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvcKeyEnableToggle.HeaderText = "Toggle";
            this.dgvcKeyEnableToggle.Name = "dgvcKeyEnableToggle";
            this.dgvcKeyEnableToggle.ReadOnly = true;
            this.dgvcKeyEnableToggle.Text = "Toggle";
            // 
            // fctbLog
            // 
            this.fctbLog.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.fctbLog.BackBrush = null;
            this.fctbLog.CharHeight = 15;
            this.fctbLog.CharWidth = 7;
            this.fctbLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctbLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fctbLog.IsReplaceMode = false;
            this.fctbLog.Location = new System.Drawing.Point(0, 0);
            this.fctbLog.Name = "fctbLog";
            this.fctbLog.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbLog.Size = new System.Drawing.Size(1013, 184);
            this.fctbLog.TabIndex = 1;
            this.fctbLog.Zoom = 100;
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 24);
            this.split.Name = "split";
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.tabs);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.fctbLog);
            this.split.Size = new System.Drawing.Size(1013, 689);
            this.split.SplitterDistance = 501;
            this.split.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 713);
            this.Controls.Add(this.split);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Zektor Prowler/Clarity Elite controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tpMainConfig.ResumeLayout(false);
            this.gbMasterVolume.ResumeLayout(false);
            this.gbMasterVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbMasterVolume)).EndInit();
            this.gbPowerConfig.ResumeLayout(false);
            this.gbPowerConfig.PerformLayout();
            this.gbZones.ResumeLayout(false);
            this.flowLayoutZones.ResumeLayout(false);
            this.gbAudioMode.ResumeLayout(false);
            this.gbAudioMode.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.gbDeviceStatus.ResumeLayout(false);
            this.gbDeviceStatus.PerformLayout();
            this.gbLedIntensity.ResumeLayout(false);
            this.gbLedIntensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDimmed)).EndInit();
            this.gbAdvancedControls.ResumeLayout(false);
            this.gbXS.ResumeLayout(false);
            this.gbXS.PerformLayout();
            this.gbTransmitChanged.ResumeLayout(false);
            this.gbTransmitChanged.PerformLayout();
            this.tpKeyControl.ResumeLayout(false);
            this.tableKeys.ResumeLayout(false);
            this.pnlKeyControlTop.ResumeLayout(false);
            this.pnlKeyControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyEmulation)).EndInit();
            this.pnlKeyControlBottom.ResumeLayout(false);
            this.pnlKeyControlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyEnabling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbLog)).EndInit();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tpMainConfig;
        private System.Windows.Forms.TabPage tpAVControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutZones;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.GroupBox gbTransmitChanged;
        private System.Windows.Forms.GroupBox gbLedIntensity;
        private System.Windows.Forms.TextBox tbFirmwareVersion;
        private System.Windows.Forms.Label lblVersionInfo;
        private System.Windows.Forms.TextBox tbLastErrorCode;
        private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Button btnChangeIP;
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
        private System.Windows.Forms.TabPage tpKeyControl;
        private System.Windows.Forms.TableLayoutPanel tableKeys;
        private System.Windows.Forms.DataGridView dgvKeyEmulation;
        private System.Windows.Forms.Button btnReadIP;
        private System.Windows.Forms.Button btnReadErrorCode;
        private System.Windows.Forms.Button btnReadFirmware;
        private System.Windows.Forms.Label lblStandby;
        private System.Windows.Forms.Label lblDimmed;
        private System.Windows.Forms.Label lblBright;
        private System.Windows.Forms.NumericUpDown nudStandby;
        private System.Windows.Forms.NumericUpDown nudDimmed;
        private System.Windows.Forms.NumericUpDown nudBright;
        private System.Windows.Forms.Button btnChangeLightingMode;
        private System.Windows.Forms.Button btnReadLightingMode;
        private System.Windows.Forms.Label lblLightingMode;
        private System.Windows.Forms.ComboBox cbLightingMode;
        private System.Windows.Forms.GroupBox gbDeviceStatus;
        private System.Windows.Forms.Button btnReadCapabilities;
        private System.Windows.Forms.TextBox tbCapabilities;
        private System.Windows.Forms.Label lblCapabilities;
        private System.Windows.Forms.Label lblPct3;
        private System.Windows.Forms.Label lblPct2;
        private System.Windows.Forms.Label lblPct1;
        private System.Windows.Forms.Button btnReadControlSettings;
        private System.Windows.Forms.Label lblClickToToggleXS;
        private System.Windows.Forms.Label lblClickToToggleXE;
        private System.Windows.Forms.Label lblKYE2;
        private System.Windows.Forms.Label lblCTL;
        private System.Windows.Forms.Label lblLMI;
        private System.Windows.Forms.Label lblIRR;
        private System.Windows.Forms.Label lblKEY;
        private System.Windows.Forms.Label lblQDZ;
        private System.Windows.Forms.Label lblQMZ;
        private System.Windows.Forms.Label lblQSZ;
        private System.Windows.Forms.Label lblPWR;
        private System.Windows.Forms.Panel pbXE_CTL;
        private System.Windows.Forms.Panel pbXE_LMI;
        private System.Windows.Forms.Panel pbXE_QDZ;
        private System.Windows.Forms.Panel pbXE_IRR;
        private System.Windows.Forms.Panel pbXE_QMZ;
        private System.Windows.Forms.Panel pbXE_KEY;
        private System.Windows.Forms.Panel pbXE_QSZ;
        private System.Windows.Forms.Panel pbXE_KYE;
        private System.Windows.Forms.Panel pbXE_PWR;
        private System.Windows.Forms.Button btnReadTransmitEnableSettings;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.Panel pnlKeyControlTop;
        private System.Windows.Forms.Panel pnlKeyControlBottom;
        private System.Windows.Forms.DataGridView dgvKeyEnabling;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Label lblOptimizeDescription;
        private System.Windows.Forms.Label lblKeyPressEmulate;
        private System.Windows.Forms.Label lblKeyEmulationDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKeyEnablingDescription;
        private System.Windows.Forms.Button btnReadKeysEnabled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pbMirrored_KYD;
        private System.Windows.Forms.Panel pbMirrored_KYE;
        private System.Windows.Forms.GroupBox gbXS;
        private System.Windows.Forms.GroupBox gbAdvancedControls;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcKeyName;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcPress;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcKeyIsEnabled;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcKeyEnable;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcKeyDisable;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcKeyEnableToggle;
        private System.Windows.Forms.GroupBox gbZones;
        private System.Windows.Forms.GroupBox gbPowerConfig;
        private System.Windows.Forms.TrackBar tkbMasterVolume;
        private System.Windows.Forms.GroupBox gbAudioMode;
        private System.Windows.Forms.Button btnReadAudioMode;
        private System.Windows.Forms.Button btnChangeAudioMode;
        private System.Windows.Forms.RadioButton rbAudioModeClassic;
        private System.Windows.Forms.RadioButton rbAudioModeAutoConvert;
        private System.Windows.Forms.Label lblVolumeLevel;
        private System.Windows.Forms.Label lblPowerStateVal;
        private System.Windows.Forms.Label lblPowerState;
        private System.Windows.Forms.Button btnPowerToggle;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.GroupBox gbMasterVolume;
        private System.Windows.Forms.Button btnReadMasterVolume;
        private System.Windows.Forms.Button btnChangeMasterVolume;
        private System.Windows.Forms.Label lblVolumeLevelVal;
        private System.Windows.Forms.Label lblConnectionStateVal;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

